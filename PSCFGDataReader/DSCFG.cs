﻿using static PSCFGDataReader.PSCFGData_TouchPenProcessor0C37;

namespace PSCFGDataReader
{
    internal class DSCFG
    {
        public static DecompiledProjectFile.DecompiledConfigurationFileStruct GetDecompiledConfigurationFileStructFromBinaryFilePath(string FilePath)
        {
            return GetDecompiledConfigurationFileStruct(File.OpenRead(FilePath));
        }

        public static DecompiledProjectFile.DecompiledConfigurationFileStruct GetDecompiledConfigurationFileStruct(byte[] buffer)
        {
            return GetDecompiledConfigurationFileStruct(new MemoryStream(buffer));
        }

        public static DecompiledProjectFile.DecompiledConfigurationFileStruct GetDecompiledConfigurationFileStruct(Stream stream)
        {
            return GetDecompiledConfigurationFileStruct(new BinaryReader(stream));
        }

        public static DecompiledProjectFile.DecompiledConfigurationFileStruct GetDecompiledConfigurationFileStruct(BinaryReader br)
        {
            long Beginning = br.BaseStream.Position;

            ConfigHeaderStruct Header = br.FromBinaryReader<ConfigHeaderStruct>();

            if (Header.LenFile > br.BaseStream.Length)
            {
                throw new Exception("Invalid Structure Length!");
            }

            DecompiledProjectFile.DecompiledConfigurationFileStruct decompiledConfigurationFileStruct = new()
            {
                Header = Header,
                ConfigSections = Array.Empty<DecompiledProjectFile.DecompiledConfigSection>()
            };

            // Parse every section minus the checksum at the end

            while (br.BaseStream.Position < Beginning + Header.LenFile - 2)
            {
                DecompiledProjectFile.DecompiledConfigSection decompiledConfigSection = new();

                ConfigSectionHeader sectionHeader = br.FromBinaryReader<ConfigSectionHeader>();
                decompiledConfigSection.Header = sectionHeader;

                byte[] payload = br.ReadBytes(sectionHeader.Len);
                decompiledConfigSection.Payload = payload;

                decompiledConfigurationFileStruct.ConfigSections = decompiledConfigurationFileStruct.ConfigSections.Append(decompiledConfigSection).ToArray();
            }

            if (br.BaseStream.Position == Beginning + Header.LenFile - 2)
            {
                // Parse the checksum (2 bytes)
                decompiledConfigurationFileStruct.KernelConfigFileCheckSum = br.ReadUInt16();
            }

            return decompiledConfigurationFileStruct;
        }

        public static DecompiledProjectFile.DecompiledConfigurationFileStruct GetDecompiledConfigurationFileStructFromXMLFilePath(string FilePath)
        {
            return GetDecompiledConfigurationFileStructFromXMLStream(File.OpenRead(FilePath));
        }

        public static DecompiledProjectFile.DecompiledConfigurationFileStruct GetDecompiledConfigurationFileStructFromXMLStream(Stream stream)
        {
            return stream.Deserialize<DecompiledProjectFile.DecompiledConfigurationFileStruct>();
        }

        public static string GetDecompiledConfigurationFileStructAsXml(DecompiledProjectFile.DecompiledConfigurationFileStruct fileStruct)
        {
            return fileStruct.Serialize();
        }

        public static byte[] GetDecompiledConfigurationFileStructAsByteArray(DecompiledProjectFile.DecompiledConfigurationFileStruct fileStruct)
        {
            byte[] buffer = new byte[fileStruct.Header.LenFile];
            using MemoryStream stream = new(buffer);
            using BinaryWriter bw = new(stream);

            bw.Write(fileStruct.Header.FromStructure());

            foreach (DecompiledProjectFile.DecompiledConfigSection section in fileStruct.ConfigSections)
            {
                bw.Write(section.Header.FromStructure());
                bw.Write(section.Payload);
            }

            bw.Write(fileStruct.KernelConfigFileCheckSum);

            return buffer;
        }
    }
}

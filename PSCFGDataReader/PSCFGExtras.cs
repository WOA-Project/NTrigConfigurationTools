using System.Runtime.InteropServices;
using PSCFGDataReader.Data;
using PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64;

namespace PSCFGDataReader
{
    internal partial class PSCFGExtras
    {
        public static void ParseRaw(string FilePath)
        {
            DecompiledProjectFile.DecompiledConfigurationFileStruct decompiledConfigurationFile = DSCFG.GetDecompiledConfigurationFileStructFromBinaryFilePath(FilePath);

            foreach (DecompiledProjectFile.DecompiledConfigSection section in decompiledConfigurationFile.ConfigSections)
            {
                Console.WriteLine("Section Id: " + section.Header.Id);
                Console.WriteLine("Section Type: " + section.Header.Type);
                Console.WriteLine("Section Length: " + section.Header.Len);

                if (Enum.IsDefined(typeof(SectionId), section.Header.Id))
                {
                    SectionId sectionId = (SectionId)section.Header.Id;
                    Console.WriteLine("Section ID (Friendly Name): " + sectionId);

                    File.WriteAllBytes($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.bin", section.Payload);

                    using MemoryStream payloadStream = new(section.Payload);
                    using BinaryReader br = new(payloadStream);

                    switch (sectionId)
                    {
                        case SectionId.Topology:
                            WriteSectionAsXml<TopologyDataCfg>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.PenJnr:
                            WriteSectionAsXml<PenJnrCfg>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.PenTrackingThresholds:
                            WriteSectionAsXml<PenThrsAndTrackCfgTuning>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.ReportMechanism:
                            WriteSectionAsXml<ReportMechanism>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.TouchPostProcessing:
                            WriteSectionAsXml<TouchPostProcessingCfg>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.Descriptor:
                            WriteSectionAsXml<DescriptorsCfg>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.TouchData:
                            WriteSectionAsXml<TouchTrackDataCfg>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.StaticConfig:
                            WriteSectionAsXml<StaticConfig>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.TouchDetection:
                            WriteSectionAsXml<TouchDetectionCfg>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.CampoConfig:
                            WriteSectionAsXml<CampoCfg>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.TelemetryConfig:
                            WriteSectionAsXml<TelemetryCfg>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.DataSelction:
                            WriteSectionAsXml<DataSelectionCfg>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.PenMagToBits:
                            WriteSectionAsXml<PenMagToBitsCfg>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.PenCenterOfMass:
                            WriteSectionAsXml<PenCenterOfMassCfg>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.PenDigitalProcessing:
                            WriteSectionAsXml<PenDigitalProcessingCfg>(section, sectionId, FilePath, br);
                            break;
                        case SectionId.PenZeroForceInking:
                            WriteSectionAsXml<PenZeroForceInkingCfg>(section, sectionId, FilePath, br);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Unknown Section ID Friendly Name!");

                    File.WriteAllBytes($"{Path.GetDirectoryName(FilePath)}\\{section.Header.Id}.bin", section.Payload);
                }

                Console.WriteLine();
            }
        }

        private static void WriteSectionAsXml<T>(DecompiledProjectFile.DecompiledConfigSection section, SectionId sectionId, string FilePath, BinaryReader br)
        {
            if (section.Payload.Length != Marshal.SizeOf<T>())
            {
                Console.WriteLine($"Invalid {typeof(T).Name} size! Expected: {Marshal.SizeOf<T>()}");
                return;
            }

            T structure = br.FromBinaryReader<T>();
            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", structure.Serialize(), System.Text.Encoding.Unicode);
        }

        public static void ParseRaw2(string SourceFilePath, string DestFilePath)
        {
            List<(ConfigSectionHeader sectionHeader, long offset)> mapping = new();

            using FileStream destinationStream = File.Open(DestFilePath, FileMode.Open, FileAccess.ReadWrite);
            using BinaryReader destinationBr = new(destinationStream);

            ConfigHeaderStruct destinationHeader = destinationBr.FromBinaryReader<ConfigHeaderStruct>();

            // Parse every section minus the checksum at the end

            while (destinationStream.Position < destinationHeader.LenFile - 2)
            {
                ConfigSectionHeader sectionHeader = destinationBr.FromBinaryReader<ConfigSectionHeader>();
                mapping.Add((sectionHeader, destinationStream.Position));
                destinationStream.Seek(sectionHeader.Len, SeekOrigin.Current); // Skip payload for now
            }

            using FileStream sourceStream = File.OpenRead(SourceFilePath);
            using BinaryReader sourceBr = new(sourceStream);

            ConfigHeaderStruct sourceHeader = sourceBr.FromBinaryReader<ConfigHeaderStruct>();

            // Parse every section minus the checksum at the end

            while (sourceStream.Position < sourceHeader.LenFile - 2)
            {
                ConfigSectionHeader sourceSectionHeader = sourceBr.FromBinaryReader<ConfigSectionHeader>();

                Console.WriteLine("Section Id: " + sourceSectionHeader.Id);
                Console.WriteLine("Section Type: " + sourceSectionHeader.Type);
                Console.WriteLine("Section Length: " + sourceSectionHeader.Len);

                if (Enum.IsDefined(typeof(SectionId), sourceSectionHeader.Id))
                {
                    SectionId sourceSectionId = (SectionId)sourceSectionHeader.Id;
                    Console.WriteLine("Section ID (Friendly Name): " + sourceSectionId);
                }
                else
                {
                    Console.WriteLine("Unknown Section ID Friendly Name!");
                }

                byte[] payload = sourceBr.ReadBytes(sourceSectionHeader.Len);

                foreach ((ConfigSectionHeader sectionHeader, long offset) in mapping)
                {
                    if (sectionHeader.Id == sourceSectionHeader.Id && sectionHeader.Len == payload.Length)
                    {
                        Console.WriteLine($"Writing at {offset}...");
                        destinationStream.Seek(offset, SeekOrigin.Begin);
                        destinationStream.Write(payload, 0, payload.Length);
                    }
                }

                //sourceStream.Seek(sourceSectionHeader.Len, SeekOrigin.Current); // Skip payload for now

                Console.WriteLine();
            }
        }
    }
}

using PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64;

namespace PSCFGDataReader
{
    internal class PSCFG
    {
        public static ConfigurationFileStruct GetConfigurationFileStructFromBinaryFilePath(string FilePath)
        {
            return GetConfigurationFileStruct(File.OpenRead(FilePath));
        }

        public static ConfigurationFileStruct GetConfigurationFileStruct(byte[] buffer)
        {
            return GetConfigurationFileStruct(new MemoryStream(buffer));
        }

        public static ConfigurationFileStruct GetConfigurationFileStruct(Stream stream)
        {
            return GetConfigurationFileStruct(new BinaryReader(stream));
        }

        public static ConfigurationFileStruct GetConfigurationFileStruct(BinaryReader br)
        {
            return br.FromBinaryReader<ConfigurationFileStruct>();
        }

        public static ConfigurationFileStruct GetConfigurationFileStructFromXMLFilePath(string FilePath)
        {
            return GetConfigurationFileStructFromXMLStream(File.OpenRead(FilePath));
        }

        public static ConfigurationFileStruct GetConfigurationFileStructFromXMLStream(Stream stream)
        {
            return stream.Deserialize<ConfigurationFileStruct>();
        }

        public static string GetConfigurationFileStructAsXml(ConfigurationFileStruct fileStruct)
        {
            return fileStruct.Serialize();
        }

        public static byte[] GetConfigurationFileStructAsByteArray(ConfigurationFileStruct fileStruct)
        {
            return fileStruct.FromStructure();
        }
    }
}

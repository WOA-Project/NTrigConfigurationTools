using PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64;
using System.Runtime.InteropServices;

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
            int structSize = Marshal.SizeOf<ConfigurationFileStruct>();
            if (br.BaseStream.Length != structSize)
            {
                throw new Exception($"Invalid Structure Length! Expected: {structSize} Actual: {br.BaseStream.Length}");
            }

            return br.FromBinaryReader<ConfigurationFileStruct>();
        }

        public static ConfigurationFileStruct GetConfigurationFileStructFromXMLFilePath(string FilePath)
        {
            return GetConfigurationFileStructFromXMLStream(File.OpenRead(FilePath));
        }

        public static ConfigurationFileStruct GetConfigurationFileStructFromXMLStream(Stream stream)
        {
            int structSize = Marshal.SizeOf<ConfigurationFileStruct>();
            if (stream.Length != structSize)
            {
                throw new Exception($"Invalid Structure Length! Expected: {structSize} Actual: {stream.Length}");
            }

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

using PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64;

namespace PSCFGDataReader
{
    public class DecompiledProjectFile
    {
        public struct DecompiledConfigSection
        {
            public ConfigSectionHeader Header
            {
                get; set;
            }

            public byte[] Payload
            {
                get; set;
            }
        }

        public struct DecompiledConfigurationFileStruct
        {
            public ConfigHeaderStruct Header
            {
                get; set;
            }

            public DecompiledConfigSection[] ConfigSections
            {
                get; set;
            }

            public ushort KernelConfigFileCheckSum
            {
                get; set;
            }
        };
    }
}

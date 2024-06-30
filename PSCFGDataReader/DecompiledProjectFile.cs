#if RELEASE_LIBSURFACETOUCHOEMB1_2022_902_48_ARM64 || DEBUG_LIBSURFACETOUCHOEMB1_2022_902_48_ARM64
using PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64;
#elif RELEASE_TOUCHPENPROCESSOR0C37_15_15_137_0_AMD64 || DEBUG_TOUCHPENPROCESSOR0C37_15_15_137_0_AMD64
using PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64;
#elif RELEASE_TOUCHPENPROCESSOR0C38_19_14_139_0_ARM64 || DEBUG_TOUCHPENPROCESSOR0C38_19_14_139_0_ARM64
using PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64;
#elif RELEASE_TOUCHPENPROCESSOR0996_4_253_137_0_ARM64 || DEBUG_TOUCHPENPROCESSOR0996_4_253_137_0_ARM64
using PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64;
#else
#error No processor defined
#endif

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

using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct FeaturesExclusionCfg
        {
            public uint FeaturesExclusionArraySize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] FeaturesExclusionArray { get; set; }
        };
}

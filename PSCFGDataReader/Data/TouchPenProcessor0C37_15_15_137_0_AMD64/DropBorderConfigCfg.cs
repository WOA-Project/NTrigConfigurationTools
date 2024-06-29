using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct DropBorderConfigCfg
        {
            public uint DropNumOfSides { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] DropAreaFromBorder { get; set; }
            public float HysteresisArea { get; set; }
            public byte IsEnable { get; set; }
        };
}

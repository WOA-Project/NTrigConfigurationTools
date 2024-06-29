using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
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

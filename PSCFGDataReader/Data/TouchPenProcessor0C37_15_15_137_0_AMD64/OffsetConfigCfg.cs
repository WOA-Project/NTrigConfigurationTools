using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct OffsetConfigCfg
        {
            public uint OffsetNumOfAxes { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public float[] Offset { get; set; }
            public float OffsetAngleSin { get; set; }
            public float OffsetAngleCos { get; set; }
            public byte IsAngularRotationEnabled { get; set; }
            public byte IsTouchOffsetEnabled { get; set; }
        };
}

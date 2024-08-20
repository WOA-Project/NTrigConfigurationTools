using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PostureDefsCfg
    {
        public ushort Unknown
        {
            get; set;
        }
        public ushort GapSizeBetweenSensorsHimetric
        {
            get; set;
        }
        public ushort GapSizeBetweenDisplaysHimetric
        {
            get; set;
        }
        public byte NumberOfRegions
        {
            get; set;
        }
        public byte GapAxis
        {
            get; set;
        }
        public byte LeftOrTopRegionIndex
        {
            get; set;
        }
        public uint IsAxisMirroredEntryCount
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] IsAxisMirrored
        {
            get; set;
        }
        public byte IsMaskModeEnabled
        {
            get; set;
        }
        public PanelAlignmentCfg PanelAlignmentDefines
        {
            get; set;
        }
    };
}

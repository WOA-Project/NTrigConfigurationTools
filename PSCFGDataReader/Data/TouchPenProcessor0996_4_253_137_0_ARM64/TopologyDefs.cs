using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct TopologyDefs
    {
        public ushort NumOfLongAnts
        {
            get; set;
        }
        public ushort NumOfShortAnts
        {
            get; set;
        }
        public ushort NumOfLongBordersAnts
        {
            get; set;
        }
        public ushort NumOfShortBordersAnts
        {
            get; set;
        }
        public byte NumOfPenLongAnts
        {
            get; set;
        }
        public byte NumOfPenShortAnts
        {
            get; set;
        }
        public byte InvertLongAntsPos
        {
            get; set;
        }
        public byte InvertShortAntsPos
        {
            get; set;
        }
        public byte IsRotateToPortrait
        {
            get; set;
        }
        public byte AxisTxTrack
        {
            get; set;
        }
        public byte AxisRxTrack
        {
            get; set;
        }
        public byte NumOfAtrigs
        {
            get; set;
        }
        public byte NumOfAtrigsOnLongAnt
        {
            get; set;
        }
        public byte NumOfAtrigsOnShortAnt
        {
            get; set;
        }
        public ushort AllAtrigsBitmap
        {
            get; set;
        }
        public ushort LongAntAtrigsBitmap
        {
            get; set;
        }
        public ushort ShortAntAtrigsBitmap
        {
            get; set;
        }
        public uint PhysicalMaxLong
        {
            get; set;
        }
        public uint PhysicalMaxShort
        {
            get; set;
        }
        public uint PhysicalMaxLongLCD
        {
            get; set;
        }
        public uint PhysicalMaxShortLCD
        {
            get; set;
        }
        public float PhysicalLongBorderPitch
        {
            get; set;
        }
        public uint LogicalMaxLong
        {
            get; set;
        }
        public uint LogicalMaxShort
        {
            get; set;
        }
        public uint IsFlipLongAxisSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] // Original code was one,   observed arrays of size 2 in real world, TODO: Look into this better
        public byte[] IsFlipLongAxis
        {
            get; set;
        }
    };
}

using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    public struct PenDigitalProcessingCfg
    {
        public ushort LogicOneSquareLlrThreshold
        {
            get; set;
        }
        public ushort LogicZeroSquareLlrThreshold
        {
            get; set;
        }
        public short I2HLlrThreshold
        {
            get; set;
        }
        public short H2ILlrThreshold
        {
            get; set;
        }
        public short I2ILlrThreshold
        {
            get; set;
        }
        public short H2HLlrThreshold
        {
            get; set;
        }
        public byte IsInkToHoverRingEnabled
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Padding
        {
            get; set;
        }
    };
}

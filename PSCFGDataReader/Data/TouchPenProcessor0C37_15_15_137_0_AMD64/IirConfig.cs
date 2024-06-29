using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct IirConfig
        {
            public uint PenIIRParamsLen { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public IirAlphaParams[] PenIIRParams { get; set; }
            public uint IirInHoverBasedOnHeightAndDistanceLen { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public HoverHeightFactorThreshold[] IirInHoverBasedOnHeightAndDistance { get; set; }
            public float PucAlgoSpecialAlpha { get; set; }
            public float PrevPressureCoeff { get; set; }
            public byte IsEnableExtremeSpeedAlphaLogic { get; set; }
        };
}

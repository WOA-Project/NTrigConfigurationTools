using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    public struct ZDistanceNeuralNetworkCfg
        {
            public uint FirstStepOffsetSize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
            public float[] FirstStepOffset { get; set; }
            public uint FirstStepGainSize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
            public float[] FirstStepGain { get; set; }
            public float FirstStepYMin { get; set; }
            public uint BiasLayer1Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
            public float[] BiasLayer1 { get; set; }
            public uint WeightsLayer1Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 392)]
            public float[] WeightsLayer1 { get; set; }
            public uint BiasLayer2Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public float[] BiasLayer2 { get; set; }
            public uint WeightsLayer2Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 560)]
            public float[] WeightsLayer2 { get; set; }
            public uint BiasLayer3Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public float[] BiasLayer3 { get; set; }
            public uint WeightsLayer3Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public float[] WeightsLayer3 { get; set; }
            public uint LastStepOffsetSize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public float[] LastStepOffset { get; set; }
            public uint LastStepGainSize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public float[] LastStepGain { get; set; }
            public float LastStepYMin { get; set; }
        };
}

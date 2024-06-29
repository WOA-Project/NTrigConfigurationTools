using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PredictionCfg
    {
        public float MaxiamlPredMatching
        {
            get; set;
        }
        public ushort NsrThForPrediction
        {
            get; set;
        }
        public float PredictionVelocityThreshold
        {
            get; set;
        }
        public byte NumOfSnrPredictions
        {
            get; set;
        }
    };
}

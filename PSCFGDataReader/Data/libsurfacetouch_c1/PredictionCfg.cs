using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
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

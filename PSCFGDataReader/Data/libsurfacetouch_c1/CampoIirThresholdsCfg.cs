using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct CampoIirThresholdsCfg
    {
        public float CampoSmoothingAlphaIirLowSpeed
        {
            get; set;
        }
        public float CampoSmoothingAlphaIirHighSpeed
        {
            get; set;
        }
        public float CampoSmoothingLowInAntsSpeedThreshold
        {
            get; set;
        }
        public float CampoSmoothingHighSpeedInAntsThreshold
        {
            get; set;
        }
        public byte MinNumberOfReportsToActivateSmoothing
        {
            get; set;
        }
    };
}

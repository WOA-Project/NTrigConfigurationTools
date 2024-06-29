using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
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

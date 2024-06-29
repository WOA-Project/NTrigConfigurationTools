using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct ReportMechanism
    {
        public uint TouchCapabilities
        {
            get; set;
        }
        public uint PenCapabilities
        {
            get; set;
        }
        public uint PenFeedbackWindowsBmp
        {
            get; set;
        }
        public byte IsFeedbackSupported
        {
            get; set;
        }
        public byte IsSendPostureFeedbacksImmediately
        {
            get; set;
        }
        public byte MaxNumberOfFingersSupported
        {
            get; set;
        }
        public byte MaxNumberOfPensSupported
        {
            get; set;
        }
        public byte IsDisplayChangeSupported
        {
            get; set;
        }
        public byte IsInputStitchingSupported
        {
            get; set;
        }
        public byte IsHingeAngleSupported
        {
            get; set;
        }
        public byte IsUseDefaultVendorData
        {
            get; set;
        }
        public Convert2BytesTo1ByteCfg Convert2BytesTo1Byte
        {
            get; set;
        }
        public byte IsEnablePenIdReport
        {
            get; set;
        }
        public byte IsRegionConfigSupported
        {
            get; set;
        }
        public byte IsEnableGenericCli
        {
            get; set;
        }
        public byte IsSendPenReportsPerScreen
        {
            get; set;
        }
    };
}

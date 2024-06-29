using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct ConfigurationFileStruct
    {
        public ConfigHeaderStruct Header
        {
            get; set;
        }
        public ConfigSectionHeader TopologyHeader
        {
            get; set;
        }
        public TopologyDataCfg TopologyPayload
        {
            get; set;
        }
        public ConfigSectionHeader PenJnrHeader
        {
            get; set;
        }
        public PenJnrCfg PenJnrPayload
        {
            get; set;
        }
        public ConfigSectionHeader PenTrackingThresholdsHeader
        {
            get; set;
        }
        public PenThrsAndTrackCfgTuning PenTrackingThresholdsPayload
        {
            get; set;
        }
        public ConfigSectionHeader ReportMechanismHeader
        {
            get; set;
        }
        public ReportMechanism ReportMechanismPayload
        {
            get; set;
        }
        public ConfigSectionHeader TouchPostProcessingHeader
        {
            get; set;
        }
        public TouchPostProcessingCfg TouchPostProcessingPayload
        {
            get; set;
        }
        public ConfigSectionHeader DescriptorHeader
        {
            get; set;
        }
        public DescriptorsCfg DescriptorPayload
        {
            get; set;
        }
        public ConfigSectionHeader TouchDataHeader
        {
            get; set;
        }
        public TouchTrackDataCfg TouchDataPayload
        {
            get; set;
        }
        public ConfigSectionHeader StaticConfigHeader
        {
            get; set;
        }
        public StaticConfig StaticConfigPayload
        {
            get; set;
        }
        public ConfigSectionHeader TouchDetectionHeader
        {
            get; set;
        }
        public TouchDetectionCfg TouchDetectionPayload
        {
            get; set;
        }
        public ConfigSectionHeader CampoConfigHeader
        {
            get; set;
        }
        public CampoCfg CampoConfigPayload
        {
            get; set;
        }
        public ConfigSectionHeader TelemetryConfigHeader
        {
            get; set;
        }
        public TelemetryCfg TelemetryConfigPayload
        {
            get; set;
        }
        public ConfigSectionHeader DataSelctionHeader
        {
            get; set;
        }
        public DataSelectionCfg DataSelectionPayload
        {
            get; set;
        }
        public ConfigSectionHeader PenMagToBitsHeader
        {
            get; set;
        }
        public PenMagToBitsCfg PenMagToBitsPayload
        {
            get; set;
        }
        public ConfigSectionHeader PenCenterOfMassHeader
        {
            get; set;
        }
        public PenCenterOfMassCfg PenCenterOfMassPayload
        {
            get; set;
        }
        public ConfigSectionHeader PenDigitalProcessingHeader
        {
            get; set;
        }
        public PenDigitalProcessingCfg PenDigitalProcessingPayload
        {
            get; set;
        }
        public ConfigSectionHeader PenZeroForceInkingHeader
        {
            get; set;
        }
        public PenZeroForceInkingCfg PenZeroForceInkingPayload
        {
            get; set;
        }
        public ushort KernelConfigFileCheckSum
        {
            get; set;
        }
    };
}

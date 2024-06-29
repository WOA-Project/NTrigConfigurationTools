using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct TouchPostProcessingCfg
    {
        public float MaximalCostHungarian
        {
            get; set;
        }
        public KalmanConfigCfg KalmanConfig
        {
            get; set;
        }
        public SmallFingerCfg SmallFinger
        {
            get; set;
        }
        public JitterRestrictorConfigCfg JitterRestrictorConfig
        {
            get; set;
        }
        public PalmManagerCfg Palm
        {
            get; set;
        }
        public MatchingCfg MatchingConfig
        {
            get; set;
        }
        public PredictionCfg Prediction
        {
            get; set;
        }
        public Pixel0Cfg Pixel0Config
        {
            get; set;
        }
        public StretchingConfig StretchingConfig
        {
            get; set;
        }
        public OffsetConfigCfg OffsetConfig
        {
            get; set;
        }
        public DropBorderConfigCfg DropBorderConfig
        {
            get; set;
        }
        public PostProcessingNoiseManageCfg NoiseManage
        {
            get; set;
        }
        public BlobSizeSmoothConfig BlobSizeSmoothCfg
        {
            get; set;
        }
        public FastMovement FastMovementCfg
        {
            get; set;
        }
        public TrackLibIirConfig TrackLibIirCfg
        {
            get; set;
        }
        public HomeButtonCfg HomeButton
        {
            get; set;
        }
        public byte IsRestrictedTobyteeaEnable
        {
            get; set;
        }
    };
}

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
{
    public struct CampoTrackingCfg
    {
        public float MaxSquarDistanceInAntsForCampoStaticJitterRestrictorThreshold
        {
            get; set;
        }
        public float MaxSquarDistanceInAntsForCampoDynamicJitterRestrictorThreshold
        {
            get; set;
        }
        public float MaxDistanceInAntsBetweenDetectedToTrackedCampo
        {
            get; set;
        }
        public float SpeedFactor
        {
            get; set;
        }
        public CampoIirThresholdsCfg CampoIirThresholds
        {
            get; set;
        }
        public byte MaxFramesCampoRemainValidBeforeClosing
        {
            get; set;
        }
        public byte MinFramesCampoRemainPreActiveBeforeTracking
        {
            get; set;
        }
        public byte DynamicToStaticCounterThreshold
        {
            get; set;
        }
        public byte IsEnableRoiTest
        {
            get; set;
        }
    };
}

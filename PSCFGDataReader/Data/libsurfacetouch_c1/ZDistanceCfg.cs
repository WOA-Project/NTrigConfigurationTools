namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    public struct ZDistanceCfg
    {
        public float MinimalSignalStrength
        {
            get; set;
        }
        public float MaxSupportedHeight
        {
            get; set;
        }
        public ZDistanceNeuralNetworkCfg NeuralNetworkConfig
        {
            get; set;
        }
    };
}

using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PenMagToBitsCfg
    {
        public uint HastaDigitalFreqsLookupSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public PenMagsToBitsLookup[] HastaDigitalFreqsLookup
        {
            get; set;
        }
        public uint HastaPressureFreqsLookupSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public PenMagsToBitsLookup[] HastaPressureFreqsLookup
        {
            get; set;
        }
        public uint HastaH2ILeftFreqsLookupSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public PenMagsToBitsLookup[] HastaH2ILeftFreqsLookup
        {
            get; set;
        }
        public uint HastaH2IRightFreqsLookupSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public PenMagsToBitsLookup[] HastaH2IRightFreqsLookup
        {
            get; set;
        }
        public uint HastaH2IBeaconFreqsLookupSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public PenMagsToBitsLookup[] HastaH2IBeaconFreqsLookup
        {
            get; set;
        }
        public uint SigmaShortNumOfGainSets
        {
            get; set;
        }
        public uint SigmaShortNumOfDigitalProc
        {
            get; set;
        }
        public uint SigmaShortNumOfDigitalFreq
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        public ushort[] SigmaSqrShort
        {
            get; set;
        }
        public uint SigmaLongNumOfGainSets
        {
            get; set;
        }
        public uint SigmaLongNumOfDigitalProc
        {
            get; set;
        }
        public uint SigmaLongNumOfDigitalFreq
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        public ushort[] SigmaSqrLong
        {
            get; set;
        }
        public byte ThMinHoverAmp
        {
            get; set;
        }
        public byte ThMaxHoldSelfNoise
        {
            get; set;
        }
        public byte ThRayAxesFree
        {
            get; set;
        }
        public byte ThRayAxesBlocked
        {
            get; set;
        }
        public byte ThRayAxesBlockedMaxHold
        {
            get; set;
        }
        public byte ThRayHoverInj
        {
            get; set;
        }
        public byte ThNoSig
        {
            get; set;
        }
        public byte ThSnrDiffSum
        {
            get; set;
        }
        public uint ThMinInkAmpNumOfGainSets
        {
            get; set;
        }
        public uint ThMinInkAmpNumOfAxes
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] ThMinInkAmp
        {
            get; set;
        }
        public uint Unknown0
        {
            get; set;
        }
        public byte WindowSizeFactor
        {
            get; set;
        }
        public byte HoverHandInjFactor
        {
            get; set;
        }
        public byte MaxSideTip
        {
            get; set;
        }
        public byte MaxSideRing
        {
            get; set;
        }
        public byte SigmaTrns
        {
            get; set;
        }
        public byte ThOok
        {
            get; set;
        }
    };
}
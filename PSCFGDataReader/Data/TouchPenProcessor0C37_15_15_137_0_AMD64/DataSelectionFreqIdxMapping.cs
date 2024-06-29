using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    public struct DataSelectionFreqIdxMapping
    {
        public uint NumOfPenWindows
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public DataSelectionFreqIdxMappingPerWindow[] DataSelectionFreqIdxMapPerWindow
        {
            get; set;
        }
    };
}

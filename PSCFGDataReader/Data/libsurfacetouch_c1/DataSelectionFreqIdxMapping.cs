using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
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

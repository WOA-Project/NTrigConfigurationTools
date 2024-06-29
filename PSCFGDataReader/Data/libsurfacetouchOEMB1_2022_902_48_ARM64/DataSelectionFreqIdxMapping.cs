using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    public struct DataSelectionFreqIdxMapping
        {
            public uint NumOfPenWindows { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public DataSelectionFreqIdxMappingPerWindow[] DataSelectionFreqIdxMapPerWindow { get; set; }
        };
}

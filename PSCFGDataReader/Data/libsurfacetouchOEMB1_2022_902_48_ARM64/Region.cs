using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    public struct Region
    {
        public uint NumOfAxes
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public Range[] AntsRange
        {
            get; set;
        }
    };
}

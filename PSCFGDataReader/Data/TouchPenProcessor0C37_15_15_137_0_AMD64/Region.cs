using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
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

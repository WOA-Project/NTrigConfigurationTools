using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    public struct TrackTreeClasificationStruct
    {
        public uint MinNumOfJunctionsToChangeTrackTypeSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] MinNumOfJunctionsToChangeTrackType
        {
            get; set;
        }
        public uint MaxNumOfJunctionsToChangeTrackTypeSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] MaxNumOfJunctionsToChangeTrackType
        {
            get; set;
        }
    };
}

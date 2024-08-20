using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
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

using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
{
    // TouchPenProcessor0C37.dll
    // Version 15.15.137.0
    // AMD64
    public struct ConfigVersionStruct
    {
        public byte SupportedSchemeMaj
        {
            get; set;
        }
        public byte SupportedSchemeMin
        {
            get; set;
        }
        public ushort ProjId
        {
            get; set;
        }
        public ushort ProjMaj
        {
            get; set;
        }
        public ushort ProjMin
        {
            get; set;
        }
        public ushort ProjectBuild
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Padding
        {
            get; set;
        }
    };
}

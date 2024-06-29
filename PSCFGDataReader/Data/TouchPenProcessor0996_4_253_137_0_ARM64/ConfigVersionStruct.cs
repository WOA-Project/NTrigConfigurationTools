using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    // TouchPenProcessor0996.dll
    // Version 4.253.137.0
    // ARM64
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

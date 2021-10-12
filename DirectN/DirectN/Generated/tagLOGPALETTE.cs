// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(1442,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagLOGPALETTE
    {
        public ushort palVersion;
        public ushort palNumEntries;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagPALETTEENTRY[] palPalEntry;
    }
}

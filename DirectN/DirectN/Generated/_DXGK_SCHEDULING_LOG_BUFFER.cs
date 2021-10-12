// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4833,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SCHEDULING_LOG_BUFFER
    {
        public _DXGK_SCHEDULING_LOG_HEADER Header;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _DXGK_SCHEDULING_LOG_ENTRY[] Entries;
    }
}

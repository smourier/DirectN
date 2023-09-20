// generated from <Windows SDK Path>\shared\d3dkmddi.h
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

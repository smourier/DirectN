// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_NATIVE_FENCE_LOG_BUFFER
    {
        public _DXGK_NATIVE_FENCE_LOG_HEADER Header;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _DXGK_NATIVE_FENCE_LOG_ENTRY[] Entries;
    }
}

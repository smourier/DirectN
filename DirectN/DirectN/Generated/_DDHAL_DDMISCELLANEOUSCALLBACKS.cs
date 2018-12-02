// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(819,9)
using System;
using System.Runtime.InteropServices;
using LPDDHAL_GETAVAILDRIVERMEMORY = System.IntPtr;
using LPDDHAL_GETHEAPALIGNMENT = System.IntPtr;
using LPDDHAL_UPDATENONLOCALHEAP = System.IntPtr;
using LPDDHALSURFCB_GETBLTSTATUS = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DDMISCELLANEOUSCALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr GetAvailDriverMemory;
        public IntPtr UpdateNonLocalHeap;
        public IntPtr GetHeapAlignment;
        public IntPtr GetSysmemBltStatus;
    }
}

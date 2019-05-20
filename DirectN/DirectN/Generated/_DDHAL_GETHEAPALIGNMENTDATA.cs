// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawi.h(2702,9)
using System;
using System.Runtime.InteropServices;
using LPDDHAL_GETHEAPALIGNMENT = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETHEAPALIGNMENTDATA
    {
        public IntPtr dwInstance;
        public uint dwHeap;
        public HRESULT ddRVal;
        public IntPtr GetHeapAlignment;
        public _HEAPALIGNMENT Alignment;
    }
}

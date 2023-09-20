// generated from <Windows SDK Path>\um\ddrawi.h
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

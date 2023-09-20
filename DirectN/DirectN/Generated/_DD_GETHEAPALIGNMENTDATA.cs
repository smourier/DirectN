// generated from <Windows SDK Path>\um\dmemmgr.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETHEAPALIGNMENTDATA
    {
        public IntPtr dwInstance;
        public uint dwHeap;
        public HRESULT ddRVal;
        public IntPtr GetHeapAlignment;
        public _HEAPALIGNMENT Alignment;
    }
}

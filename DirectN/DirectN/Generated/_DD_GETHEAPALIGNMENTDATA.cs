// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dmemmgr.h(87,9)
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

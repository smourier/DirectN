// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(4044,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_DEALLOCATE2
    {
        public IntPtr hResource;
        public uint NumAllocations;
        public IntPtr HandleList;
        public _D3DDDICB_DESTROYALLOCATION2FLAGS Flags;
    }
}

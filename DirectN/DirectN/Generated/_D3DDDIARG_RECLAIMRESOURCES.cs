// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(2068,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_RECLAIMRESOURCES
    {
        public IntPtr pResources;
        public IntPtr pDiscarded;
        public uint Resources;
    }
}

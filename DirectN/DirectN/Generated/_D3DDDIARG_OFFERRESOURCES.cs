// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2062,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_OFFERRESOURCES
    {
        public IntPtr pResources;
        public uint Resources;
        public _D3DDDI_OFFER_PRIORITY Priority;
    }
}

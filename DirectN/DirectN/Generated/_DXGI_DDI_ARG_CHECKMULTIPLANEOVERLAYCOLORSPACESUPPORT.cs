// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(538,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_CHECKMULTIPLANEOVERLAYCOLORSPACESUPPORT
    {
        public ulong hDevice;
        public int VidPnSourceId;
        public DXGI_FORMAT Format;
        public int ColorSpace;
        public bool Supported;
    }
}

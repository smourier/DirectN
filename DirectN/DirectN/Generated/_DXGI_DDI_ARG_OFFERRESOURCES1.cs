// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(593,9)
using System;
using System.Runtime.InteropServices;
using DXGI_DDI_HRESOURCE = System.UInt64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_OFFERRESOURCES1
    {
        public ulong hDevice;
        public IntPtr pResources;
        public uint Resources;
        public int Priority;
        public int Flags;
    }
}

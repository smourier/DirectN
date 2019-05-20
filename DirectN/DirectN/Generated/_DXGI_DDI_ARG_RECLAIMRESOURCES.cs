// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxgiddi.h(292,9)
using System;
using System.Runtime.InteropServices;
using DXGI_DDI_HRESOURCE = System.UInt64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_RECLAIMRESOURCES
    {
        public ulong hDevice;
        public IntPtr pResources;
        public IntPtr pDiscarded;
        public uint Resources;
    }
}

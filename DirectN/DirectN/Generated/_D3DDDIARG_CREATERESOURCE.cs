// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dukmdt.h(1279,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_CREATERESOURCE
    {
        public _D3DDDIFORMAT Format;
        public _D3DDDI_POOL Pool;
        public _D3DDDIMULTISAMPLE_TYPE MultisampleType;
        public uint MultisampleQuality;
        public IntPtr pSurfList;
        public uint SurfCount;
        public uint MipLevels;
        public uint Fvf;
        public uint VidPnSourceId;
        public _D3DDDI_RATIONAL RefreshRate;
        public IntPtr hResource;
        public _D3DDDI_RESOURCEFLAGS Flags;
        public _D3DDDI_ROTATION Rotation;
    }
}

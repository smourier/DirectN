// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(5326,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_HDR_METADATA
    {
        public _D3DDDI_HDR_METADATA_TYPE Type;
        public uint Size;
        public IntPtr pMetaData;
    }
}

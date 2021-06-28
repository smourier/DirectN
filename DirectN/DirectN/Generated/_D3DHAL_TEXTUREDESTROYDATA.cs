// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dhal.h(530,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_TEXTUREDESTROYDATA
    {
        public IntPtr dwhContext;
        public uint dwHandle;
        public HRESULT ddrval;
    }
}

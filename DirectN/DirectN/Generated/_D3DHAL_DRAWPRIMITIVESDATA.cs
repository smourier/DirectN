// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dhal.h(751,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_DRAWPRIMITIVESDATA
    {
        public IntPtr dwhContext;
        public uint dwFlags;
        public IntPtr lpvData;
        public uint dwFVFControl;
        public HRESULT ddrval;
    }
}

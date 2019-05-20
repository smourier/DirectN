// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dhal.h(521,9)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_TEXTURECREATEDATA
    {
        public IntPtr dwhContext;
        public IntPtr lpDDS;
        public uint dwHandle;
        public HRESULT ddrval;
    }
}

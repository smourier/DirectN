// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dhal.h(508,9)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_RENDERPRIMITIVEDATA
    {
        public IntPtr dwhContext;
        public uint dwOffset;
        public uint dwStatus;
        public IntPtr lpExeBuf;
        public uint dwTLOffset;
        public IntPtr lpTLBuf;
        public _D3DINSTRUCTION diInstruction;
        public HRESULT ddrval;
    }
}

// generated from <Windows SDK Path>\um\d3dhal.h
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

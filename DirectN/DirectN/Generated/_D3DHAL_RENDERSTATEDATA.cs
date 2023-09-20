// generated from <Windows SDK Path>\um\d3dhal.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_RENDERSTATEDATA
    {
        public IntPtr dwhContext;
        public uint dwOffset;
        public uint dwCount;
        public IntPtr lpExeBuf;
        public HRESULT ddrval;
    }
}

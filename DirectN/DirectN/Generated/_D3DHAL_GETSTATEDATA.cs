// generated from <Windows SDK Path>\um\d3dhal.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_GETSTATEDATA
    {
        public IntPtr dwhContext;
        public uint dwWhich;
        public _D3DSTATE ddState;
        public HRESULT ddrval;
    }
}

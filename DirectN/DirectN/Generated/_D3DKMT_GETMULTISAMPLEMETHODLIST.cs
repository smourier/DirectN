// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GETMULTISAMPLEMETHODLIST
    {
        public uint hAdapter;
        public uint VidPnSourceId;
        public uint Width;
        public uint Height;
        public _D3DDDIFORMAT Format;
        public IntPtr pMethodList;
        public uint MethodCount;
    }
}

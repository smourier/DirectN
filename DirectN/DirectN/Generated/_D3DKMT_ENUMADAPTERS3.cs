// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ENUMADAPTERS3
    {
        public _D3DKMT_ENUMADAPTERS_FILTER Filter;
        public uint NumAdapters;
        public IntPtr pAdapters;
    }
}

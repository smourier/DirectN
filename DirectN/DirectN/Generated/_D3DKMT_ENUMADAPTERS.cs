// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ENUMADAPTERS
    {
        public uint NumAdapters;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public _D3DKMT_ADAPTERINFO[] Adapters;
    }
}

// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GETRUNTIMEDATA
    {
        public uint hAdapter;
        public uint hGlobalShare;
        public IntPtr pRuntimeData;
        public uint RuntimeDataSize;
    }
}

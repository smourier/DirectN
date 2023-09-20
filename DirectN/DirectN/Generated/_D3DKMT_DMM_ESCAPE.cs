// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_DMM_ESCAPE
    {
        public _D3DKMT_DMMESCAPETYPE Type;
        public IntPtr ProvidedBufferSize;
        public IntPtr MinRequiredBufferSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] Data;
    }
}

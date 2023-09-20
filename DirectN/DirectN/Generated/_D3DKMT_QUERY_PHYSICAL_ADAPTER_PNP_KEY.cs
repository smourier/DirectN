// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERY_PHYSICAL_ADAPTER_PNP_KEY
    {
        public uint PhysicalAdapterIndex;
        public _D3DKMT_PNP_KEY_TYPE PnPKeyType;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public IntPtr pDest;
        public IntPtr pCchDest;
    }
}

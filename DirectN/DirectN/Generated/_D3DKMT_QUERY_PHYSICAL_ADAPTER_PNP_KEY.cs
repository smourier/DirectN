// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(2057,9)
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

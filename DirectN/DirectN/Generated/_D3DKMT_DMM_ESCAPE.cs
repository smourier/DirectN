// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2678,9)
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

// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva9typ.h(883,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPStatusOutput
    {
        public Guid macKDI;
        public uint cbSizeData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4076)] 
        public byte[] COPPStatus;
    }
}

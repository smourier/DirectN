// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dcaps.h(539,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DFINDDEVICERESULT
    {
        public uint dwSize;
        public Guid guid;
        public _D3DDeviceDesc ddHwDesc;
        public _D3DDeviceDesc ddSwDesc;
    }
}

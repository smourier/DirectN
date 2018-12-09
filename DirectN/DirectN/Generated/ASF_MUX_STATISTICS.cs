// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmcontainer.h(2023,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ASF_MUX_STATISTICS
    {
        public uint cFramesWritten;
        public uint cFramesDropped;
    }
}

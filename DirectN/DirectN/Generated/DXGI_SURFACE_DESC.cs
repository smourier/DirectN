// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dxgi.h(258,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_SURFACE_DESC
    {
        public uint Width;
        public uint Height;
        public DXGI_FORMAT Format;
        public DXGI_SAMPLE_DESC SampleDesc;
    }
}

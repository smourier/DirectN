// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgitype.h(105,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_JPEG_QUANTIZATION_TABLE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public byte[] Elements;
    }
}

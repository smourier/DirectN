// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11sdklayers.h(2143,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_MESSAGE
    {
        public D3D11_MESSAGE_CATEGORY Category;
        public D3D11_MESSAGE_SEVERITY Severity;
        public D3D11_MESSAGE_ID ID;
        [MarshalAs(UnmanagedType.LPStr)] 
        public byte pDescription;
        public IntPtr DescriptionByteLength;
    }
}

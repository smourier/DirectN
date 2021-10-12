// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxgidebug.h(132,9)
using System;
using System.Runtime.InteropServices;
using DXGI_DEBUG_ID = System.Guid;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_INFO_QUEUE_MESSAGE
    {
        public DXGI_DEBUG_ID Producer;
        public DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category;
        public DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity;
        public int ID;
        [MarshalAs(UnmanagedType.LPStr)] 
        public byte pDescription;
        public IntPtr DescriptionByteLength;
    }
}

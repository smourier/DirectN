using System;
using System.Runtime.InteropServices;
using DXGI_DEBUG_ID = System.Guid;
using DXGI_INFO_QUEUE_MESSAGE_ID = System.Int32;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_INFO_QUEUE_MESSAGE
    {
        public DXGI_DEBUG_ID Producer;
        public DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category;
        public DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity;
        public DXGI_INFO_QUEUE_MESSAGE_ID ID;
        public IntPtr pDescription;
        public IntPtr DescriptionByteLength;
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgidebug.h(124,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_INFO_QUEUE_MESSAGE
    {
        public Guid Producer;
        public DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category;
        public DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity;
        public int ID;
        public IntPtr pDescription;
        public ulong DescriptionByteLength;
    }
}

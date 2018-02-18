using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_INFO_QUEUE_FILTER
    {
        public DXGI_INFO_QUEUE_FILTER_DESC AllowList;
        public DXGI_INFO_QUEUE_FILTER_DESC DenyList;
    }
}

// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_QUERYCONNECTIONCHANGE
    {
        public _DXGK_CONNECTION_CHANGE ConnectionChange;
        public _DXGK_CONNECTION_USB4_INFO Usb4MonitorInfo;
    }
}

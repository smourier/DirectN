// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(7749,9)
using System;
using System.Runtime.InteropServices;
using DXGKCB_ENUMHANDLECHILDREN = System.IntPtr;
using DXGKCB_GETCAPTUREADDRESS = System.IntPtr;
using DXGKCB_GETHANDLEDATA = System.IntPtr;
using DXGKCB_GETHANDLEPARENT = System.IntPtr;
using DXGKCB_NOTIFY_DPC = System.IntPtr;
using DXGKCB_NOTIFY_INTERRUPT = System.IntPtr;
using DXGKCB_QUERYVIDPNINTERFACE = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_INTERFACESPECIFICDATA
    {
        public IntPtr hAdapter;
        public IntPtr pfnGetHandleDataCb;
        public IntPtr pfnGetHandleParentCb;
        public IntPtr pfnEnumHandleChildrenCb;
        public IntPtr pfnNotifyInterruptCb;
        public IntPtr pfnNotifyDpcCb;
        public IntPtr pfnQueryVidPnInterfaceCb;
        public IntPtr pfnGetCaptureAddressCb;
    }
}

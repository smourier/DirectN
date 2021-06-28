// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(921,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALVPORTCB_CANCREATEVIDEOPORT = System.IntPtr;
using LPDDHALVPORTCB_COLORCONTROL = System.IntPtr;
using LPDDHALVPORTCB_CREATEVIDEOPORT = System.IntPtr;
using LPDDHALVPORTCB_DESTROYVPORT = System.IntPtr;
using LPDDHALVPORTCB_FLIP = System.IntPtr;
using LPDDHALVPORTCB_GETBANDWIDTH = System.IntPtr;
using LPDDHALVPORTCB_GETFIELD = System.IntPtr;
using LPDDHALVPORTCB_GETFLIPSTATUS = System.IntPtr;
using LPDDHALVPORTCB_GETINPUTFORMATS = System.IntPtr;
using LPDDHALVPORTCB_GETLINE = System.IntPtr;
using LPDDHALVPORTCB_GETOUTPUTFORMATS = System.IntPtr;
using LPDDHALVPORTCB_GETSIGNALSTATUS = System.IntPtr;
using LPDDHALVPORTCB_GETVPORTCONNECT = System.IntPtr;
using LPDDHALVPORTCB_UPDATE = System.IntPtr;
using LPDDHALVPORTCB_WAITFORSYNC = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DDVIDEOPORTCALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr CanCreateVideoPort;
        public IntPtr CreateVideoPort;
        public IntPtr FlipVideoPort;
        public IntPtr GetVideoPortBandwidth;
        public IntPtr GetVideoPortInputFormats;
        public IntPtr GetVideoPortOutputFormats;
        public IntPtr lpReserved1;
        public IntPtr GetVideoPortField;
        public IntPtr GetVideoPortLine;
        public IntPtr GetVideoPortConnectInfo;
        public IntPtr DestroyVideoPort;
        public IntPtr GetVideoPortFlipStatus;
        public IntPtr UpdateVideoPort;
        public IntPtr WaitForVideoPortSync;
        public IntPtr GetVideoSignalStatus;
        public IntPtr ColorControl;
    }
}

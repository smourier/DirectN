// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(539,9)
using System;
using System.Runtime.InteropServices;
using PDD_VPORTCB_CANCREATEVIDEOPORT = System.IntPtr;
using PDD_VPORTCB_COLORCONTROL = System.IntPtr;
using PDD_VPORTCB_CREATEVIDEOPORT = System.IntPtr;
using PDD_VPORTCB_DESTROYVPORT = System.IntPtr;
using PDD_VPORTCB_FLIP = System.IntPtr;
using PDD_VPORTCB_GETBANDWIDTH = System.IntPtr;
using PDD_VPORTCB_GETFIELD = System.IntPtr;
using PDD_VPORTCB_GETFLIPSTATUS = System.IntPtr;
using PDD_VPORTCB_GETINPUTFORMATS = System.IntPtr;
using PDD_VPORTCB_GETLINE = System.IntPtr;
using PDD_VPORTCB_GETOUTPUTFORMATS = System.IntPtr;
using PDD_VPORTCB_GETSIGNALSTATUS = System.IntPtr;
using PDD_VPORTCB_GETVPORTCONNECT = System.IntPtr;
using PDD_VPORTCB_UPDATE = System.IntPtr;
using PDD_VPORTCB_WAITFORSYNC = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DD_VIDEOPORTCALLBACKS
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

// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(1016,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALMOCOMPCB_BEGINFRAME = System.IntPtr;
using LPDDHALMOCOMPCB_CREATE = System.IntPtr;
using LPDDHALMOCOMPCB_DESTROY = System.IntPtr;
using LPDDHALMOCOMPCB_ENDFRAME = System.IntPtr;
using LPDDHALMOCOMPCB_GETCOMPBUFFINFO = System.IntPtr;
using LPDDHALMOCOMPCB_GETFORMATS = System.IntPtr;
using LPDDHALMOCOMPCB_GETGUIDS = System.IntPtr;
using LPDDHALMOCOMPCB_GETINTERNALINFO = System.IntPtr;
using LPDDHALMOCOMPCB_QUERYSTATUS = System.IntPtr;
using LPDDHALMOCOMPCB_RENDER = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DDMOTIONCOMPCALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr GetMoCompGuids;
        public IntPtr GetMoCompFormats;
        public IntPtr CreateMoComp;
        public IntPtr GetMoCompBuffInfo;
        public IntPtr GetInternalMoCompInfo;
        public IntPtr BeginMoCompFrame;
        public IntPtr EndMoCompFrame;
        public IntPtr RenderMoComp;
        public IntPtr QueryMoCompStatus;
        public IntPtr DestroyMoComp;
    }
}

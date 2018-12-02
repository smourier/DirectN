// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(629,9)
using System;
using System.Runtime.InteropServices;
using PDD_MOCOMPCB_BEGINFRAME = System.IntPtr;
using PDD_MOCOMPCB_CREATE = System.IntPtr;
using PDD_MOCOMPCB_DESTROY = System.IntPtr;
using PDD_MOCOMPCB_ENDFRAME = System.IntPtr;
using PDD_MOCOMPCB_GETCOMPBUFFINFO = System.IntPtr;
using PDD_MOCOMPCB_GETFORMATS = System.IntPtr;
using PDD_MOCOMPCB_GETGUIDS = System.IntPtr;
using PDD_MOCOMPCB_GETINTERNALINFO = System.IntPtr;
using PDD_MOCOMPCB_QUERYSTATUS = System.IntPtr;
using PDD_MOCOMPCB_RENDER = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DD_MOTIONCOMPCALLBACKS
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

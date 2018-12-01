// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfplay.h(1112,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MFP_FRAME_STEP_EVENT
    {
        public MFP_EVENT_HEADER header;
        public IntPtr pMediaItem;
    }
}

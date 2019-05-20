// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(5592,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATEPERIODICFRAMENOTIFICATION
    {
        public IntPtr hAdapter;
        public uint VidPnTargetId;
        public ulong Time;
        public uint NotificationID;
        public IntPtr hNotification;
    }
}

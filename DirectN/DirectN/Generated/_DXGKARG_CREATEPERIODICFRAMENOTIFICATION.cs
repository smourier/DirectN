// generated from <Windows SDK Path>\shared\d3dkmddi.h
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

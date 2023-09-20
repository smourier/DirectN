// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;
using KSPIN_MDL_CACHING_EVENT = DirectN.KSPIN_MDL_CACHING_NOTIFY;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPIN_MDL_CACHING_NOTIFICATION
    {
        public KSPIN_MDL_CACHING_EVENT Event;
        public IntPtr Buffer;
    }
}

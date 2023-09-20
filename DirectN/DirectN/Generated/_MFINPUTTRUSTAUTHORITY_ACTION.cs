// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFINPUTTRUSTAUTHORITY_ACTION
    {
        public _MFPOLICYMANAGER_ACTION Action;
        public IntPtr pbTicket;
        public uint cbTicket;
    }
}

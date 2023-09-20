// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;
using PFND3DKMT_TRIMNOTIFICATIONCALLBACK = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_UNREGISTERTRIMNOTIFICATION
    {
        public IntPtr Handle;
        public IntPtr Callback;
    }
}

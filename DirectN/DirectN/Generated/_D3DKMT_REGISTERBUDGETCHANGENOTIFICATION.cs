// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;
using PFND3DKMT_BUDGETCHANGENOTIFICATIONCALLBACK = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_REGISTERBUDGETCHANGENOTIFICATION
    {
        public uint hDevice;
        public IntPtr Callback;
        public IntPtr Context;
        public IntPtr Handle;
    }
}

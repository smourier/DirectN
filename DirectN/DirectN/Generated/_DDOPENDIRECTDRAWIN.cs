// generated from <Windows SDK Path>\um\ddkmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDOPENDIRECTDRAWIN
    {
        public IntPtr dwDirectDrawHandle;
        public IntPtr pfnDirectDrawClose;
        public IntPtr pContext;
    }
}

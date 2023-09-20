// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHALEXEBUFCB_CANCREATEEXEBUF = System.IntPtr;
using LPDDHALEXEBUFCB_CREATEEXEBUF = System.IntPtr;
using LPDDHALEXEBUFCB_DESTROYEXEBUF = System.IntPtr;
using LPDDHALEXEBUFCB_LOCKEXEBUF = System.IntPtr;
using LPDDHALEXEBUFCB_UNLOCKEXEBUF = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DDEXEBUFCALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr CanCreateExecuteBuffer;
        public IntPtr CreateExecuteBuffer;
        public IntPtr DestroyExecuteBuffer;
        public IntPtr LockExecuteBuffer;
        public IntPtr UnlockExecuteBuffer;
    }
}

// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_UPDATENATIVEFENCELOGS
    {
        public uint NumberOfQueues;
        public IntPtr hHWQueue;
        public _DXGKARG_UPDATENATIVEFENCELOGS_FLAGS Flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] Reserved;
    }
}

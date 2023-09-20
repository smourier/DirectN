// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SIGNALSYNCHRONIZATIONOBJECT
    {
        public IntPtr hContext;
        public uint ObjectCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public uint[] ObjectHandleArray;
        public _D3DDDICB_SIGNALFLAGS Flags;
    }
}

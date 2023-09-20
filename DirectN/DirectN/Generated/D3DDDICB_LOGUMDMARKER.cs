// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDICB_LOGUMDMARKER
    {
        public IntPtr hContext;
        public ulong APISequenceNumber;
        public int Index;
        public int StringIndex;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Info;
    }
}

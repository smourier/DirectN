// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(3817,9)
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

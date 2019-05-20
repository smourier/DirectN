// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(2909,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_QUERYADAPTERINFO
    {
        public _DXGK_QUERYADAPTERINFOTYPE Type;
        public IntPtr pInputData;
        public uint InputDataSize;
        public IntPtr pOutputData;
        public uint OutputDataSize;
        public _DXGK_QUERYADAPTERINFOFLAGS Flags;
        public IntPtr hKmdProcessHandle;
    }
}

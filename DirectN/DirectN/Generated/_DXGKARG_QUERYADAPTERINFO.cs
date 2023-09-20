// generated from <Windows SDK Path>\shared\d3dkmddi.h
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

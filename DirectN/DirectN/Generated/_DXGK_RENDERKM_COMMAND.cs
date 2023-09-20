// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_RENDERKM_COMMAND
    {
        public _DXGK_RENDERKM_OPERATION OpCode;
        public uint CommandSize;
        public _DXGK_RENDERKM_COMMAND__union_0 Command;
    }
}

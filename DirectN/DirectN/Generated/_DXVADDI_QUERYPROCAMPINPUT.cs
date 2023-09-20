// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVADDI_QUERYPROCAMPINPUT
    {
        public IntPtr pVideoProcGuid;
        public _DXVADDI_VIDEODESC VideoDesc;
        public _D3DDDIFORMAT RenderTargetFormat;
        public uint ProcAmpCap;
    }
}

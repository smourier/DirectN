// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_CREATEDECODEDEVICE
    {
        public IntPtr pGuid;
        public _DXVADDI_VIDEODESC VideoDesc;
        public IntPtr pConfig;
        public IntPtr hDecode;
    }
}

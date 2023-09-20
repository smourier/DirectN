// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_GETOVERLAYCOLORCONTROLS
    {
        public IntPtr hOverlay;
        public IntPtr hResource;
        public _D3DDDI_OVERLAYCOLORCONTROLS ColorControls;
    }
}

// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;
using PFND3DDDI_CLOSEADAPTER = System.IntPtr;
using PFND3DDDI_CREATEDEVICE = System.IntPtr;
using PFND3DDDI_GETCAPS = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_ADAPTERFUNCS
    {
        public IntPtr pfnGetCaps;
        public IntPtr pfnCreateDevice;
        public IntPtr pfnCloseAdapter;
    }
}

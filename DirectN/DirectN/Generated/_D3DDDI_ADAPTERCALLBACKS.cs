// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;
using PFND3DDDI_GETMULTISAMPLEMETHODLISTCB = System.IntPtr;
using PFND3DDDI_QUERYADAPTERINFOCB = System.IntPtr;
using PFND3DDDI_QUERYADAPTERINFOCB2 = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_ADAPTERCALLBACKS
    {
        public IntPtr pfnQueryAdapterInfoCb;
        public IntPtr pfnGetMultisampleMethodListCb;
        public IntPtr pfnQueryAdapterInfoCb2;
    }
}

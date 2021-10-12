// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(4632,9)
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

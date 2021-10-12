// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(4217,9)
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_SHADERCACHEGETVALUE_CB_0021 = System.IntPtr;
using PFND3D12DDI_SHADERCACHESTOREVALUE_CB_0021 = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SHADERCACHE_CALLBACKS_0021
    {
        public IntPtr pfnShaderCacheGetValueCb;
        public IntPtr pfnShaderCacheStoreValueCb;
    }
}

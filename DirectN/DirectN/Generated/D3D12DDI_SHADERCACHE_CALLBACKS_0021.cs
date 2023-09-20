// generated from <Windows SDK Path>\um\d3d12umddi.h
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

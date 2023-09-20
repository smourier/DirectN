// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e9eb5314-33aa-42b2-a718-d77f58b1f1c7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12SDKConfiguration
    {
        [PreserveSig]
        HRESULT SetSDKVersion(uint SDKVersion, /* _In_z_ */ [MarshalAs(UnmanagedType.LPStr)] string SDKPath);
    }
}

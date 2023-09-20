// generated from <Windows SDK Path>\um\d3d11sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("03916615-c644-418c-9bf4-75db5be63ca0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11RefDefaultTrackingOptions
    {
        [PreserveSig]
        HRESULT SetTrackingOptions(uint ResourceTypeFlags, uint Options);
    }
}

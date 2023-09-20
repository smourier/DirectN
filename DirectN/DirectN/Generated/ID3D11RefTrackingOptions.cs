// generated from <Windows SDK Path>\um\d3d11sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("193dacdf-0db2-4c05-a55c-ef06cac56fd9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11RefTrackingOptions
    {
        [PreserveSig]
        HRESULT SetTrackingOptions(uint uOptions);
    }
}

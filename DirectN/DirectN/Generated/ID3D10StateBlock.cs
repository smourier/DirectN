// generated from <Windows SDK Path>\um\d3d10effect.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0803425a-57f5-4dd6-9465-a87570834a08"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10StateBlock
    {
        [PreserveSig]
        HRESULT Capture();
        
        [PreserveSig]
        HRESULT Apply();
        
        [PreserveSig]
        HRESULT ReleaseAllDeviceObjects();
        
        [PreserveSig]
        HRESULT GetDevice(/* _Out_ THIS_ */ out ID3D10Device ppDevice);
    }
}

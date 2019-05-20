// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10effect.h(130,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0803425a-57f5-4dd6-9465-a87570834a08"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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

// generated from <Windows SDK Path>\um\d3d11sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1ef337e3-58e7-4f83-a692-db221f5ed47e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11SwitchToRef
    {
        [PreserveSig]
        bool SetUseRef(bool UseRef);
        
        [PreserveSig]
        bool GetUseRef();
    }
}

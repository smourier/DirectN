// generated from <Windows SDK Path>\um\d3d10sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9b7e4e02-342c-4106-a19f-4f2704f689f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10SwitchToRef
    {
        [PreserveSig]
        bool SetUseRef(bool UseRef);
        
        [PreserveSig]
        bool GetUseRef();
    }
}

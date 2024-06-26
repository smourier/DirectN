﻿// generated from <Windows SDK Path>\um\wmp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("82cba86b-9f04-474b-a365-d6dd1466e541"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPLibrarySharingServices
    {
        [PreserveSig]
        HRESULT isLibraryShared(/* [retval][out] */ out bool pvbShared);
        
        [PreserveSig]
        HRESULT isLibrarySharingEnabled(/* [retval][out] */ out bool pvbEnabled);
        
        [PreserveSig]
        HRESULT showLibrarySharing();
    }
}

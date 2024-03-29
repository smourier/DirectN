﻿// generated from <Windows SDK Path>\um\wmp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("39c2f8d5-1cf2-4d5e-ae09-d73492cf9eaa"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPLibraryServices
    {
        [PreserveSig]
        HRESULT getCountByType(/* [in] */ WMPLibraryType wmplt, /* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT getLibraryByType(/* [in] */ WMPLibraryType wmplt, /* [in] */ int lIndex, /* [retval][out] */ out IWMPLibrary ppIWMPLibrary);
    }
}

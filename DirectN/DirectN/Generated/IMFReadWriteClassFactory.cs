﻿// generated from <Windows SDK Path>\um\mfreadwrite.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e7fe2e12-661c-40da-92f9-4f002ab67627"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFReadWriteClassFactory
    {
        [PreserveSig]
        HRESULT CreateInstanceFromURL(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsid, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [annotation][in] _In_opt_ */ IMFAttributes pAttributes, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        
        [PreserveSig]
        HRESULT CreateInstanceFromObject(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsid, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkObject, /* [annotation][in] _In_opt_ */ IMFAttributes pAttributes, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
    }
}

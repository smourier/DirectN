﻿// generated from <Windows SDK Path>\um\mfobjects.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8feed468-6f7e-440d-869a-49bdd283ad0d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSampleOutputStream
    {
        [PreserveSig]
        HRESULT BeginWriteSample(/* [in] __RPC__in_opt */ IMFSample pSample, /* [in] __RPC__in_opt */ IMFAsyncCallback pCallback, /* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndWriteSample(/* [in] __RPC__in_opt */ IMFAsyncResult pResult);
        
        [PreserveSig]
        HRESULT Close();
    }
}

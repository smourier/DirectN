﻿// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d9d6549d-a193-4f24-b308-03123d9b7f8d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriterPostViewCallback : IWMStatusCallback
    {
        // IWMStatusCallback
        [PreserveSig]
        new HRESULT OnStatus(/* [in] */ WMT_STATUS Status, /* [in] */ HRESULT hr, /* [in] */ WMT_ATTR_DATATYPE dwType, /* [in] */ ref byte pValue, /* [in] */ IntPtr pvContext);
        
        // IWMWriterPostViewCallback
        [PreserveSig]
        HRESULT OnPostViewSample(/* [in] */ ushort wStreamNumber, /* [in] */ ulong cnsSampleTime, /* [in] */ ulong cnsSampleDuration, /* [in] */ uint dwFlags, /* [in] */ INSSBuffer pSample, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT AllocateForPostView(/* [in] */ ushort wStreamNum, /* [in] */ uint cbBuffer, /* [out] */ out INSSBuffer ppBuffer, /* [in] */ IntPtr pvContext);
    }
}

﻿// generated from <Windows SDK Path>\um\wmsbuffer.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e1cd3524-03d7-11d2-9eed-006097d2d7cf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface INSSBuffer
    {
        [PreserveSig]
        HRESULT GetLength(/* [out] */ out uint pdwLength);
        
        [PreserveSig]
        HRESULT SetLength(/* [in] */ uint dwLength);
        
        [PreserveSig]
        HRESULT GetMaxLength(/* [out] */ out uint pdwLength);
        
        [PreserveSig]
        HRESULT GetBuffer(/* [out] */ out IntPtr ppdwBuffer);
        
        [PreserveSig]
        HRESULT GetBufferAndLength(/* [out] */ out IntPtr ppdwBuffer, /* [out] */ out uint pdwLength);
    }
}

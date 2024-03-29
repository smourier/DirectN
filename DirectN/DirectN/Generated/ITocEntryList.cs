﻿// generated from <Windows SDK Path>\um\wmcodecdsp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3a8cccbd-0efd-43a3-b838-f38a552ba237"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ITocEntryList
    {
        [PreserveSig]
        HRESULT GetEntryCount(/* [out] */ out uint pdwEntryCount);
        
        [PreserveSig]
        HRESULT GetEntryByIndex(/* [in] */ uint dwEntryIndex, /* [out] */ out ITocEntry ppEntry);
        
        [PreserveSig]
        HRESULT AddEntry(/* [in] */ ITocEntry pEntry, /* [out] */ out uint pdwEntryIndex);
        
        [PreserveSig]
        HRESULT AddEntryByIndex(/* [in] */ uint dwEntryIndex, /* [in] */ ITocEntry pEntry);
        
        [PreserveSig]
        HRESULT RemoveEntryByIndex(/* [in] */ uint dwEntryIndex);
    }
}

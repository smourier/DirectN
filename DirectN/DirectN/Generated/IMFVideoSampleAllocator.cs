﻿// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("86cbc910-e533-4751-8e3b-f19b5b806a03"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoSampleAllocator
    {
        [PreserveSig]
        HRESULT SetDirectXManager(/* [unique][in] */ [MarshalAs(UnmanagedType.IUnknown)] object pManager);
        
        [PreserveSig]
        HRESULT UninitializeSampleAllocator();
        
        [PreserveSig]
        HRESULT InitializeSampleAllocator(/* [in] */ uint cRequestedFrames, /* [in] */ IMFMediaType pMediaType);
        
        [PreserveSig]
        HRESULT AllocateSample(/* [out] */ out IMFSample ppSample);
    }
}

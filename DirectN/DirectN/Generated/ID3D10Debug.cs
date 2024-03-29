﻿// generated from <Windows SDK Path>\um\d3d10sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9b7e4e01-342c-4106-a19f-4f2704f689f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10Debug
    {
        [PreserveSig]
        HRESULT SetFeatureMask(uint Mask);
        
        [PreserveSig]
        uint GetFeatureMask();
        
        [PreserveSig]
        HRESULT SetPresentPerRenderOpDelay(uint Milliseconds);
        
        [PreserveSig]
        uint GetPresentPerRenderOpDelay();
        
        [PreserveSig]
        HRESULT SetSwapChain(/* [annotation] _In_opt_ */ IDXGISwapChain pSwapChain);
        
        [PreserveSig]
        HRESULT GetSwapChain(/* [annotation] _Out_ */ out IDXGISwapChain ppSwapChain);
        
        [PreserveSig]
        HRESULT Validate();
    }
}

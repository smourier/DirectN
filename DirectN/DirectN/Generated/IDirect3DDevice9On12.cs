﻿// generated from <Windows SDK Path>\um\d3d9on12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e7fda234-b589-4049-940d-8878977531c8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice9On12
    {
        [PreserveSig]
        HRESULT GetD3D12Device([MarshalAs(UnmanagedType.LPStruct)] Guid riid, IntPtr ppvDevice);
        
        [PreserveSig]
        HRESULT UnwrapUnderlyingResource(IDirect3DResource9 pResource, ID3D12CommandQueue pCommandQueue, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, IntPtr ppvResource12);
        
        [PreserveSig]
        HRESULT ReturnUnderlyingResource(IDirect3DResource9 pResource, uint NumSync, ref ulong pSignalValues, out ID3D12Fence ppFences);
    }
}

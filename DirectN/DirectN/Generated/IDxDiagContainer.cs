﻿// generated from <Windows SDK Path>\um\dxdiag.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7d0f462f-4064-4862-bc7f-933e5058c10f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxDiagContainer
    {
        [PreserveSig]
        HRESULT GetNumberOfChildContainers(ref uint pdwCount);
        
        [PreserveSig]
        HRESULT EnumChildContainerNames(uint dwIndex, [MarshalAs(UnmanagedType.LPWStr)] string pwszContainer, uint cchContainer);
        
        [PreserveSig]
        HRESULT GetChildContainer([MarshalAs(UnmanagedType.LPWStr)] string pwszContainer, out IDxDiagContainer ppInstance);
        
        [PreserveSig]
        HRESULT GetNumberOfProps(ref uint pdwCount);
        
        [PreserveSig]
        HRESULT EnumPropNames(uint dwIndex, [MarshalAs(UnmanagedType.LPWStr)] string pwszPropName, uint cchPropName);
        
        [PreserveSig]
        HRESULT GetPropW([MarshalAs(UnmanagedType.LPWStr)] string pwszPropName, IntPtr pvarProp);
    }
}

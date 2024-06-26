﻿// generated from <Windows SDK Path>\um\devicetopology.h
using System;
using System.Runtime.InteropServices;
using VARTYPE = System.UInt16;

namespace DirectN
{
    [ComImport, Guid("3b22bcbf-2586-4af0-8583-205d391b807c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDeviceSpecificProperty
    {
        [PreserveSig]
        HRESULT GetType(/* [annotation][out] _Out_ */ out VARTYPE pVType);
        
        [PreserveSig]
        HRESULT GetValue(/* [annotation][out] _Out_ */ out IntPtr pvValue, /* [annotation][out][in] _Inout_ */ ref uint pcbValue);
        
        [PreserveSig]
        HRESULT SetValue(/* [annotation][in] _In_ */ IntPtr pvValue, /* [in] */ uint cbValue, /* optional(LPCGUID) */ IntPtr pguidEventContext);
        
        [PreserveSig]
        HRESULT Get4BRange(/* [annotation][out] _Out_ */ out int plMin, /* [annotation][out] _Out_ */ out int plMax, /* [annotation][out] _Out_ */ out int plStepping);
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\devicetopology.h(2092,5)
using System;
using System.Runtime.InteropServices;
using VARTYPE = System.UInt16;

namespace DirectN
{
    [Guid("3b22bcbf-2586-4af0-8583-205d391b807c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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

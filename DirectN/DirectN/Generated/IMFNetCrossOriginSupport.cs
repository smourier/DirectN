// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(18637,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bc2b7d44-a72d-49d5-8376-1480dee58b22"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFNetCrossOriginSupport
    {
        [PreserveSig]
        HRESULT GetCrossOriginPolicy(/* [annotation][out] _Out_ */ out _MF_CROSS_ORIGIN_POLICY pPolicy);
        
        [PreserveSig]
        HRESULT GetSourceOrigin(/* [annotation][out] _Out_ */ out IntPtr wszSourceOrigin);
        
        [PreserveSig]
        HRESULT IsSameOrigin(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string wszURL, /* [annotation][out] _Out_ */ out bool pfIsSameOrigin);
    }
}

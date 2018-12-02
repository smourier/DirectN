// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(13416,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7f00f10a-daed-41af-ab26-5fdfa4dfba3c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFOutputPolicy
    {
        [PreserveSig]
        HRESULT GenerateRequiredSchemas(/* [in] */ uint dwAttributes, /* [in] */ Guid guidOutputSubType, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid rgGuidProtectionSchemasSupported, /* [in] */ uint cProtectionSchemasSupported, /* [annotation][out] _Outptr_ */ out IntPtr ppRequiredProtectionSchemas);
        
        [PreserveSig]
        HRESULT GetOriginatorID(/* [annotation][out] _Out_ */ out Guid pguidOriginatorID);
        
        [PreserveSig]
        HRESULT GetMinimumGRLVersion(/* [annotation][out] _Out_ */ out uint pdwMinimumGRLVersion);
    }
}

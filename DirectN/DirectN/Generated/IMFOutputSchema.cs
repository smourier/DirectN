// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(13814,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7be0fc5b-abd9-44fb-a5c8-f50136e71599"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFOutputSchema
    {
        [PreserveSig]
        HRESULT GetSchemaType(/* [annotation][out] _Out_ */ out Guid pguidSchemaType);
        
        [PreserveSig]
        HRESULT GetConfigurationData(/* [annotation][out] _Out_ */ out uint pdwVal);
        
        [PreserveSig]
        HRESULT GetOriginatorID(/* [annotation][out] _Out_ */ out Guid pguidOriginatorID);
    }
}

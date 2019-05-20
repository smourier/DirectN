// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxcapi.h(300,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d2c21b26-8350-4bdc-976a-331ce6f4c54c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcContainerReflection
    {
        [PreserveSig]
        HRESULT Load(/* _In_ */ IDxcBlob pContainer);
        
        [PreserveSig]
        HRESULT GetPartCount(/* _Out_ */ out uint pResult);
        
        [PreserveSig]
        HRESULT GetPartKind(uint idx, /* _Out_ */ out uint pResult);
        
        [PreserveSig]
        HRESULT GetPartContent(uint idx, /* _COM_Outptr_ */ out IDxcBlob ppResult);
        
        [PreserveSig]
        HRESULT FindFirstPartKind(uint kind, /* _Out_ */ out uint pResult);
        
        [PreserveSig]
        HRESULT GetPartReflection(uint idx, [MarshalAs(UnmanagedType.LPStruct)] Guid iid, [MarshalAs(UnmanagedType.IUnknown)] object ppvObject);
    }
}

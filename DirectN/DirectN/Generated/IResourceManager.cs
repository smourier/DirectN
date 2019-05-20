// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(8207,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f744d97b-9988-44fb-abd6-5378844cfa8b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IResourceManager
    {
        [PreserveSig]
        HRESULT Register(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pName, /* [in] */ int cResource, /* [annotation][out] _Out_ */ out int plToken);
        
        [PreserveSig]
        HRESULT RegisterGroup(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pName, /* [in] */ int cResource, /* [annotation][size_is][in] _In_reads_(cResource) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] palTokens, /* [annotation][out] _Out_ */ out int plToken);
        
        [PreserveSig]
        HRESULT RequestResource(/* [in] */ int idResource, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pFocusObject, /* [in] */ IResourceConsumer pConsumer);
        
        [PreserveSig]
        HRESULT NotifyAcquire(/* [in] */ int idResource, /* [in] */ IResourceConsumer pConsumer, /* [in] */ HRESULT hr);
        
        [PreserveSig]
        HRESULT NotifyRelease(/* [in] */ int idResource, /* [in] */ IResourceConsumer pConsumer, /* [in] */ bool bStillWant);
        
        [PreserveSig]
        HRESULT CancelRequest(/* [in] */ int idResource, /* [in] */ IResourceConsumer pConsumer);
        
        [PreserveSig]
        HRESULT SetFocus(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pFocusObject);
        
        [PreserveSig]
        HRESULT ReleaseFocus(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pFocusObject);
    }
}

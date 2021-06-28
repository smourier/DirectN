// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mediaobj.h(939,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("65abea96-cf36-453f-af8a-705e98f16260"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDMOQualityControl
    {
        [PreserveSig]
        HRESULT SetNow(/* [in] */ long rtNow);
        
        [PreserveSig]
        HRESULT SetStatus(/* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT GetStatus(/* [annotation][out] _Out_ */ out uint pdwFlags);
    }
}

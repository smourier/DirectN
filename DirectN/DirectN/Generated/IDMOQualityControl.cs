// generated from <Windows SDK Path>\um\mediaobj.h
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

// generated from <Windows SDK Path>\um\mfobjects.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b25d03fb-d148-45ef-bfed-f778b7566c07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFDXGICrossAdapterBuffer
    {
        [PreserveSig]
        HRESULT GetResourceForDevice(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkDevice, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        
        [PreserveSig]
        HRESULT GetSubresourceIndexForDevice(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkDevice, /* [annotation][out] _Out_ */ out uint puSubresource);
        
        [PreserveSig]
        HRESULT GetUnknownForDevice(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkDevice, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        
        [PreserveSig]
        HRESULT SetUnknownForDevice(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkDevice, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkData);
    }
}

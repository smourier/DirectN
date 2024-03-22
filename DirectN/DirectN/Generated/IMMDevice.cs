// generated from <Windows SDK Path>\um\mmdeviceapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d666063f-1587-4e43-81f1-b948e807363f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMMDevice
    {
        [PreserveSig]
        HRESULT Activate(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* [annotation][in] _In_ */ uint dwClsCtx, /* [annotation][unique][in] _In_opt_ */ [In, Out] PROPVARIANT pActivationParams, /* [annotation][iid_is][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);
        
        [PreserveSig]
        HRESULT OpenPropertyStore(/* [annotation][in] _In_ */ uint stgmAccess, /* [annotation][out] _Out_ */ out IntPtr ppProperties);
        
        [PreserveSig]
        HRESULT GetId(/* [annotation][out] _Outptr_ */ out IntPtr ppstrId);
        
        [PreserveSig]
        HRESULT GetState(/* [annotation][out] _Out_ */ out uint pdwState);
    }
}

// generated from <Windows SDK Path>\um\mmdeviceapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3b0d0ea4-d0a9-4b0e-935b-09516746fac0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMMDeviceActivator
    {
        [PreserveSig]
        HRESULT Activate(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* [annotation][in] _In_ */ IMMDevice pDevice, /* [annotation][in] _In_opt_ */ [In, Out] PropVariant pActivationParams, /* [annotation][iid_is][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);
    }
}

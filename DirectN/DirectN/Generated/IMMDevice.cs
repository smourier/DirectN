// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mmdeviceapi.h(390,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d666063f-1587-4e43-81f1-b948e807363f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMMDevice
    {
        [PreserveSig]
        HRESULT Activate(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* [annotation][in] _In_ */ uint dwClsCtx, /* [annotation][unique][in] _In_opt_ */ [In, Out] PropVariant pActivationParams, /* [annotation][iid_is][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);
        
        [PreserveSig]
        HRESULT OpenPropertyStore(/* [annotation][in] _In_ */ uint stgmAccess, /* [annotation][out] _Out_ */ out IntPtr ppProperties);
        
        [PreserveSig]
        HRESULT GetId(/* [annotation][out] _Outptr_ */ out IntPtr ppstrId);
        
        [PreserveSig]
        HRESULT GetState(/* [annotation][out] _Out_ */ out uint pdwState);
    }
}

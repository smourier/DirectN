// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mmdeviceapi.h(1057,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("72a22d78-cde4-431d-b8cc-843a71199b6d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IActivateAudioInterfaceAsyncOperation
    {
        [PreserveSig]
        HRESULT GetActivateResult(/* [annotation][out] _Out_ */ out HRESULT activateResult, /* [annotation][out] _Outptr_result_maybenull_ */ [MarshalAs(UnmanagedType.IUnknown)] out object activatedInterface);
    }
}

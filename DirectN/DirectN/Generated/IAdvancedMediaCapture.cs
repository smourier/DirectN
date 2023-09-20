// generated from <Windows SDK Path>\um\mfmediacapture.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d0751585-d216-4344-b5bf-463b68f977bb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAdvancedMediaCapture
    {
        [PreserveSig]
        HRESULT GetAdvancedMediaCaptureSettings(/* [out] __RPC__deref_out_opt */ out IAdvancedMediaCaptureSettings value);
    }
}

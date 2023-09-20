// generated from <Windows SDK Path>\um\mfcaptureengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("aeda51c0-9025-4983-9012-de597b88b089"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCaptureEngineOnEventCallback
    {
        [PreserveSig]
        HRESULT OnEvent(/* [annotation][in] _In_ */ IMFMediaEvent pEvent);
    }
}

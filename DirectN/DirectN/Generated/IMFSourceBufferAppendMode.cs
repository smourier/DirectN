// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("19666fb4-babe-4c55-bc03-0a074da37e2a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceBufferAppendMode
    {
        [PreserveSig]
        MF_MSE_APPEND_MODE GetAppendMode();
        
        [PreserveSig]
        HRESULT SetAppendMode(/* [annotation][in] _In_ */ MF_MSE_APPEND_MODE mode);
    }
}

// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fee7c112-e776-42b5-9bbf-0048524e2bd5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineNotify
    {
        [PreserveSig]
        HRESULT EventNotify(/* [annotation][in] _In_ */ uint @event, /* [annotation][in] _In_ */ IntPtr param1, /* [annotation][in] _In_ */ uint param2);
    }
}

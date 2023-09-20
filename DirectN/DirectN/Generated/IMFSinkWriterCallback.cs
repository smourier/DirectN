// generated from <Windows SDK Path>\um\mfreadwrite.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("666f76de-33d2-41b9-a458-29ed0a972c58"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSinkWriterCallback
    {
        [PreserveSig]
        HRESULT OnFinalize(/* [annotation][in] _In_ */ HRESULT hrStatus);
        
        [PreserveSig]
        HRESULT OnMarker(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ IntPtr pvContext);
    }
}

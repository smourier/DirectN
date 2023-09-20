// generated from <Windows SDK Path>\um\mfreadwrite.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2456bd58-c067-4513-84fe-8d0c88ffdc61"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSinkWriterCallback2 : IMFSinkWriterCallback
    {
        // IMFSinkWriterCallback
        [PreserveSig]
        new HRESULT OnFinalize(/* [annotation][in] _In_ */ HRESULT hrStatus);
        
        [PreserveSig]
        new HRESULT OnMarker(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ IntPtr pvContext);
        
        // IMFSinkWriterCallback2
        [PreserveSig]
        HRESULT OnTransformChange();
        
        [PreserveSig]
        HRESULT OnStreamError(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ HRESULT hrStatus);
    }
}

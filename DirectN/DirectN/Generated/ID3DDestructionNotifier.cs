// generated from <Windows SDK Path>\um\d3dcommon.h
using System;
using System.Runtime.InteropServices;
using PFN_DESTRUCTION_CALLBACK = System.IntPtr;

namespace DirectN
{
    [ComImport, Guid("a06eb39a-50da-425b-8c31-4eecd6c270f3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3DDestructionNotifier
    {
        [PreserveSig]
        HRESULT RegisterDestructionCallback(/* [annotation] _In_ */ ref PFN_DESTRUCTION_CALLBACK callbackFn, /* [annotation] _In_ */ IntPtr pData, /* [annotation] _Out_ */ out uint pCallbackID);
        
        [PreserveSig]
        HRESULT UnregisterDestructionCallback(/* [annotation] _In_ */ uint callbackID);
    }
}

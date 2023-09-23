// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e8f2540d-558a-4449-8b64-4863467a9fe8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCameraControlNotify
    {
        [PreserveSig]
        void OnChange(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid controlSet, /* [annotation][in] _In_ */ uint id);
        
        [PreserveSig]
        void OnError(/* [annotation][in] _In_ */ HRESULT hrStatus);
    }
}

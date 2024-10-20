// generated from <Windows SDK Path>\um\audioenginebaseapo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f235855f-f06d-45b3-a63f-ee4b71509dc2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IApoAcousticEchoCancellation2 : IApoAcousticEchoCancellation
    {
        // IApoAcousticEchoCancellation
        
        // IApoAcousticEchoCancellation2
        [PreserveSig]
        HRESULT GetDesiredReferenceStreamProperties(/* [out] __RPC__out */ out APO_REFERENCE_STREAM_PROPERTIES pProperties);
    }
}

// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a1a3c64a-224f-4a81-9773-4f03a89d3c6c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionDeviceDebug
    {
        [PreserveSig]
        HRESULT EnableDebugCounters();
        
        [PreserveSig]
        HRESULT DisableDebugCounters();
    }
}

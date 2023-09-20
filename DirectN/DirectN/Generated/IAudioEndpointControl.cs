// generated from <Windows SDK Path>\um\audioengineendpoint.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c684b72a-6df4-4774-bdf9-76b77509b653"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEndpointControl
    {
        [PreserveSig]
        HRESULT Start();
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT Stop();
    }
}

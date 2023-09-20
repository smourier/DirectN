// generated from <Windows SDK Path>\um\audioendpoints.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("784cfd40-9f89-456e-a1a6-873b006a664e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEndpointFormatControl
    {
        [PreserveSig]
        HRESULT ResetToDefault(/* [annotation][in] _In_ */ uint ResetFlags);
    }
}

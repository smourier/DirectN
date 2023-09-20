// generated from <Windows SDK Path>\um\audioengineendpoint.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("076a6922-d802-4f83-baf6-409d9ca11bfe"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioLfxControl
    {
        [PreserveSig]
        HRESULT SetLocalEffectsState(/* [in] */ bool bEnabled);
        
        [PreserveSig]
        HRESULT GetLocalEffectsState(/* [out] */ out bool pbEnabled);
    }
}

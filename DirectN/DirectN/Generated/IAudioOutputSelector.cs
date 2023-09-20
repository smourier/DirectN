// generated from <Windows SDK Path>\um\devicetopology.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bb515f69-94a7-429e-8b9c-271b3f11a3ab"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioOutputSelector
    {
        [PreserveSig]
        HRESULT GetSelection(/* [annotation][out] _Out_ */ out uint pnIdSelected);
        
        [PreserveSig]
        HRESULT SetSelection(/* [annotation][in] _In_ */ uint nIdSelect, /* optional(LPCGUID) */ IntPtr pguidEventContext);
    }
}

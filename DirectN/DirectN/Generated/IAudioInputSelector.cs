// generated from <Windows SDK Path>\um\devicetopology.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4f03dc02-5e6e-4653-8f72-a030c123d598"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioInputSelector
    {
        [PreserveSig]
        HRESULT GetSelection(/* [annotation][out] _Out_ */ out uint pnIdSelected);
        
        [PreserveSig]
        HRESULT SetSelection(/* [annotation][in] _In_ */ uint nIdSelect, /* optional(LPCGUID) */ IntPtr pguidEventContext);
    }
}

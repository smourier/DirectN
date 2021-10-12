// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\devicetopology.h(1336,5)
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

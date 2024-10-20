// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c03ca9fe-fe90-4204-8078-82334cd177da"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSoundFXParamEq
    {
        [PreserveSig]
        HRESULT SetAllParameters(/* THIS_ _In_ */ ref _DSFXParamEq pcDsFxParamEq);
        
        [PreserveSig]
        HRESULT GetAllParameters(/* THIS_ _Out_ */ out _DSFXParamEq pDsFxParamEq);
    }
}

// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8bd28edf-50db-4e92-a2bd-445488d1ed42"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSoundFXEcho
    {
        [PreserveSig]
        HRESULT SetAllParameters(/* THIS_ _In_ */ ref _DSFXEcho pcDsFxEcho);
        
        [PreserveSig]
        HRESULT GetAllParameters(/* THIS_ _Out_ */ out _DSFXEcho pDsFxEcho);
    }
}

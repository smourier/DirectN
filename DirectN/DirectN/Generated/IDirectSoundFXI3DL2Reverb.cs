// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4b166a6a-0d66-43f3-80e3-ee6280dee1a4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSoundFXI3DL2Reverb
    {
        [PreserveSig]
        HRESULT SetAllParameters(/* THIS_ _In_ */ ref _DSFXI3DL2Reverb pcDsFxI3DL2Reverb);
        
        [PreserveSig]
        HRESULT GetAllParameters(/* THIS_ _Out_ */ out _DSFXI3DL2Reverb pDsFxI3DL2Reverb);
        
        [PreserveSig]
        HRESULT SetPreset(uint dwPreset);
        
        [PreserveSig]
        HRESULT GetPreset(/* THIS_ _Out_ */ out uint pdwPreset);
        
        [PreserveSig]
        HRESULT SetQuality(int lQuality);
        
        [PreserveSig]
        HRESULT GetQuality(/* THIS_ _Out_ */ out int plQuality);
    }
}

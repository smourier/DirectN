// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("880842e3-145f-43e6-a934-a71806e50547"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSoundFXChorus
    {
        [PreserveSig]
        HRESULT SetAllParameters(/* THIS_ _In_ */ ref _DSFXChorus pcDsFxChorus);
        
        [PreserveSig]
        HRESULT GetAllParameters(/* THIS_ _Out_ */ out _DSFXChorus pDsFxChorus);
    }
}

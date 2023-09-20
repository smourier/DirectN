// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4adfdba3-7ab0-4953-a62b-461e7ff3da1e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTranscodeProfile
    {
        [PreserveSig]
        HRESULT SetAudioAttributes(/* [annotation][in] _In_opt_ */ IMFAttributes pAttrs);
        
        [PreserveSig]
        HRESULT GetAudioAttributes(/* [annotation][out] _Outptr_result_maybenull_ */ out IMFAttributes ppAttrs);
        
        [PreserveSig]
        HRESULT SetVideoAttributes(/* [annotation][in] _In_opt_ */ IMFAttributes pAttrs);
        
        [PreserveSig]
        HRESULT GetVideoAttributes(/* [annotation][out] _Outptr_result_maybenull_ */ out IMFAttributes ppAttrs);
        
        [PreserveSig]
        HRESULT SetContainerAttributes(/* [annotation][in] _In_opt_ */ IMFAttributes pAttrs);
        
        [PreserveSig]
        HRESULT GetContainerAttributes(/* [annotation][out] _Outptr_result_maybenull_ */ out IMFAttributes ppAttrs);
    }
}

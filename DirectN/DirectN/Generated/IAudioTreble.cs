// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\devicetopology.h(1759,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0a717812-694e-4907-b74b-bafa5cfdca7b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioTreble : IPerChannelDbLevel
    {
        // IPerChannelDbLevel
        [PreserveSig]
        new HRESULT GetChannelCount(/* [annotation][out] _Out_ */ out uint pcChannels);
        
        [PreserveSig]
        new HRESULT GetLevelRange(/* [annotation][in] _In_ */ uint nChannel, /* [annotation][out] _Out_ */ out float pfMinLevelDB, /* [annotation][out] _Out_ */ out float pfMaxLevelDB, /* [annotation][out] _Out_ */ out float pfStepping);
        
        [PreserveSig]
        new HRESULT GetLevel(/* [annotation][in] _In_ */ uint nChannel, /* [annotation][out] _Out_ */ out float pfLevelDB);
        
        [PreserveSig]
        new HRESULT SetLevel(/* [annotation][in] _In_ */ uint nChannel, /* [annotation][in] _In_ */ float fLevelDB, /* optional(LPCGUID) */ IntPtr pguidEventContext);
        
        [PreserveSig]
        new HRESULT SetLevelUniform(/* [annotation][in] _In_ */ float fLevelDB, /* optional(LPCGUID) */ IntPtr pguidEventContext);
        
        [PreserveSig]
        new HRESULT SetLevelAllChannels(/* [annotation][size_is][in] _In_reads_(cChannels) */ float [] aLevelsDB, /* [annotation][in] _In_ */ uint cChannels, /* optional(LPCGUID) */ IntPtr pguidEventContext);
        
        // IAudioTreble
    }
}

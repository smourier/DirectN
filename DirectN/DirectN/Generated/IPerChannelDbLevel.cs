// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\devicetopology.h(698,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c2f8e001-f205-4bc9-99bc-c13b1e048ccb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPerChannelDbLevel
    {
        [PreserveSig]
        HRESULT GetChannelCount(/* [annotation][out] _Out_ */ out uint pcChannels);
        
        [PreserveSig]
        HRESULT GetLevelRange(/* [annotation][in] _In_ */ uint nChannel, /* [annotation][out] _Out_ */ out float pfMinLevelDB, /* [annotation][out] _Out_ */ out float pfMaxLevelDB, /* [annotation][out] _Out_ */ out float pfStepping);
        
        [PreserveSig]
        HRESULT GetLevel(/* [annotation][in] _In_ */ uint nChannel, /* [annotation][out] _Out_ */ out float pfLevelDB);
        
        [PreserveSig]
        HRESULT SetLevel(/* [annotation][in] _In_ */ uint nChannel, /* [annotation][in] _In_ */ float fLevelDB, /* optional(LPCGUID) */ IntPtr pguidEventContext);
        
        [PreserveSig]
        HRESULT SetLevelUniform(/* [annotation][in] _In_ */ float fLevelDB, /* optional(LPCGUID) */ IntPtr pguidEventContext);
        
        [PreserveSig]
        HRESULT SetLevelAllChannels(/* [annotation][size_is][in] _In_reads_(cChannels) */ float [] aLevelsDB, /* [annotation][in] _In_ */ uint cChannels, /* optional(LPCGUID) */ IntPtr pguidEventContext);
    }
}

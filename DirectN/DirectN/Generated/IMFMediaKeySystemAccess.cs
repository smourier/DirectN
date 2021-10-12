// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediaengine.h(9139,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("aec63fda-7a97-4944-b35c-6c6df8085cc3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaKeySystemAccess
    {
        [PreserveSig]
        HRESULT CreateMediaKeys(/* optional(IPropertyStore) */ IntPtr pCdmCustomConfig, /* [annotation] _COM_Outptr_ */ out IMFMediaKeys2 ppKeys);
        
        [PreserveSig]
        HRESULT get_SupportedConfiguration(/* [annotation] _COM_Outptr_ */ out IPropertyStore ppSupportedConfiguration);
        
        [PreserveSig]
        HRESULT get_KeySystem(/* [annotation] _Out_ */ out IntPtr pKeySystem);
    }
}

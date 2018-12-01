// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(1732,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("83a4ce40-7710-494b-a893-a472049af630"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEVRTrustedVideoPlugin
    {
        [PreserveSig]
        HRESULT IsInTrustedVideoMode(/* [out] */ out bool pYes);
        
        [PreserveSig]
        HRESULT CanConstrict(/* [out] */ out bool pYes);
        
        [PreserveSig]
        HRESULT SetConstriction(uint dwKPix);
        
        [PreserveSig]
        HRESULT DisableImageExport(bool bDisable);
    }
}

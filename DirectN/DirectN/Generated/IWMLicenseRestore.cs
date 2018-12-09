// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(15403,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c70b6334-a22e-4efb-a245-15e65a004a13"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMLicenseRestore
    {
        [PreserveSig]
        HRESULT RestoreLicenses(/* [in] */ uint dwFlags, /* [in] */ IWMStatusCallback pCallback);
        
        [PreserveSig]
        HRESULT CancelLicenseRestore();
    }
}

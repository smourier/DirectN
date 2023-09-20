// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c70b6334-a22e-4efb-a245-15e65a004a13"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMLicenseRestore
    {
        [PreserveSig]
        HRESULT RestoreLicenses(/* [in] */ uint dwFlags, /* [in] */ IWMStatusCallback pCallback);
        
        [PreserveSig]
        HRESULT CancelLicenseRestore();
    }
}

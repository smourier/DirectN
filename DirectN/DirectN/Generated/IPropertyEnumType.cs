// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(1392,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("11e1fbf9-2d56-4a6b-8db3-7cd193a471f2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyEnumType
    {
        [PreserveSig]
        HRESULT GetEnumType(/* [out] __RPC__out */ out PROPENUMTYPE penumtype);
        
        [PreserveSig]
        HRESULT GetValue(/* [out] __RPC__out */ PropVariant ppropvar);
        
        [PreserveSig]
        HRESULT GetRangeMinValue(/* [out] __RPC__out */ PropVariant ppropvarMin);
        
        [PreserveSig]
        HRESULT GetRangeSetValue(/* [out] __RPC__out */ PropVariant ppropvarSet);
        
        [PreserveSig]
        HRESULT GetDisplayText(/* optional(LPWSTR) */ out IntPtr ppszDisplay);
    }
}

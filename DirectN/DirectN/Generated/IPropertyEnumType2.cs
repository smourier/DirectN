// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(1512,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9b6e051c-5ddd-4321-9070-fe2acb55e794"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyEnumType2 : IPropertyEnumType
    {
        // IPropertyEnumType
        [PreserveSig]
        new HRESULT GetEnumType(/* [out] __RPC__out */ out PROPENUMTYPE penumtype);
        
        [PreserveSig]
        new HRESULT GetValue(/* [out] __RPC__out */ PropVariant ppropvar);
        
        [PreserveSig]
        new HRESULT GetRangeMinValue(/* [out] __RPC__out */ PropVariant ppropvarMin);
        
        [PreserveSig]
        new HRESULT GetRangeSetValue(/* [out] __RPC__out */ PropVariant ppropvarSet);
        
        [PreserveSig]
        new HRESULT GetDisplayText(/* optional(LPWSTR) */ out IntPtr ppszDisplay);
        
        // IPropertyEnumType2
        [PreserveSig]
        HRESULT GetImageReference(/* optional(LPWSTR) */ out IntPtr ppszImageRes);
    }
}

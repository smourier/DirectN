// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfobjects.h(4966,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("5bc8a76b-869a-46a3-9b03-fa218a66aebe"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCollection
    {
        [PreserveSig]
        HRESULT GetElementCount(/* [out] __RPC__out */ out uint pcElements);
        
        [PreserveSig]
        HRESULT GetElement(/* [in] */ uint dwElementIndex, /* [out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkElement);
        
        [PreserveSig]
        HRESULT AddElement(/* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkElement);
        
        [PreserveSig]
        HRESULT RemoveElement(/* [in] */ uint dwElementIndex, /* [out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkElement);
        
        [PreserveSig]
        HRESULT InsertElementAt(/* [in] */ uint dwIndex, /* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);
        
        [PreserveSig]
        HRESULT RemoveAllElements();
    }
}

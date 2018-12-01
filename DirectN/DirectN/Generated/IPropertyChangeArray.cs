// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(988,5)
using System;
using System.Runtime.InteropServices;
using PROPERTYKEY = DirectN._tagpropertykey;

namespace DirectN
{
    [Guid("380f5cad-1b5e-42f2-805d-637fd392d31e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyChangeArray
    {
        [PreserveSig]
        HRESULT GetCount(/* [out] __RPC__out */ out uint pcOperations);
        
        [PreserveSig]
        HRESULT GetAt(/* [in] */ uint iIndex, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT InsertAt(/* [in] */ uint iIndex, /* [in] __RPC__in_opt */ IPropertyChange ppropChange);
        
        [PreserveSig]
        HRESULT Append(/* [in] __RPC__in_opt */ IPropertyChange ppropChange);
        
        [PreserveSig]
        HRESULT AppendOrReplace(/* [in] __RPC__in_opt */ IPropertyChange ppropChange);
        
        [PreserveSig]
        HRESULT RemoveAt(/* [in] */ uint iIndex);
        
        [PreserveSig]
        HRESULT IsKeyInArray(/* [in] __RPC__in */ ref PROPERTYKEY key);
    }
}

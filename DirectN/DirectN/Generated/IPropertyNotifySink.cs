// generated from <Windows SDK Path>\um\ocidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9bfbbc02-eff1-101a-84ed-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyNotifySink
    {
        [PreserveSig]
        HRESULT OnChanged(/* [in] */ int dispID);
        
        [PreserveSig]
        HRESULT OnRequestEdit(/* [in] */ int dispID);
    }
}

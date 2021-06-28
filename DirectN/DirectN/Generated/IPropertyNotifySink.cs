// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ocidl.h(2204,5)
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

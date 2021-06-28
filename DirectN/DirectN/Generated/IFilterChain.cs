// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(18357,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dcfbdcf6-0dc2-45f5-9ab2-7c330ea09c29"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFilterChain
    {
        [PreserveSig]
        HRESULT StartChain(/* [in] */ IBaseFilter pStartFilter, /* [in] */ IBaseFilter pEndFilter);
        
        [PreserveSig]
        HRESULT PauseChain(/* [in] */ IBaseFilter pStartFilter, /* [in] */ IBaseFilter pEndFilter);
        
        [PreserveSig]
        HRESULT StopChain(/* [in] */ IBaseFilter pStartFilter, /* [in] */ IBaseFilter pEndFilter);
        
        [PreserveSig]
        HRESULT RemoveChain(/* [in] */ IBaseFilter pStartFilter, /* [in] */ IBaseFilter pEndFilter);
    }
}

// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a868ad-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IResourceConsumer
    {
        [PreserveSig]
        HRESULT AcquireResource(/* [in] */ int idResource);
        
        [PreserveSig]
        HRESULT ReleaseResource(/* [in] */ int idResource);
    }
}

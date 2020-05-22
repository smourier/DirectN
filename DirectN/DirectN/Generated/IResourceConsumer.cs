// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(8117,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56a868ad-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IResourceConsumer
    {
        [PreserveSig]
        HRESULT AcquireResource(/* [in] */ int idResource);
        
        [PreserveSig]
        HRESULT ReleaseResource(/* [in] */ int idResource);
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(18261,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c0dff467-d499-4986-972b-e1d9090fa941"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMDecoderCaps
    {
        [PreserveSig]
        HRESULT GetDecoderCaps(/* [in] */ uint dwCapIndex, /* [annotation][out] _Out_ */ out uint lpdwCap);
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(17332,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c0dff467-d499-4986-972b-e1d9090fa941"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMDecoderCaps
    {
        [PreserveSig]
        HRESULT GetDecoderCaps(/* [in] */ uint dwCapIndex, /* [annotation][out] _Out_ */ out uint lpdwCap);
    }
}

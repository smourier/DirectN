// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wincodec.h(7927,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("5cacdb4c-407e-41b3-b936-d0f010cd6732"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICDdsEncoder
    {
        [PreserveSig]
        HRESULT SetParameters(/* [in] __RPC__in */ ref WICDdsParameters pParameters);
        
        [PreserveSig]
        HRESULT GetParameters(/* [out] __RPC__out */ out WICDdsParameters pParameters);
        
        [PreserveSig]
        HRESULT CreateNewFrame(/* [out] __RPC__deref_out_opt */ out IWICBitmapFrameEncode ppIFrameEncode, /* [optional][out] __RPC__out */ out uint pArrayIndex, /* [optional][out] __RPC__out */ out uint pMipLevel, /* [optional][out] __RPC__out */ out uint pSliceIndex);
    }
}

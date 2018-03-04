using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("5cacdb4c-407e-41b3-b936-d0f010cd6732"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICDdsEncoder
    {
        [PreserveSig]
        HRESULT SetParameters(ref WICDdsParameters pParameters);

        [PreserveSig]
        HRESULT GetParameters(ref WICDdsParameters pParameters);

        [PreserveSig]
        HRESULT CreateNewFrame(out IWICBitmapFrameEncode ppIFrameEncode, out int pArrayIndex, out int pMipLevel, out int pSliceIndex);
    }
}

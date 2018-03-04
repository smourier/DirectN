using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("409cd537-8532-40cb-9774-e2feb2df4e9c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICDdsDecoder
    {
        [PreserveSig]
        HRESULT GetParameters(out WICDdsParameters pParameters);

        [PreserveSig]
        HRESULT GetFrame(int arrayIndex, int mipLevel, int sliceIndex, out IWICBitmapFrameDecode ppIBitmapFrame);
    }
}

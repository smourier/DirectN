using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("B84E2C09-78C9-4AC4-8BD3-524AE1663A2F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICFastMetadataEncoder
    {
        [PreserveSig]
        HRESULT Commit();

        [PreserveSig]
        HRESULT GetMetadataQueryWriter(out IWICMetadataQueryWriter ppIMetadataQueryWriter);
    }
}

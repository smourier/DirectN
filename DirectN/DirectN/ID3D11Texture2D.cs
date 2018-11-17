using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6f15aaf2-d208-4e89-9ab4-489535d34f9c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11Texture2D : ID3D11Resource
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(out ID3D11Device ppDevice);

        [PreserveSig]
        new HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid guid, out int pDataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid guid, int DataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT SetPrivateDataInterface([MarshalAs(UnmanagedType.LPStruct)] Guid guid, [MarshalAs(UnmanagedType.IUnknown)] object pData);

        // ID3D11Resource
        [PreserveSig]
        new void GetType(out D3D11_RESOURCE_DIMENSION pResourceDimension);

        [PreserveSig]
        new void SetEvictionPriority(int EvictionPriority);

        [PreserveSig]
        new int GetEvictionPriority();

        // ID3D11Texture2D
        [PreserveSig]
        void GetDesc(out D3D11_TEXTURE2D_DESC pDesc);
    }
}

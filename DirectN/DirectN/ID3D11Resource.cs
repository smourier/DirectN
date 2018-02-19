using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("dc8e63f3-d12b-4952-b47b-5e45026a862d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11Resource : ID3D11DeviceChild
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
        void GetType(out D3D11_RESOURCE_DIMENSION pResourceDimension);
        
        [PreserveSig]
        void SetEvictionPriority(int EvictionPriority);

        [PreserveSig]
        int GetEvictionPriority();
    }
}

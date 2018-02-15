using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4b35d0cd-1e15-4258-9c98-1b1333f6dd3b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11Asynchronous
    {
        // ID3D11DeviceChild
        [PreserveSig]
        void GetDevice(out ID3D11Device ppDevice);

        [PreserveSig]
        HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid guid, out int pDataSize, IntPtr pData);

        [PreserveSig]
        HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid guid, int DataSize, IntPtr pData);

        [PreserveSig]
        HRESULT SetPrivateDataInterface([MarshalAs(UnmanagedType.LPStruct)] Guid guid, [MarshalAs(UnmanagedType.IUnknown)] object pData);

        // ID3D11Asynchronous
        [PreserveSig]
        int GetDataSize();
    }
}

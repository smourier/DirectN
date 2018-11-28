using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b0e06fe0-8192-4e1a-b1ca-36d7414710b2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11ShaderResourceView : ID3D11View
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

        // ID3D11View
        [PreserveSig]
        new void GetResource(out ID3D11Resource ppResource);

        // ID3D11ShaderResourceView
        [PreserveSig]
        void GetDesc(out D3D11_SHADER_RESOURCE_VIEW_DESC pDesc);
    }

    [Guid("91308b87-9040-411d-8c67-c39253ce3802"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11ShaderResourceView1 : ID3D11ShaderResourceView
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

        // ID3D11View
        [PreserveSig]
        new void GetResource(out ID3D11Resource ppResource);

        // ID3D11ShaderResourceView
        [PreserveSig]
        new void GetDesc(out D3D11_SHADER_RESOURCE_VIEW_DESC pDesc);

        // ID3D11ShaderResourceView1
        [PreserveSig]
        void GetDesc1(out D3D11_SHADER_RESOURCE_VIEW_DESC1 pDesc1);
    }
}

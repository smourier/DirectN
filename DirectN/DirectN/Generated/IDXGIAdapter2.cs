using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    // dxgi1_2.h
    [Guid("0AA1AE0A-FA0E-4B84-8644-E05FF8E5ACB5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIAdapter2 : IDXGIAdapter1
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, int DataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT SetPrivateDataInterface([MarshalAs(UnmanagedType.LPStruct)] Guid Name, [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

        [PreserveSig]
        new HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, out int pDataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT GetParent([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);

        // IDXGIAdapter
        [PreserveSig]
        new HRESULT EnumOutputs(int nOutput, out IDXGIOutput ppOutput);

        [PreserveSig]
        new HRESULT GetDesc(out DXGI_ADAPTER_DESC pDesc);

        [PreserveSig]
        new HRESULT CheckInterfaceSupport([MarshalAs(UnmanagedType.LPStruct)] Guid InterfaceName, out long pUMDVersion);

        // IDXGIAdapter1
        [PreserveSig]
        new HRESULT GetDesc1(out DXGI_ADAPTER_DESC1 pDesc);

        // IDXGIAdapter2
        [PreserveSig]
        HRESULT GetDesc2(out DXGI_ADAPTER_DESC2 pDesc);
    }
}

using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIAdapter : IDXGIObject
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
        HRESULT EnumOutputs(int nOutput, out IDXGIOutput ppOutput);
        
        [PreserveSig]
        HRESULT GetDesc(out DXGI_ADAPTER_DESC pDesc);
        
        [PreserveSig]
        HRESULT CheckInterfaceSupport([MarshalAs(UnmanagedType.LPStruct)] Guid InterfaceName, out long pUMDVersion);
    }

    [Guid("29038f61-3839-4626-91fd-086879011a05"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIAdapter1 : IDXGIAdapter
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
        HRESULT GetDesc1(out DXGI_ADAPTER_DESC1 pDesc);
    }

    public interface IDXGIAdapter2 : IDXGIAdapter1
    {
    }

    public interface IDXGIAdapter3 : IDXGIAdapter2
    {
    }

    public interface IDXGIAdapter4 : IDXGIAdapter3
    {
    }
}

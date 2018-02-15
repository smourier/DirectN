using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("770aae78-f26f-4dba-a829-253c83d1b387"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIFactory1 : IDXGIFactory
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

        // IDXGIFactory
        [PreserveSig]
        new HRESULT EnumAdapters(int Adapter, out IDXGIAdapter ppAdapter);

        [PreserveSig]
        new HRESULT MakeWindowAssociation(IntPtr WindowHandle, DXGI_MWA_FLAGS Flags);

        [PreserveSig]
        new HRESULT GetWindowAssociation(out IntPtr pWindowHandle);

        [PreserveSig]
        new HRESULT CreateSwapChain([MarshalAs(UnmanagedType.IUnknown)] object pDevice, ref DXGI_SWAP_CHAIN_DESC pDesc, out IDXGISwapChain ppSwapChain);

        [PreserveSig]
        new HRESULT CreateSoftwareAdapter(IntPtr Module, out IDXGIAdapter ppAdapter);

        // IDXGIFactory1
        [PreserveSig]
        HRESULT EnumAdapters1(int Adapter, out IDXGIAdapter1 ppAdapter);

        [PreserveSig]
        bool IsCurrent();
    }
}

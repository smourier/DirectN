using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIFactory
    {
        // IDXGIObject
        [PreserveSig]
        int SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, int DataSize, IntPtr pData);

        [PreserveSig]
        int SetPrivateDataInterface([MarshalAs(UnmanagedType.LPStruct)] Guid Name, [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

        [PreserveSig]
        int GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, out int pDataSize, IntPtr pData);

        [PreserveSig]
        int GetParent([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);

        // IDXGIFactory
        [PreserveSig]
        int EnumAdapters(int Adapter, out IDXGIAdapter ppAdapter);

        [PreserveSig]
        int MakeWindowAssociation(IntPtr WindowHandle, DXGI_MWA_FLAGS Flags);

        [PreserveSig]
        int GetWindowAssociation(out IntPtr pWindowHandle);

        [PreserveSig]
        int CreateSwapChain([MarshalAs(UnmanagedType.IUnknown)] object pDevice, ref DXGI_SWAP_CHAIN_DESC pDesc, out IDXGISwapChain ppSwapChain);

        [PreserveSig]
        int CreateSoftwareAdapter(IntPtr Module, out IDXGIAdapter ppAdapter);
    }
}

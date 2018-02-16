using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISwapChain
    {
        // IDXGIDeviceSubObject
    }

    [Guid("790a45f7-0d42-4876-983a-0a55cfe6f4aa"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISwapChain1 : IDXGISwapChain
    {
    }

    public interface IDXGISwapChain2 : IDXGISwapChain1
    {
    }

    public interface IDXGISwapChain3 : IDXGISwapChain2
    {
    }

    // dxgi1_5.h
    [Guid("3D585D5A-BD4A-489E-B1F4-3DBCB6452FFB"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISwapChain4 : IDXGISwapChain3
    {
        [PreserveSig]
        HRESULT SetHDRMetaData(DXGI_HDR_METADATA_TYPE Type, int Size, IntPtr pMetaData);
    }
}

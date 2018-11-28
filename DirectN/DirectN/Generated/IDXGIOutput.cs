using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutput : IDXGIObject
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

        // IDXGIOutput
        [PreserveSig]
        HRESULT GetDesc(out DXGI_OUTPUT_DESC pDesc);

        [PreserveSig]
        HRESULT GetDisplayModeList(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
            DXGI_MODE_DESC[] pDesc);

        [PreserveSig]
        HRESULT FindClosestMatchingMode(ref DXGI_MODE_DESC pModeToMatch, out DXGI_MODE_DESC pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        HRESULT WaitForVBlank();

        [PreserveSig]
        HRESULT TakeOwnership([MarshalAs(UnmanagedType.IUnknown)] object pDevice, bool Exclusive);

        [PreserveSig]
        void ReleaseOwnership();

        [PreserveSig]
        HRESULT GetGammaControlCapabilities(out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);

        [PreserveSig]
        HRESULT SetGammaControl(ref DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        HRESULT GetGammaControl(out DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        HRESULT SetDisplaySurface(IDXGISurface pScanoutSurface);

        [PreserveSig]
        HRESULT GetDisplaySurfaceData(IDXGISurface pDestination);

        [PreserveSig]
        HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);
    }
}

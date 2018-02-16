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
            [In, Out] DXGI_MODE_DESC[] pDesc);

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

    // dxgi1_2.h
    [Guid("00cddea8-939b-4b83-a340-a685226666cc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutput1 : IDXGIOutput
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
        new HRESULT GetDesc(out DXGI_OUTPUT_DESC pDesc);

        [PreserveSig]
        new HRESULT GetDisplayModeList(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out] DXGI_MODE_DESC[] pDesc);

        [PreserveSig]
        new HRESULT FindClosestMatchingMode(ref DXGI_MODE_DESC pModeToMatch, out DXGI_MODE_DESC pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        new HRESULT WaitForVBlank();

        [PreserveSig]
        new HRESULT TakeOwnership([MarshalAs(UnmanagedType.IUnknown)] object pDevice, bool Exclusive);

        [PreserveSig]
        new void ReleaseOwnership();

        [PreserveSig]
        new HRESULT GetGammaControlCapabilities(out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);

        [PreserveSig]
        new HRESULT SetGammaControl(ref DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT GetGammaControl(out DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT SetDisplaySurface(IDXGISurface pScanoutSurface);

        [PreserveSig]
        new HRESULT GetDisplaySurfaceData(IDXGISurface pDestination);

        [PreserveSig]
        new HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);

        // IDXGIOutput1
        [PreserveSig]
        HRESULT GetDisplayModeList1(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out] DXGI_MODE_DESC1[] pDesc);

        [PreserveSig]
        HRESULT FindClosestMatchingMode1(ref DXGI_MODE_DESC1 pModeToMatch, out DXGI_MODE_DESC1 pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        HRESULT GetDisplaySurfaceData1(IDXGIResource pDestination);

        [PreserveSig]
        HRESULT DuplicateOutput([MarshalAs(UnmanagedType.IUnknown)] object pDevice, out IDXGIOutputDuplication ppOutputDuplication);
    }

    // dxgi1_3.h
    [Guid("595e39d1-2724-4663-99b1-da969de28364"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutput2 : IDXGIOutput1
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
        new HRESULT GetDesc(out DXGI_OUTPUT_DESC pDesc);

        [PreserveSig]
        new HRESULT GetDisplayModeList(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out] DXGI_MODE_DESC[] pDesc);

        [PreserveSig]
        new HRESULT FindClosestMatchingMode(ref DXGI_MODE_DESC pModeToMatch, out DXGI_MODE_DESC pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        new HRESULT WaitForVBlank();

        [PreserveSig]
        new HRESULT TakeOwnership([MarshalAs(UnmanagedType.IUnknown)] object pDevice, bool Exclusive);

        [PreserveSig]
        new void ReleaseOwnership();

        [PreserveSig]
        new HRESULT GetGammaControlCapabilities(out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);

        [PreserveSig]
        new HRESULT SetGammaControl(ref DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT GetGammaControl(out DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT SetDisplaySurface(IDXGISurface pScanoutSurface);

        [PreserveSig]
        new HRESULT GetDisplaySurfaceData(IDXGISurface pDestination);

        [PreserveSig]
        new HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);

        // IDXGIOutput1
        [PreserveSig]
        new HRESULT GetDisplayModeList1(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out] DXGI_MODE_DESC1[] pDesc);

        [PreserveSig]
        new HRESULT FindClosestMatchingMode1(ref DXGI_MODE_DESC1 pModeToMatch, out DXGI_MODE_DESC1 pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        new HRESULT GetDisplaySurfaceData1(IDXGIResource pDestination);

        [PreserveSig]
        new HRESULT DuplicateOutput([MarshalAs(UnmanagedType.IUnknown)] object pDevice, out IDXGIOutputDuplication ppOutputDuplication);

        // IDXGIOutput2
        [PreserveSig]
        bool SupportsOverlays();
    }

    // dxgi1_3.h
    [Guid("8a6bb301-7e7e-41F4-a8e0-5b32f7f99b18"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutput3 : IDXGIOutput2
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
        new HRESULT GetDesc(out DXGI_OUTPUT_DESC pDesc);

        [PreserveSig]
        new HRESULT GetDisplayModeList(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out] DXGI_MODE_DESC[] pDesc);

        [PreserveSig]
        new HRESULT FindClosestMatchingMode(ref DXGI_MODE_DESC pModeToMatch, out DXGI_MODE_DESC pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        new HRESULT WaitForVBlank();

        [PreserveSig]
        new HRESULT TakeOwnership([MarshalAs(UnmanagedType.IUnknown)] object pDevice, bool Exclusive);

        [PreserveSig]
        new void ReleaseOwnership();

        [PreserveSig]
        new HRESULT GetGammaControlCapabilities(out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);

        [PreserveSig]
        new HRESULT SetGammaControl(ref DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT GetGammaControl(out DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT SetDisplaySurface(IDXGISurface pScanoutSurface);

        [PreserveSig]
        new HRESULT GetDisplaySurfaceData(IDXGISurface pDestination);

        [PreserveSig]
        new HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);

        // IDXGIOutput1
        [PreserveSig]
        new HRESULT GetDisplayModeList1(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out] DXGI_MODE_DESC1[] pDesc);

        [PreserveSig]
        new HRESULT FindClosestMatchingMode1(ref DXGI_MODE_DESC1 pModeToMatch, out DXGI_MODE_DESC1 pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        new HRESULT GetDisplaySurfaceData1(IDXGIResource pDestination);

        [PreserveSig]
        new HRESULT DuplicateOutput([MarshalAs(UnmanagedType.IUnknown)] object pDevice, out IDXGIOutputDuplication ppOutputDuplication);

        // IDXGIOutput2
        [PreserveSig]
        new bool SupportsOverlays();

        // IDXGIOutput3
        [PreserveSig]
        HRESULT CheckOverlaySupport(DXGI_FORMAT EnumFormat, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice, out DXGI_OVERLAY_SUPPORT_FLAG pFlags);
    }

    // dxgi1_4.h
    [Guid("dc7dca35-2196-414d-9F53-617884032a60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutput4 : IDXGIOutput3
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
        new HRESULT GetDesc(out DXGI_OUTPUT_DESC pDesc);

        [PreserveSig]
        new HRESULT GetDisplayModeList(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out] DXGI_MODE_DESC[] pDesc);

        [PreserveSig]
        new HRESULT FindClosestMatchingMode(ref DXGI_MODE_DESC pModeToMatch, out DXGI_MODE_DESC pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        new HRESULT WaitForVBlank();

        [PreserveSig]
        new HRESULT TakeOwnership([MarshalAs(UnmanagedType.IUnknown)] object pDevice, bool Exclusive);

        [PreserveSig]
        new void ReleaseOwnership();

        [PreserveSig]
        new HRESULT GetGammaControlCapabilities(out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);

        [PreserveSig]
        new HRESULT SetGammaControl(ref DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT GetGammaControl(out DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT SetDisplaySurface(IDXGISurface pScanoutSurface);

        [PreserveSig]
        new HRESULT GetDisplaySurfaceData(IDXGISurface pDestination);

        [PreserveSig]
        new HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);

        // IDXGIOutput1
        [PreserveSig]
        new HRESULT GetDisplayModeList1(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out] DXGI_MODE_DESC1[] pDesc);

        [PreserveSig]
        new HRESULT FindClosestMatchingMode1(ref DXGI_MODE_DESC1 pModeToMatch, out DXGI_MODE_DESC1 pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        new HRESULT GetDisplaySurfaceData1(IDXGIResource pDestination);

        [PreserveSig]
        new HRESULT DuplicateOutput([MarshalAs(UnmanagedType.IUnknown)] object pDevice, out IDXGIOutputDuplication ppOutputDuplication);

        // IDXGIOutput2
        [PreserveSig]
        new bool SupportsOverlays();

        // IDXGIOutput3
        [PreserveSig]
        new HRESULT CheckOverlaySupport(DXGI_FORMAT EnumFormat, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice, out DXGI_OVERLAY_SUPPORT_FLAG pFlags);

        // IDXGIOutput4
        [PreserveSig]
        HRESULT CheckOverlayColorSpaceSupport(DXGI_FORMAT Format, DXGI_COLOR_SPACE_TYPE ColorSpace, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice, out DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG pFlags);
    }

    // dxgi1_5.h
    [Guid("80A07424-AB52-42EB-833C-0C42FD282D98"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutput5 : IDXGIOutput4
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
        new HRESULT GetDesc(out DXGI_OUTPUT_DESC pDesc);

        [PreserveSig]
        new HRESULT GetDisplayModeList(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out] DXGI_MODE_DESC[] pDesc);

        [PreserveSig]
        new HRESULT FindClosestMatchingMode(ref DXGI_MODE_DESC pModeToMatch, out DXGI_MODE_DESC pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        new HRESULT WaitForVBlank();

        [PreserveSig]
        new HRESULT TakeOwnership([MarshalAs(UnmanagedType.IUnknown)] object pDevice, bool Exclusive);

        [PreserveSig]
        new void ReleaseOwnership();

        [PreserveSig]
        new HRESULT GetGammaControlCapabilities(out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);

        [PreserveSig]
        new HRESULT SetGammaControl(ref DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT GetGammaControl(out DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT SetDisplaySurface(IDXGISurface pScanoutSurface);

        [PreserveSig]
        new HRESULT GetDisplaySurfaceData(IDXGISurface pDestination);

        [PreserveSig]
        new HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);

        // IDXGIOutput1
        [PreserveSig]
        new HRESULT GetDisplayModeList1(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out] DXGI_MODE_DESC1[] pDesc);

        [PreserveSig]
        new HRESULT FindClosestMatchingMode1(ref DXGI_MODE_DESC1 pModeToMatch, out DXGI_MODE_DESC1 pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        new HRESULT GetDisplaySurfaceData1(IDXGIResource pDestination);

        [PreserveSig]
        new HRESULT DuplicateOutput([MarshalAs(UnmanagedType.IUnknown)] object pDevice, out IDXGIOutputDuplication ppOutputDuplication);

        // IDXGIOutput2
        [PreserveSig]
        new bool SupportsOverlays();

        // IDXGIOutput3
        [PreserveSig]
        new HRESULT CheckOverlaySupport(DXGI_FORMAT EnumFormat, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice, out DXGI_OVERLAY_SUPPORT_FLAG pFlags);

        // IDXGIOutput4
        [PreserveSig]
        new HRESULT CheckOverlayColorSpaceSupport(DXGI_FORMAT Format, DXGI_COLOR_SPACE_TYPE ColorSpace, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice, out DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG pFlags);

        // IDXGIOutput5
        [PreserveSig]
        HRESULT DuplicateOutput1(
            [MarshalAs(UnmanagedType.IUnknown)] object pDevice,
            int Flags,
            int SupportedFormatsCount,
            DXGI_FORMAT[] pSupportedFormats,
            out IDXGIOutputDuplication ppOutputDuplication);
    }

    // dxgi1_6.h
    [Guid("068346e8-aaec-4b84-add7-137f513f77a1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutput6 : IDXGIOutput5
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
        new HRESULT GetDesc(out DXGI_OUTPUT_DESC pDesc);

        [PreserveSig]
        new HRESULT GetDisplayModeList(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out] DXGI_MODE_DESC[] pDesc);

        [PreserveSig]
        new HRESULT FindClosestMatchingMode(ref DXGI_MODE_DESC pModeToMatch, out DXGI_MODE_DESC pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        new HRESULT WaitForVBlank();

        [PreserveSig]
        new HRESULT TakeOwnership([MarshalAs(UnmanagedType.IUnknown)] object pDevice, bool Exclusive);

        [PreserveSig]
        new void ReleaseOwnership();

        [PreserveSig]
        new HRESULT GetGammaControlCapabilities(out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);

        [PreserveSig]
        new HRESULT SetGammaControl(ref DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT GetGammaControl(out DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT SetDisplaySurface(IDXGISurface pScanoutSurface);

        [PreserveSig]
        new HRESULT GetDisplaySurfaceData(IDXGISurface pDestination);

        [PreserveSig]
        new HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);

        // IDXGIOutput1
        [PreserveSig]
        new HRESULT GetDisplayModeList1(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out] DXGI_MODE_DESC1[] pDesc);

        [PreserveSig]
        new HRESULT FindClosestMatchingMode1(ref DXGI_MODE_DESC1 pModeToMatch, out DXGI_MODE_DESC1 pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        new HRESULT GetDisplaySurfaceData1(IDXGIResource pDestination);

        [PreserveSig]
        new HRESULT DuplicateOutput([MarshalAs(UnmanagedType.IUnknown)] object pDevice, out IDXGIOutputDuplication ppOutputDuplication);

        // IDXGIOutput2
        [PreserveSig]
        new bool SupportsOverlays();

        // IDXGIOutput3
        [PreserveSig]
        new HRESULT CheckOverlaySupport(DXGI_FORMAT EnumFormat, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice, out DXGI_OVERLAY_SUPPORT_FLAG pFlags);

        // IDXGIOutput4
        [PreserveSig]
        new HRESULT CheckOverlayColorSpaceSupport(DXGI_FORMAT Format, DXGI_COLOR_SPACE_TYPE ColorSpace, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice, out DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG pFlags);

        // IDXGIOutput5
        [PreserveSig]
        new HRESULT DuplicateOutput1(
            [MarshalAs(UnmanagedType.IUnknown)] object pDevice,
            int Flags,
            int SupportedFormatsCount,
            DXGI_FORMAT[] pSupportedFormats,
            out IDXGIOutputDuplication ppOutputDuplication);

        // IDXGIOutput6
        [PreserveSig]
        HRESULT GetDesc1(out DXGI_OUTPUT_DESC1 pDesc);

        [PreserveSig]
        HRESULT CheckHardwareCompositionSupport(out DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS pFlags);
    }
}

using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutput
    {
        // IDXGIObject
    }

    public interface IDXGIOutput1 : IDXGIOutput
    {
    }

    public interface IDXGIOutput2 : IDXGIOutput1
    {
    }

    public interface IDXGIOutput3 : IDXGIOutput2
    {
    }

    public interface IDXGIOutput4 : IDXGIOutput3
    {
    }

    // dxgi1_5.h
    [Guid("80A07424-AB52-42EB-833C-0C42FD282D98"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutput5 : IDXGIOutput4
    {
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
        // IDXGIOutput5
        [PreserveSig]
        new HRESULT DuplicateOutput1(
            [MarshalAs(UnmanagedType.IUnknown)] object pDevice,
            int Flags,
            int SupportedFormatsCount,
            DXGI_FORMAT[] pSupportedFormats,
            out IDXGIOutputDuplication ppOutputDuplication);

        [PreserveSig]
        HRESULT GetDesc1(out DXGI_OUTPUT_DESC1 pDesc);
        
        [PreserveSig]
        HRESULT CheckHardwareCompositionSupport(out DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS pFlags);
    }
}

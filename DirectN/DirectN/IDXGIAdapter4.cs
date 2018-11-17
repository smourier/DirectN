using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    // dxgi1_6.h
    [Guid("3c8d99d1-4fbf-4181-a82c-af66bf7bd24e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIAdapter4 : IDXGIAdapter3
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
        new HRESULT GetDesc2(out DXGI_ADAPTER_DESC2 pDesc);

        // IDXGIAdapter3
        [PreserveSig]
        new HRESULT RegisterHardwareContentProtectionTeardownStatusEvent(IntPtr hEvent, out int pdwCookie);

        [PreserveSig]
        new void UnregisterHardwareContentProtectionTeardownStatus(int dwCookie);

        [PreserveSig]
        new HRESULT QueryVideoMemoryInfo(int NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, out DXGI_QUERY_VIDEO_MEMORY_INFO pVideoMemoryInfo);

        [PreserveSig]
        new HRESULT SetVideoMemoryReservation(int NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, long Reservation);

        [PreserveSig]
        new HRESULT RegisterVideoMemoryBudgetChangeNotificationEvent(IntPtr hEvent, out int pdwCookie);

        [PreserveSig]
        new void UnregisterVideoMemoryBudgetChangeNotification(int dwCookie);

        // IDXGIAdapter4
        [PreserveSig]
        HRESULT GetDesc3(out DXGI_ADAPTER_DESC3 pDesc);
    }
}

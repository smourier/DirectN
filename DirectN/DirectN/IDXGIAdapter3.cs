using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    // dxgi1_3.h
    [Guid("645967A4-1392-4310-A798-8053CE3E93FD"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIAdapter3 : IDXGIAdapter2
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
        HRESULT RegisterHardwareContentProtectionTeardownStatusEvent(IntPtr hEvent, out int pdwCookie);

        [PreserveSig]
        void UnregisterHardwareContentProtectionTeardownStatus(int dwCookie);

        [PreserveSig]
        HRESULT QueryVideoMemoryInfo(int NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, out DXGI_QUERY_VIDEO_MEMORY_INFO pVideoMemoryInfo);

        [PreserveSig]
        HRESULT SetVideoMemoryReservation(int NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, long Reservation);

        [PreserveSig]
        HRESULT RegisterVideoMemoryBudgetChangeNotificationEvent(IntPtr hEvent, out int pdwCookie);

        [PreserveSig]
        void UnregisterVideoMemoryBudgetChangeNotification(int dwCookie);
    }
}

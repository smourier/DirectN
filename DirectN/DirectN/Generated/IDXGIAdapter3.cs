// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgi1_4.h(1225,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("645967a4-1392-4310-a798-8053ce3e93fd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIAdapter3 : IDXGIAdapter2
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [in] */ uint DataSize, /* [annotation][in] _In_reads_bytes_(DataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* optional(IUnknown) */ IntPtr pUnknown);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [annotation][out][in] _Inout_ */ ref uint pDataSize, /* [annotation][out] _Out_writes_bytes_(*pDataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT GetParent(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][retval][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);
        
        // IDXGIAdapter
        [PreserveSig]
        new HRESULT EnumOutputs(/* [in] */ uint Output, /* [annotation][out][in] _COM_Outptr_ */ out IDXGIOutput ppOutput);
        
        [PreserveSig]
        new HRESULT GetDesc(/* [annotation][out] _Out_ */ out DXGI_ADAPTER_DESC pDesc);
        
        [PreserveSig]
        new HRESULT CheckInterfaceSupport(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid InterfaceName, /* [annotation][out] _Out_ */ out long pUMDVersion);
        
        // IDXGIAdapter1
        [PreserveSig]
        new HRESULT GetDesc1(/* [annotation][out] _Out_ */ out DXGI_ADAPTER_DESC1 pDesc);
        
        // IDXGIAdapter2
        [PreserveSig]
        new HRESULT GetDesc2(/* [annotation][out] _Out_ */ out DXGI_ADAPTER_DESC2 pDesc);
        
        // IDXGIAdapter3
        [PreserveSig]
        HRESULT RegisterHardwareContentProtectionTeardownStatusEvent(/* [annotation][in] _In_ */ IntPtr hEvent, /* [annotation][out] _Out_ */ out uint pdwCookie);
        
        [PreserveSig]
        void UnregisterHardwareContentProtectionTeardownStatus(/* [annotation][in] _In_ */ uint dwCookie);
        
        [PreserveSig]
        HRESULT QueryVideoMemoryInfo(/* [annotation][in] _In_ */ uint NodeIndex, /* [annotation][in] _In_ */ DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, /* [annotation][out] _Out_ */ out DXGI_QUERY_VIDEO_MEMORY_INFO pVideoMemoryInfo);
        
        [PreserveSig]
        HRESULT SetVideoMemoryReservation(/* [annotation][in] _In_ */ uint NodeIndex, /* [annotation][in] _In_ */ DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, /* [annotation][in] _In_ */ ulong Reservation);
        
        [PreserveSig]
        HRESULT RegisterVideoMemoryBudgetChangeNotificationEvent(/* [annotation][in] _In_ */ IntPtr hEvent, /* [annotation][out] _Out_ */ out uint pdwCookie);
        
        [PreserveSig]
        void UnregisterVideoMemoryBudgetChangeNotification(/* [annotation][in] _In_ */ uint dwCookie);
    }
}

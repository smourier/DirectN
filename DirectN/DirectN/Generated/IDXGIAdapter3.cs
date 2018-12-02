// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_4.h(1225,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("645967a4-1392-4310-a798-8053ce3e93fd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIAdapter3
    {
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

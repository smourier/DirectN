using System;
using System.Runtime.InteropServices;
using DXGI_DEBUG_ID = System.Guid;
using DXGI_INFO_QUEUE_MESSAGE_ID = System.Int32;

namespace DirectN
{
    [Guid("D67441C7-672A-476f-9E82-CD55B44949CE"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIInfoQueue
    {
        [PreserveSig]
        HRESULT SetMessageCountLimit(DXGI_DEBUG_ID Producer, ulong MessageCountLimit);

        [PreserveSig]
        void ClearStoredMessages(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        HRESULT GetMessage(DXGI_DEBUG_ID Producer, ulong MessageIndex, out DXGI_INFO_QUEUE_MESSAGE pMessage, ref IntPtr pMessageByteLength);

        [PreserveSig]
        ulong GetNumStoredMessagesAllowedByRetrievalFilters(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        ulong GetNumStoredMessages(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        ulong GetNumMessagesDiscardedByMessageCountLimit(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        ulong GetMessageCountLimit(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        ulong GetNumMessagesAllowedByStorageFilter(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        ulong GetNumMessagesDeniedByStorageFilter(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        HRESULT AddStorageFilterEntries(DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_FILTER[] pFilter);

        [PreserveSig]
        HRESULT GetStorageFilter(DXGI_DEBUG_ID Producer, out IntPtr pFilter, ref IntPtr pFilterByteLength);

        [PreserveSig]
        void ClearStorageFilter(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        HRESULT PushEmptyStorageFilter(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        HRESULT PushDenyAllStorageFilter(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        HRESULT PushCopyOfStorageFilter(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        HRESULT PushStorageFilter(DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_FILTER[] pFilter);

        [PreserveSig]
        void PopStorageFilter(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        uint GetStorageFilterStackSize(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        HRESULT AddRetrievalFilterEntries(DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_FILTER[] pFilter);

        [PreserveSig]
        HRESULT GetRetrievalFilter(DXGI_DEBUG_ID Producer, out IntPtr pFilter, ref IntPtr pFilterByteLength);

        [PreserveSig]
        void ClearRetrievalFilter(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        HRESULT PushEmptyRetrievalFilter(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        HRESULT PushDenyAllRetrievalFilter(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        HRESULT PushCopyOfRetrievalFilter(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        HRESULT PushRetrievalFilter(DXGI_DEBUG_ID Producer, ref DXGI_INFO_QUEUE_FILTER pFilter);

        [PreserveSig]
        void PopRetrievalFilter(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        uint GetRetrievalFilterStackSize(DXGI_DEBUG_ID Producer);

        [PreserveSig]
        HRESULT AddMessage(DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, DXGI_INFO_QUEUE_MESSAGE_ID ID, [MarshalAs(UnmanagedType.LPWStr)] string pDescription);

        [PreserveSig]
        HRESULT AddApplicationMessage(DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [MarshalAs(UnmanagedType.LPWStr)] string pDescription);

        [PreserveSig]
        HRESULT SetBreakOnCategory(DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, bool bEnable);

        [PreserveSig]
        HRESULT SetBreakOnSeverity(DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, bool bEnable);

        [PreserveSig]
        HRESULT SetBreakOnID(DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_ID ID, bool bEnable);

        [PreserveSig]
        bool GetBreakOnCategory(DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category);

        [PreserveSig]
        bool GetBreakOnSeverity(DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity);

        [PreserveSig]
        bool GetBreakOnID(DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_ID ID);

        [PreserveSig]
        void SetMuteDebugOutput(DXGI_DEBUG_ID Producer, bool bMute);

        [PreserveSig]
        bool GetMuteDebugOutput(DXGI_DEBUG_ID Producer);
    }
}

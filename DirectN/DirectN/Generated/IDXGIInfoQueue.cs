// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxgidebug.h(180,5)
using System;
using System.Runtime.InteropServices;
using DXGI_DEBUG_ID = System.Guid;

namespace DirectN
{
    [ComImport, Guid("d67441c7-672a-476f-9e82-cd55b44949ce"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIInfoQueue
    {
        [PreserveSig]
        HRESULT SetMessageCountLimit(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ ulong MessageCountLimit);
        
        [PreserveSig]
        void ClearStoredMessages(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        HRESULT GetMessageW(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ ulong MessageIndex, /* optional(DXGI_INFO_QUEUE_MESSAGE) */ IntPtr pMessage, /* [annotation] _Inout_ */ IntPtr pMessageByteLength);
        
        [PreserveSig]
        ulong GetNumStoredMessagesAllowedByRetrievalFilters(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        ulong GetNumStoredMessages(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        ulong GetNumMessagesDiscardedByMessageCountLimit(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        ulong GetMessageCountLimit(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        ulong GetNumMessagesAllowedByStorageFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        ulong GetNumMessagesDeniedByStorageFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        HRESULT AddStorageFilterEntries(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ ref DXGI_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        HRESULT GetStorageFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* optional(DXGI_INFO_QUEUE_FILTER) */ IntPtr pFilter, /* [annotation] _Inout_ */ IntPtr pFilterByteLength);
        
        [PreserveSig]
        void ClearStorageFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        HRESULT PushEmptyStorageFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        HRESULT PushDenyAllStorageFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        HRESULT PushCopyOfStorageFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        HRESULT PushStorageFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ ref DXGI_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        void PopStorageFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        uint GetStorageFilterStackSize(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        HRESULT AddRetrievalFilterEntries(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ ref DXGI_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        HRESULT GetRetrievalFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* optional(DXGI_INFO_QUEUE_FILTER) */ IntPtr pFilter, /* [annotation] _Inout_ */ IntPtr pFilterByteLength);
        
        [PreserveSig]
        void ClearRetrievalFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        HRESULT PushEmptyRetrievalFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        HRESULT PushDenyAllRetrievalFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        HRESULT PushCopyOfRetrievalFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        HRESULT PushRetrievalFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ ref DXGI_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        void PopRetrievalFilter(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        uint GetRetrievalFilterStackSize(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
        
        [PreserveSig]
        HRESULT AddMessage(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, /* [annotation] _In_ */ DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, /* [annotation] _In_ */ int ID, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pDescription);
        
        [PreserveSig]
        HRESULT AddApplicationMessage(/* [annotation] _In_ */ DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pDescription);
        
        [PreserveSig]
        HRESULT SetBreakOnCategory(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, /* [annotation] _In_ */ bool bEnable);
        
        [PreserveSig]
        HRESULT SetBreakOnSeverity(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, /* [annotation] _In_ */ bool bEnable);
        
        [PreserveSig]
        HRESULT SetBreakOnID(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ int ID, /* [annotation] _In_ */ bool bEnable);
        
        [PreserveSig]
        bool GetBreakOnCategory(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category);
        
        [PreserveSig]
        bool GetBreakOnSeverity(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity);
        
        [PreserveSig]
        bool GetBreakOnID(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ int ID);
        
        [PreserveSig]
        void SetMuteDebugOutput(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer, /* [annotation] _In_ */ bool bMute);
        
        [PreserveSig]
        bool GetMuteDebugOutput(/* [annotation] _In_ */ DXGI_DEBUG_ID Producer);
    }
}

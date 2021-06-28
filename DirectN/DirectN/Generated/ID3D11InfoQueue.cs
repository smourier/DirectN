// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11sdklayers.h(2151,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6543dbb6-1b48-42f5-ab82-e97ec74326f6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11InfoQueue
    {
        [PreserveSig]
        HRESULT SetMessageCountLimit(/* [annotation] _In_ */ ulong MessageCountLimit);
        
        [PreserveSig]
        void ClearStoredMessages();
        
        [PreserveSig]
        HRESULT GetMessageW(/* [annotation] _In_ */ ulong MessageIndex, /* optional(D3D11_MESSAGE) */ IntPtr pMessage, /* [annotation] _Inout_ */ IntPtr pMessageByteLength);
        
        [PreserveSig]
        ulong GetNumMessagesAllowedByStorageFilter();
        
        [PreserveSig]
        ulong GetNumMessagesDeniedByStorageFilter();
        
        [PreserveSig]
        ulong GetNumStoredMessages();
        
        [PreserveSig]
        ulong GetNumStoredMessagesAllowedByRetrievalFilter();
        
        [PreserveSig]
        ulong GetNumMessagesDiscardedByMessageCountLimit();
        
        [PreserveSig]
        ulong GetMessageCountLimit();
        
        [PreserveSig]
        HRESULT AddStorageFilterEntries(/* [annotation] _In_ */ ref D3D11_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        HRESULT GetStorageFilter(/* optional(D3D11_INFO_QUEUE_FILTER) */ IntPtr pFilter, /* [annotation] _Inout_ */ IntPtr pFilterByteLength);
        
        [PreserveSig]
        void ClearStorageFilter();
        
        [PreserveSig]
        HRESULT PushEmptyStorageFilter();
        
        [PreserveSig]
        HRESULT PushCopyOfStorageFilter();
        
        [PreserveSig]
        HRESULT PushStorageFilter(/* [annotation] _In_ */ ref D3D11_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        void PopStorageFilter();
        
        [PreserveSig]
        uint GetStorageFilterStackSize();
        
        [PreserveSig]
        HRESULT AddRetrievalFilterEntries(/* [annotation] _In_ */ ref D3D11_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        HRESULT GetRetrievalFilter(/* optional(D3D11_INFO_QUEUE_FILTER) */ IntPtr pFilter, /* [annotation] _Inout_ */ IntPtr pFilterByteLength);
        
        [PreserveSig]
        void ClearRetrievalFilter();
        
        [PreserveSig]
        HRESULT PushEmptyRetrievalFilter();
        
        [PreserveSig]
        HRESULT PushCopyOfRetrievalFilter();
        
        [PreserveSig]
        HRESULT PushRetrievalFilter(/* [annotation] _In_ */ ref D3D11_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        void PopRetrievalFilter();
        
        [PreserveSig]
        uint GetRetrievalFilterStackSize();
        
        [PreserveSig]
        HRESULT AddMessage(/* [annotation] _In_ */ D3D11_MESSAGE_CATEGORY Category, /* [annotation] _In_ */ D3D11_MESSAGE_SEVERITY Severity, /* [annotation] _In_ */ D3D11_MESSAGE_ID ID, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pDescription);
        
        [PreserveSig]
        HRESULT AddApplicationMessage(/* [annotation] _In_ */ D3D11_MESSAGE_SEVERITY Severity, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pDescription);
        
        [PreserveSig]
        HRESULT SetBreakOnCategory(/* [annotation] _In_ */ D3D11_MESSAGE_CATEGORY Category, /* [annotation] _In_ */ bool bEnable);
        
        [PreserveSig]
        HRESULT SetBreakOnSeverity(/* [annotation] _In_ */ D3D11_MESSAGE_SEVERITY Severity, /* [annotation] _In_ */ bool bEnable);
        
        [PreserveSig]
        HRESULT SetBreakOnID(/* [annotation] _In_ */ D3D11_MESSAGE_ID ID, /* [annotation] _In_ */ bool bEnable);
        
        [PreserveSig]
        bool GetBreakOnCategory(/* [annotation] _In_ */ D3D11_MESSAGE_CATEGORY Category);
        
        [PreserveSig]
        bool GetBreakOnSeverity(/* [annotation] _In_ */ D3D11_MESSAGE_SEVERITY Severity);
        
        [PreserveSig]
        bool GetBreakOnID(/* [annotation] _In_ */ D3D11_MESSAGE_ID ID);
        
        [PreserveSig]
        void SetMuteDebugOutput(/* [annotation] _In_ */ bool bMute);
        
        [PreserveSig]
        bool GetMuteDebugOutput();
    }
}

// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;
using D3D12MessageFunc = System.IntPtr;

namespace DirectN
{
    [ComImport, Guid("2852dd88-b484-4c0c-b6b1-67168500e600"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12InfoQueue1 : ID3D12InfoQueue
    {
        // ID3D12InfoQueue
        [PreserveSig]
        new HRESULT SetMessageCountLimit(/* _In_ */ ulong MessageCountLimit);
        
        [PreserveSig]
        new void ClearStoredMessages();
        
        [PreserveSig]
        new HRESULT GetMessageW(/* _In_ */ ulong MessageIndex, /* optional(D3D12_MESSAGE) */ IntPtr pMessage, /* _Inout_ */ IntPtr pMessageByteLength);
        
        [PreserveSig]
        new ulong GetNumMessagesAllowedByStorageFilter();
        
        [PreserveSig]
        new ulong GetNumMessagesDeniedByStorageFilter();
        
        [PreserveSig]
        new ulong GetNumStoredMessages();
        
        [PreserveSig]
        new ulong GetNumStoredMessagesAllowedByRetrievalFilter();
        
        [PreserveSig]
        new ulong GetNumMessagesDiscardedByMessageCountLimit();
        
        [PreserveSig]
        new ulong GetMessageCountLimit();
        
        [PreserveSig]
        new HRESULT AddStorageFilterEntries(/* _In_ */ ref D3D12_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        new HRESULT GetStorageFilter(/* optional(D3D12_INFO_QUEUE_FILTER) */ IntPtr pFilter, /* _Inout_ */ IntPtr pFilterByteLength);
        
        [PreserveSig]
        new void ClearStorageFilter();
        
        [PreserveSig]
        new HRESULT PushEmptyStorageFilter();
        
        [PreserveSig]
        new HRESULT PushCopyOfStorageFilter();
        
        [PreserveSig]
        new HRESULT PushStorageFilter(/* _In_ */ ref D3D12_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        new void PopStorageFilter();
        
        [PreserveSig]
        new uint GetStorageFilterStackSize();
        
        [PreserveSig]
        new HRESULT AddRetrievalFilterEntries(/* _In_ */ ref D3D12_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        new HRESULT GetRetrievalFilter(/* optional(D3D12_INFO_QUEUE_FILTER) */ IntPtr pFilter, /* _Inout_ */ IntPtr pFilterByteLength);
        
        [PreserveSig]
        new void ClearRetrievalFilter();
        
        [PreserveSig]
        new HRESULT PushEmptyRetrievalFilter();
        
        [PreserveSig]
        new HRESULT PushCopyOfRetrievalFilter();
        
        [PreserveSig]
        new HRESULT PushRetrievalFilter(/* _In_ */ ref D3D12_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        new void PopRetrievalFilter();
        
        [PreserveSig]
        new uint GetRetrievalFilterStackSize();
        
        [PreserveSig]
        new HRESULT AddMessage(/* _In_ */ D3D12_MESSAGE_CATEGORY Category, /* _In_ */ D3D12_MESSAGE_SEVERITY Severity, /* _In_ */ D3D12_MESSAGE_ID ID, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pDescription);
        
        [PreserveSig]
        new HRESULT AddApplicationMessage(/* _In_ */ D3D12_MESSAGE_SEVERITY Severity, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pDescription);
        
        [PreserveSig]
        new HRESULT SetBreakOnCategory(/* _In_ */ D3D12_MESSAGE_CATEGORY Category, /* _In_ */ bool bEnable);
        
        [PreserveSig]
        new HRESULT SetBreakOnSeverity(/* _In_ */ D3D12_MESSAGE_SEVERITY Severity, /* _In_ */ bool bEnable);
        
        [PreserveSig]
        new HRESULT SetBreakOnID(/* _In_ */ D3D12_MESSAGE_ID ID, /* _In_ */ bool bEnable);
        
        [PreserveSig]
        new bool GetBreakOnCategory(/* _In_ */ D3D12_MESSAGE_CATEGORY Category);
        
        [PreserveSig]
        new bool GetBreakOnSeverity(/* _In_ */ D3D12_MESSAGE_SEVERITY Severity);
        
        [PreserveSig]
        new bool GetBreakOnID(/* _In_ */ D3D12_MESSAGE_ID ID);
        
        [PreserveSig]
        new void SetMuteDebugOutput(/* _In_ */ bool bMute);
        
        [PreserveSig]
        new bool GetMuteDebugOutput();
        
        // ID3D12InfoQueue1
        [PreserveSig]
        HRESULT RegisterMessageCallback(/* _In_ */ IntPtr CallbackFunc, /* _In_ */ D3D12_MESSAGE_CALLBACK_FLAGS CallbackFilterFlags, /* _In_ */ IntPtr pContext, /* _Inout_ */ ref uint pCallbackCookie);
        
        [PreserveSig]
        HRESULT UnregisterMessageCallback(/* _In_ */ uint CallbackCookie);
    }
}

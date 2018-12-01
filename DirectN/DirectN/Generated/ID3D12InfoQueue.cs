// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12sdklayers.h(2774,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0742a90b-c387-483f-b946-30a7e4e61458"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12InfoQueue
    {
        [PreserveSig]
        HRESULT SetMessageCountLimit(/* _In_ */ ulong MessageCountLimit);
        
        [PreserveSig]
        void ClearStoredMessages();
        
        [PreserveSig]
        HRESULT GetMessageA(/* _In_ */ ulong MessageIndex, /* _Out_writes_bytes_opt_(*pMessageByteLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D12_MESSAGE[] pMessage, /* _Inout_ */ IntPtr pMessageByteLength);
        
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
        HRESULT AddStorageFilterEntries(/* _In_ */ ref D3D12_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        HRESULT GetStorageFilter(/* _Out_writes_bytes_opt_(*pFilterByteLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D12_INFO_QUEUE_FILTER[] pFilter, /* _Inout_ */ IntPtr pFilterByteLength);
        
        [PreserveSig]
        void ClearStorageFilter();
        
        [PreserveSig]
        HRESULT PushEmptyStorageFilter();
        
        [PreserveSig]
        HRESULT PushCopyOfStorageFilter();
        
        [PreserveSig]
        HRESULT PushStorageFilter(/* _In_ */ ref D3D12_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        void PopStorageFilter();
        
        [PreserveSig]
        uint GetStorageFilterStackSize();
        
        [PreserveSig]
        HRESULT AddRetrievalFilterEntries(/* _In_ */ ref D3D12_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        HRESULT GetRetrievalFilter(/* _Out_writes_bytes_opt_(*pFilterByteLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D12_INFO_QUEUE_FILTER[] pFilter, /* _Inout_ */ IntPtr pFilterByteLength);
        
        [PreserveSig]
        void ClearRetrievalFilter();
        
        [PreserveSig]
        HRESULT PushEmptyRetrievalFilter();
        
        [PreserveSig]
        HRESULT PushCopyOfRetrievalFilter();
        
        [PreserveSig]
        HRESULT PushRetrievalFilter(/* _In_ */ ref D3D12_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        void PopRetrievalFilter();
        
        [PreserveSig]
        uint GetRetrievalFilterStackSize();
        
        [PreserveSig]
        HRESULT AddMessage(/* _In_ */ D3D12_MESSAGE_CATEGORY Category, /* _In_ */ D3D12_MESSAGE_SEVERITY Severity, /* _In_ */ D3D12_MESSAGE_ID ID, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pDescription);
        
        [PreserveSig]
        HRESULT AddApplicationMessage(/* _In_ */ D3D12_MESSAGE_SEVERITY Severity, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pDescription);
        
        [PreserveSig]
        HRESULT SetBreakOnCategory(/* _In_ */ D3D12_MESSAGE_CATEGORY Category, /* _In_ */ bool bEnable);
        
        [PreserveSig]
        HRESULT SetBreakOnSeverity(/* _In_ */ D3D12_MESSAGE_SEVERITY Severity, /* _In_ */ bool bEnable);
        
        [PreserveSig]
        HRESULT SetBreakOnID(/* _In_ */ D3D12_MESSAGE_ID ID, /* _In_ */ bool bEnable);
        
        [PreserveSig]
        bool GetBreakOnCategory(/* _In_ */ D3D12_MESSAGE_CATEGORY Category);
        
        [PreserveSig]
        bool GetBreakOnSeverity(/* _In_ */ D3D12_MESSAGE_SEVERITY Severity);
        
        [PreserveSig]
        bool GetBreakOnID(/* _In_ */ D3D12_MESSAGE_ID ID);
        
        [PreserveSig]
        void SetMuteDebugOutput(/* _In_ */ bool bMute);
        
        [PreserveSig]
        bool GetMuteDebugOutput();
    }
}

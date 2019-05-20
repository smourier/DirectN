// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10sdklayers.h(926,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1b940b17-2642-4d1f-ab1f-b99bad0c395f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10InfoQueue
    {
        [PreserveSig]
        HRESULT SetMessageCountLimit(/* [annotation] _In_ */ ulong MessageCountLimit);
        
        [PreserveSig]
        void ClearStoredMessages();
        
        [PreserveSig]
        HRESULT GetMessageW(/* [annotation] _In_ */ ulong MessageIndex, /* [annotation] _Out_writes_bytes_opt_(*pMessageByteLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D10_MESSAGE[] pMessage, /* [annotation] _Inout_ */ IntPtr pMessageByteLength);
        
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
        HRESULT AddStorageFilterEntries(/* [annotation] _In_ */ ref D3D10_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        HRESULT GetStorageFilter(/* [annotation] _Out_writes_bytes_opt_(*pFilterByteLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D10_INFO_QUEUE_FILTER[] pFilter, /* [annotation] _Inout_ */ IntPtr pFilterByteLength);
        
        [PreserveSig]
        void ClearStorageFilter();
        
        [PreserveSig]
        HRESULT PushEmptyStorageFilter();
        
        [PreserveSig]
        HRESULT PushCopyOfStorageFilter();
        
        [PreserveSig]
        HRESULT PushStorageFilter(/* [annotation] _In_ */ ref D3D10_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        void PopStorageFilter();
        
        [PreserveSig]
        uint GetStorageFilterStackSize();
        
        [PreserveSig]
        HRESULT AddRetrievalFilterEntries(/* [annotation] _In_ */ ref D3D10_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        HRESULT GetRetrievalFilter(/* [annotation] _Out_writes_bytes_opt_(*pFilterByteLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D10_INFO_QUEUE_FILTER[] pFilter, /* [annotation] _Inout_ */ IntPtr pFilterByteLength);
        
        [PreserveSig]
        void ClearRetrievalFilter();
        
        [PreserveSig]
        HRESULT PushEmptyRetrievalFilter();
        
        [PreserveSig]
        HRESULT PushCopyOfRetrievalFilter();
        
        [PreserveSig]
        HRESULT PushRetrievalFilter(/* [annotation] _In_ */ ref D3D10_INFO_QUEUE_FILTER pFilter);
        
        [PreserveSig]
        void PopRetrievalFilter();
        
        [PreserveSig]
        uint GetRetrievalFilterStackSize();
        
        [PreserveSig]
        HRESULT AddMessage(/* [annotation] _In_ */ D3D10_MESSAGE_CATEGORY Category, /* [annotation] _In_ */ D3D10_MESSAGE_SEVERITY Severity, /* [annotation] _In_ */ D3D10_MESSAGE_ID ID, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pDescription);
        
        [PreserveSig]
        HRESULT AddApplicationMessage(/* [annotation] _In_ */ D3D10_MESSAGE_SEVERITY Severity, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pDescription);
        
        [PreserveSig]
        HRESULT SetBreakOnCategory(/* [annotation] _In_ */ D3D10_MESSAGE_CATEGORY Category, /* [annotation] _In_ */ bool bEnable);
        
        [PreserveSig]
        HRESULT SetBreakOnSeverity(/* [annotation] _In_ */ D3D10_MESSAGE_SEVERITY Severity, /* [annotation] _In_ */ bool bEnable);
        
        [PreserveSig]
        HRESULT SetBreakOnID(/* [annotation] _In_ */ D3D10_MESSAGE_ID ID, /* [annotation] _In_ */ bool bEnable);
        
        [PreserveSig]
        bool GetBreakOnCategory(/* [annotation] _In_ */ D3D10_MESSAGE_CATEGORY Category);
        
        [PreserveSig]
        bool GetBreakOnSeverity(/* [annotation] _In_ */ D3D10_MESSAGE_SEVERITY Severity);
        
        [PreserveSig]
        bool GetBreakOnID(/* [annotation] _In_ */ D3D10_MESSAGE_ID ID);
        
        [PreserveSig]
        void SetMuteDebugOutput(/* [annotation] _In_ */ bool bMute);
        
        [PreserveSig]
        bool GetMuteDebugOutput();
    }
}

// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("31efac30-515c-11d0-a9aa-00aa0061be93"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsPropertySet
    {
        [PreserveSig]
        HRESULT Get(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidPropSet, uint ulId, /* optional(LPVOID) */ IntPtr pInstanceData, uint ulInstanceLength, /* _Out_writes_bytes_(ulDataLength) */ IntPtr pPropertyData, uint ulDataLength, /* optional(PULONG) */ IntPtr pulBytesReturned);
        
        [PreserveSig]
        HRESULT Set(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidPropSet, uint ulId, /* optional(LPVOID) */ IntPtr pInstanceData, uint ulInstanceLength, /* _In_reads_bytes_(ulDataLength) */ IntPtr pPropertyData, uint ulDataLength);
        
        [PreserveSig]
        HRESULT QuerySupport(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidPropSet, uint ulId, /* _Out_ */ out uint pulTypeSupport);
    }
}

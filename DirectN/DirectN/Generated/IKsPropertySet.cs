// generated from <Windows SDK Path>\shared\ksproxy.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("31efac30-515c-11d0-a9aa-00aa0061be93"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsPropertySet
    {
        [PreserveSig]
        HRESULT Set(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid PropSet, /* _In_ */ uint Id, /* _In_reads_bytes_(InstanceLength) */ IntPtr InstanceData, /* _In_ */ uint InstanceLength, /* _In_reads_bytes_(DataLength) */ IntPtr PropertyData, /* _In_ */ uint DataLength);
        
        [PreserveSig]
        HRESULT Get(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid PropSet, /* _In_ */ uint Id, /* _In_reads_bytes_(InstanceLength) */ IntPtr InstanceData, /* _In_ */ uint InstanceLength, /* _Out_writes_bytes_(DataLength) */ IntPtr PropertyData, /* _In_ */ uint DataLength, /* _Out_ */ out uint BytesReturned);
        
        [PreserveSig]
        HRESULT QuerySupported(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid PropSet, /* _In_ */ uint Id, /* _Out_ */ out uint TypeSupport);
    }
}

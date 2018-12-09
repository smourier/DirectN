// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksproxy.h(783,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("28f54685-06fd-11d2-b27a-00a0c9223196"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsControl
    {
        [PreserveSig]
        HRESULT KsProperty(/* THIS_ _In_reads_bytes_(PropertyLength) */ int Property, /* _In_ */ uint PropertyLength, /* _Inout_updates_bytes_(DataLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] IntPtr[] PropertyData, /* _In_ */ uint DataLength, /* optional(ULONG) */ IntPtr BytesReturned);
        
        [PreserveSig]
        HRESULT KsMethod(/* THIS_ _In_reads_bytes_(MethodLength) */ int Method, /* _In_ */ uint MethodLength, /* _Inout_updates_bytes_(DataLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] IntPtr[] MethodData, /* _In_ */ uint DataLength, /* optional(ULONG) */ IntPtr BytesReturned);
        
        [PreserveSig]
        HRESULT KsEvent(/* THIS_ _In_reads_bytes_opt_(EventLength) */ int Event, /* _In_ */ uint EventLength, /* _Inout_updates_bytes_(DataLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] IntPtr[] EventData, /* _In_ */ uint DataLength, /* optional(ULONG) */ IntPtr BytesReturned);
    }
}

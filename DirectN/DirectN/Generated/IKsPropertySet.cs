// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksproxy.h(740,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("31efac30-515c-11d0-a9aa-00aa0061be93"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsPropertySet
    {
        [PreserveSig]
        HRESULT Set(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid PropSet, /* _In_ */ uint Id, /* _In_reads_bytes_(InstanceLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] IntPtr[] InstanceData, /* _In_ */ int InstanceLength, /* _In_reads_bytes_(DataLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] IntPtr[] PropertyData, /* _In_ */ int DataLength);
        
        [PreserveSig]
        HRESULT Get(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid PropSet, /* _In_ */ uint Id, /* _In_reads_bytes_(InstanceLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] IntPtr[] InstanceData, /* _In_ */ int InstanceLength, /* _Out_writes_bytes_(DataLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] IntPtr[] PropertyData, /* _In_ */ int DataLength, /* _Out_ */ out uint BytesReturned);
        
        [PreserveSig]
        HRESULT QuerySupported(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid PropSet, /* _In_ */ uint Id, /* _Out_ */ out uint TypeSupport);
    }
}

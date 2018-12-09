// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksproxy.h(821,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7f40eac0-3947-11d2-874e-00a0c9223196"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsAggregateControl
    {
        [PreserveSig]
        HRESULT KsAddAggregate(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid AggregateClass);
        
        [PreserveSig]
        HRESULT KsRemoveAggregate(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid AggregateClass);
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksproxy.h(843,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("28f54683-06fd-11d2-b27a-00a0c9223196"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsTopology
    {
        [PreserveSig]
        HRESULT CreateNodeInstance(/* THIS_ _In_ */ uint NodeId, /* _In_ */ uint Flags, /* _In_ */ uint DesiredAccess, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object UnkOuter, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid InterfaceId, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object Interface);
    }
}

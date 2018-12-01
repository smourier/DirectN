// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(10709,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("676aa6dd-238a-410d-bb99-65668d01605a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTopologyNodeAttributeEditor
    {
        [PreserveSig]
        HRESULT UpdateNodeAttributes(/* [in] */ ulong TopoId, /* [in] */ uint cUpdates, /* [size_is][in] __RPC__in_ecount_full(cUpdates) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _MFTOPONODE_ATTRIBUTE_UPDATE[] pUpdates);
    }
}

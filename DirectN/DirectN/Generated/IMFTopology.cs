// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(3828,5)
using System;
using System.Runtime.InteropServices;
using TOPOID = System.UInt64;

namespace DirectN
{
    [Guid("83cf873a-f6da-4bc8-823f-bacfd55dc433"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTopology
    {
        [PreserveSig]
        HRESULT GetTopologyID(/* [out] __RPC__out */ out TOPOID pID);
        
        [PreserveSig]
        HRESULT AddNode(/* [in] */ IMFTopologyNode pNode);
        
        [PreserveSig]
        HRESULT RemoveNode(/* [in] */ IMFTopologyNode pNode);
        
        [PreserveSig]
        HRESULT GetNodeCount(/* [out] __RPC__out */ out ushort pwNodes);
        
        [PreserveSig]
        HRESULT GetNode(/* [in] */ ushort wIndex, /* [out] __RPC__deref_out_opt */ out IMFTopologyNode ppNode);
        
        [PreserveSig]
        HRESULT Clear();
        
        [PreserveSig]
        HRESULT CloneFrom(/* [in] __RPC__in_opt */ IMFTopology pTopology);
        
        [PreserveSig]
        HRESULT GetNodeByID(/* [in] */ ulong qwTopoNodeID, /* [out] __RPC__deref_out_opt */ out IMFTopologyNode ppNode);
        
        [PreserveSig]
        HRESULT GetSourceNodeCollection(/* optional(IMFCollection) */ out IntPtr ppCollection);
        
        [PreserveSig]
        HRESULT GetOutputNodeCollection(/* optional(IMFCollection) */ out IntPtr ppCollection);
    }
}

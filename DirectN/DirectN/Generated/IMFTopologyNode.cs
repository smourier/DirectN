// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(4313,5)
using System;
using System.Runtime.InteropServices;
using TOPOID = System.UInt64;

namespace DirectN
{
    [Guid("83cf873a-f6da-4bc8-823f-bacfd55dc430"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTopologyNode
    {
        [PreserveSig]
        HRESULT SetObject(/* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pObject);
        
        [PreserveSig]
        HRESULT GetObjectA(/* [out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        
        [PreserveSig]
        HRESULT GetNodeType(/* [out] __RPC__out */ out MF_TOPOLOGY_TYPE pType);
        
        [PreserveSig]
        HRESULT GetTopoNodeID(/* [out] __RPC__out */ out TOPOID pID);
        
        [PreserveSig]
        HRESULT SetTopoNodeID(/* [in] */ ulong ullTopoID);
        
        [PreserveSig]
        HRESULT GetInputCount(/* [out] __RPC__out */ out uint pcInputs);
        
        [PreserveSig]
        HRESULT GetOutputCount(/* [out] __RPC__out */ out uint pcOutputs);
        
        [PreserveSig]
        HRESULT ConnectOutput(/* [in] */ uint dwOutputIndex, /* [in] */ IMFTopologyNode pDownstreamNode, /* [in] */ uint dwInputIndexOnDownstreamNode);
        
        [PreserveSig]
        HRESULT DisconnectOutput(/* [in] */ uint dwOutputIndex);
        
        [PreserveSig]
        HRESULT GetInput(/* [in] */ uint dwInputIndex, /* [out] __RPC__deref_out_opt */ out IMFTopologyNode ppUpstreamNode, /* [out] __RPC__out */ out uint pdwOutputIndexOnUpstreamNode);
        
        [PreserveSig]
        HRESULT GetOutput(/* [in] */ uint dwOutputIndex, /* [out] __RPC__deref_out_opt */ out IMFTopologyNode ppDownstreamNode, /* [out] __RPC__out */ out uint pdwInputIndexOnDownstreamNode);
        
        [PreserveSig]
        HRESULT SetOutputPrefType(/* [in] */ uint dwOutputIndex, /* [in] */ ref IMFMediaType pType);
        
        [PreserveSig]
        HRESULT GetOutputPrefType(/* [in] */ uint dwOutputIndex, /* [annotation][out] _Outptr_ */ out IntPtr ppType);
        
        [PreserveSig]
        HRESULT SetInputPrefType(/* [in] */ uint dwInputIndex, /* [in] */ ref IMFMediaType pType);
        
        [PreserveSig]
        HRESULT GetInputPrefType(/* [in] */ uint dwInputIndex, /* [annotation][out] _Outptr_ */ out IntPtr ppType);
        
        [PreserveSig]
        HRESULT CloneFrom(/* [in] __RPC__in_opt */ IMFTopologyNode pNode);
    }
}

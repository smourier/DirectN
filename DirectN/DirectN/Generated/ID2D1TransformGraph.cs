// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effectauthor.h(598,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The implementation of the actual graph.
    /// </summary>
    [ComImport, Guid("13d29038-c3e6-4034-9081-13b53a417992"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1TransformGraph
    {
        [PreserveSig]
        uint GetInputCount();
        
        [PreserveSig]
        HRESULT SetSingleTransformNode(/* _In_ */ ID2D1TransformNode node);
        
        [PreserveSig]
        HRESULT AddNode(/* _In_ */ ID2D1TransformNode node);
        
        [PreserveSig]
        HRESULT RemoveNode(/* _In_ */ ID2D1TransformNode node);
        
        [PreserveSig]
        HRESULT SetOutputNode(/* _In_ */ ID2D1TransformNode node);
        
        [PreserveSig]
        HRESULT ConnectNode(/* _In_ */ ID2D1TransformNode fromNode, /* _In_ */ ID2D1TransformNode toNode, uint toNodeInputIndex);
        
        [PreserveSig]
        HRESULT ConnectToEffectInput(uint toEffectInputIndex, /* _In_ */ ID2D1TransformNode node, uint toNodeInputIndex);
        
        [PreserveSig]
        void Clear();
        
        [PreserveSig]
        HRESULT SetPassthroughGraph(uint effectInputIndex);
    }
}

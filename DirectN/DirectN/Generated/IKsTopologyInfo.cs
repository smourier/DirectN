// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\vidcap.h(121,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("720d4ac0-7533-11d0-a5d6-28db04c10000"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsTopologyInfo
    {
        [PreserveSig]
        HRESULT get_NumCategories(/* [out] */ out uint pdwNumCategories);
        
        [PreserveSig]
        HRESULT get_Category(/* [in] */ uint dwIndex, /* [out] */ out Guid pCategory);
        
        [PreserveSig]
        HRESULT get_NumConnections(/* [out] */ out uint pdwNumConnections);
        
        [PreserveSig]
        HRESULT get_ConnectionInfo(/* [in] */ uint dwIndex, /* [out] */ out KSTOPOLOGY_CONNECTION pConnectionInfo);
        
        [PreserveSig]
        HRESULT get_NodeName(/* [in] */ uint dwNodeId, /* [annotation][out] _Out_writes_bytes_opt_(dwBufSize) */ [MarshalAs(UnmanagedType.LPWStr)] string pwchNodeName, /* [in] */ uint dwBufSize, /* [annotation][out] _Out_ */ out uint pdwNameLen);
        
        [PreserveSig]
        HRESULT get_NumNodes(/* [out] */ out uint pdwNumNodes);
        
        [PreserveSig]
        HRESULT get_NodeType(/* [in] */ uint dwNodeId, /* [out] */ out Guid pNodeType);
        
        [PreserveSig]
        HRESULT CreateNodeInstance(/* [in] */ uint dwNodeId, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* [out] */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(4317,5)
using System;
using System.Runtime.InteropServices;
using TOPOID = System.UInt64;

namespace DirectN
{
    [Guid("83cf873a-f6da-4bc8-823f-bacfd55dc430"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTopologyNode : IMFAttributes
    {
        // IMFAttributes
        [PreserveSig]
        new HRESULT GetItem(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [full][out][in] __RPC__inout_opt */ [In, Out] PropVariant pValue);
        
        [PreserveSig]
        new HRESULT GetItemType(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out _MF_ATTRIBUTE_TYPE pType);
        
        [PreserveSig]
        new HRESULT CompareItem(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* __RPC__in */ [In, Out] PropVariant Value, /* [out] __RPC__out */ out bool pbResult);
        
        [PreserveSig]
        new HRESULT Compare(/* __RPC__in_opt */ IMFAttributes pTheirs, _MF_ATTRIBUTES_MATCH_TYPE MatchType, /* [out] __RPC__out */ out bool pbResult);
        
        [PreserveSig]
        new HRESULT GetUINT32(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out uint punValue);
        
        [PreserveSig]
        new HRESULT GetUINT64(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out ulong punValue);
        
        [PreserveSig]
        new HRESULT GetDouble(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out double pfValue);
        
        [PreserveSig]
        new HRESULT GetGUID(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out Guid pguidValue);
        
        [PreserveSig]
        new HRESULT GetStringLength(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out uint pcchLength);
        
        [PreserveSig]
        new HRESULT GetString(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [size_is][out] __RPC__out_ecount_full(cchBufSize) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszValue, uint cchBufSize, /* optional(UINT32) */ IntPtr pcchLength);
        
        [PreserveSig]
        new HRESULT GetAllocatedString(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* optional(LPWSTR) */ IntPtr ppwszValue, /* [out] __RPC__out */ out uint pcchLength);
        
        [PreserveSig]
        new HRESULT GetBlobSize(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out uint pcbBlobSize);
        
        [PreserveSig]
        new HRESULT GetBlob(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [size_is][out] __RPC__out_ecount_full(cbBufSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, int cbBufSize, /* optional(UINT32) */ IntPtr pcbBlobSize);
        
        [PreserveSig]
        new HRESULT GetAllocatedBlob(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* optional(UINT8) */ out IntPtr ppBuf, /* [out] __RPC__out */ out uint pcbSize);
        
        [PreserveSig]
        new HRESULT GetUnknown(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        new HRESULT SetItem(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* __RPC__in */ [In, Out] PropVariant Value);
        
        [PreserveSig]
        new HRESULT DeleteItem(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey);
        
        [PreserveSig]
        new HRESULT DeleteAllItems();
        
        [PreserveSig]
        new HRESULT SetUINT32(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unValue);
        
        [PreserveSig]
        new HRESULT SetUINT64(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, ulong unValue);
        
        [PreserveSig]
        new HRESULT SetDouble(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, double fValue);
        
        [PreserveSig]
        new HRESULT SetGUID(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidValue);
        
        [PreserveSig]
        new HRESULT SetString(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string wszValue);
        
        [PreserveSig]
        new HRESULT SetBlob(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [size_is][in] __RPC__in_ecount_full(cbBufSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, int cbBufSize);
        
        [PreserveSig]
        new HRESULT SetUnknown(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);
        
        [PreserveSig]
        new HRESULT LockStore();
        
        [PreserveSig]
        new HRESULT UnlockStore();
        
        [PreserveSig]
        new HRESULT GetCount(/* [out] __RPC__out */ out uint pcItems);
        
        [PreserveSig]
        new HRESULT GetItemByIndex(uint unIndex, /* [out] __RPC__out */ out Guid pguidKey, /* [full][out][in] __RPC__inout_opt */ [In, Out] PropVariant pValue);
        
        [PreserveSig]
        new HRESULT CopyAllItems(/* [in] __RPC__in_opt */ IMFAttributes pDest);
        
        // IMFTopologyNode
        [PreserveSig]
        HRESULT SetObject(/* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pObject);
        
        [PreserveSig]
        HRESULT GetObjectW(/* [out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        
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
        HRESULT SetOutputPrefType(/* [in] */ uint dwOutputIndex, /* [in] */ IMFMediaType pType);
        
        [PreserveSig]
        HRESULT GetOutputPrefType(/* [in] */ uint dwOutputIndex, /* [annotation][out] _Outptr_ */ out IMFMediaType ppType);
        
        [PreserveSig]
        HRESULT SetInputPrefType(/* [in] */ uint dwInputIndex, /* [in] */ IMFMediaType pType);
        
        [PreserveSig]
        HRESULT GetInputPrefType(/* [in] */ uint dwInputIndex, /* [annotation][out] _Outptr_ */ out IMFMediaType ppType);
        
        [PreserveSig]
        HRESULT CloneFrom(/* [in] __RPC__in_opt */ IMFTopologyNode pNode);
    }
}

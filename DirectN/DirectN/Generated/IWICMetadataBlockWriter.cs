// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodecsdk.h(404,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("08fb9676-b444-41e8-8dbe-6a53a542bff1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICMetadataBlockWriter : IWICMetadataBlockReader
    {
        // IWICMetadataBlockReader
        [PreserveSig]
        new HRESULT GetContainerFormat(/* [out] __RPC__out */ out Guid pguidContainerFormat);
        
        [PreserveSig]
        new HRESULT GetCount(/* [out] __RPC__out */ out uint pcCount);
        
        [PreserveSig]
        new HRESULT GetReaderByIndex(/* [in] */ uint nIndex, /* [out] __RPC__deref_out_opt */ out IWICMetadataReader ppIMetadataReader);
        
        [PreserveSig]
        new HRESULT GetEnumerator(/* [out] __RPC__deref_out_opt */ out IEnumUnknown ppIEnumMetadata);
        
        // IWICMetadataBlockWriter
        [PreserveSig]
        HRESULT InitializeFromBlockReader(/* [in] __RPC__in_opt */ IWICMetadataBlockReader pIMDBlockReader);
        
        [PreserveSig]
        HRESULT GetWriterByIndex(/* [in] */ uint nIndex, /* [out] __RPC__deref_out_opt */ out IWICMetadataWriter ppIMetadataWriter);
        
        [PreserveSig]
        HRESULT AddWriter(/* [in] __RPC__in_opt */ IWICMetadataWriter pIMetadataWriter);
        
        [PreserveSig]
        HRESULT SetWriterByIndex(/* [in] */ uint nIndex, /* [in] __RPC__in_opt */ IWICMetadataWriter pIMetadataWriter);
        
        [PreserveSig]
        HRESULT RemoveWriterByIndex(/* [in] */ uint nIndex);
    }
}

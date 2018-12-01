// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(2110,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// IDWriteRemoteFontFileStream represents a font file stream parts of which may be non-local. Non-local data must be downloaded before it can be accessed using ReadFragment. The interface exposes methods to download font data and query the locality of font data.  <remarks> For more information, see the description of IDWriteRemoteFontFileLoader. </remarks>
    /// </summary>
    [Guid("4db3757a-2c72-4ed9-b2b6-1ababe1aff9c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteRemoteFontFileStream
    {
        [PreserveSig]
        HRESULT GetLocalFileSize(/* _Out_ */ out ulong localFileSize);
        
        [PreserveSig]
        HRESULT GetFileFragmentLocality(ulong fileOffset, ulong fragmentSize, /* _Out_ */ out bool isLocal, /* _Out_range_(0, fragmentSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] ulong[] partialSize);
        
        [PreserveSig]
        DWRITE_LOCALITY GetLocality();
        
        [PreserveSig]
        HRESULT BeginDownload(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid downloadOperationID, /* _In_reads_(fragmentCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FILE_FRAGMENT[] fileFragments, uint fragmentCount, /* _COM_Outptr_result_maybenull_ */ out IDWriteAsyncResult asyncResult);
    }
}

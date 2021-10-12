// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(2110,1)
using System;
using System.Runtime.InteropServices;
using UUID = System.Guid;

namespace DirectN
{
    /// <summary>
    /// IDWriteRemoteFontFileStream represents a font file stream parts of which may be non-local. Non-local data must be downloaded before it can be accessed using ReadFragment. The interface exposes methods to download font data and query the locality of font data.  <remarks> For more information, see the description of IDWriteRemoteFontFileLoader. </remarks>
    /// </summary>
    [ComImport, Guid("4db3757a-2c72-4ed9-b2b6-1ababe1aff9c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteRemoteFontFileStream : IDWriteFontFileStream
    {
        // IDWriteFontFileStream
        [PreserveSig]
        new HRESULT ReadFileFragment(/* _Outptr_result_bytebuffer_(fragmentSize) */ out IntPtr fragmentStart, ulong fileOffset, ulong fragmentSize, /* _Out_ */ out IntPtr fragmentContext);
        
        [PreserveSig]
        new void ReleaseFileFragment(IntPtr fragmentContext);
        
        [PreserveSig]
        new HRESULT GetFileSize(/* _Out_ */ out ulong fileSize);
        
        [PreserveSig]
        new HRESULT GetLastWriteTime(/* _Out_ */ out ulong lastWriteTime);
        
        // IDWriteRemoteFontFileStream
        [PreserveSig]
        HRESULT GetLocalFileSize(/* _Out_ */ out ulong localFileSize);
        
        [PreserveSig]
        HRESULT GetFileFragmentLocality(ulong fileOffset, ulong fragmentSize, /* _Out_ */ out bool isLocal, /* _Out_range_(0, fragmentSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 0)] ulong[] partialSize);
        
        [PreserveSig]
        DWRITE_LOCALITY GetLocality();
        
        [PreserveSig]
        HRESULT BeginDownload(/* _In_ */ ref UUID downloadOperationID, /* _In_reads_(fragmentCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FILE_FRAGMENT[] fileFragments, int fragmentCount, /* _COM_Outptr_result_maybenull_ */ out IDWriteAsyncResult asyncResult);
    }
}

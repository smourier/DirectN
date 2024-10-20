// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A blob containing a UTF-8 encoded string.
    /// </summary>
    [ComImport, Guid("3da636c9-ba71-4024-a301-30cbf125305b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcBlobUtf8 : IDxcBlobEncoding
    {
        // IDxcBlob
        /// <summary>
        /// Retrieves a pointer to the blob's data.
        /// </summary>
        [PreserveSig]
        new IntPtr GetBufferPointer();
        
        /// <summary>
        /// Retrieves the size, in bytes, of the blob's data.
        /// </summary>
        [PreserveSig]
        new IntPtr GetBufferSize();
        
        // IDxcBlobEncoding
        /// <summary>
        /// Retrieve the encoding for this blob.
        /// </summary>
        [PreserveSig]
        new HRESULT GetEncoding(/* _Out_ */ out bool pKnown, /* _Out_ */ out uint pCodePage);
        
        // IDxcBlobUtf8
        /// <summary>
        /// Retrieves a pointer to the string stored in this blob.
        /// </summary>
        [PreserveSig]
        string GetStringPointer();
        
        /// <summary>
        /// Retrieves the length of the string stored in this blob, in characters, excluding the null-terminator.
        /// </summary>
        [PreserveSig]
        IntPtr GetStringLength();
    }
}

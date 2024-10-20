// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A blob containing a null-terminated wide string.
    /// </summary>
    [ComImport, Guid("a3f84eab-0faa-497e-a39c-ee6ed60b2d84"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcBlobWide : IDxcBlobEncoding
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
        
        // IDxcBlobWide
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

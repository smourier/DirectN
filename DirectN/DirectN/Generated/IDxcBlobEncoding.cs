// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A blob that might have a known encoding.
    /// </summary>
    [ComImport, Guid("7241d424-2646-4191-97c0-98e96e42fc68"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcBlobEncoding : IDxcBlob
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
        HRESULT GetEncoding(/* _Out_ */ out bool pKnown, /* _Out_ */ out uint pCodePage);
    }
}

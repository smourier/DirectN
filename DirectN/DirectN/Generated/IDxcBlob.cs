// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A sized buffer that can be passed in and out of DXC APIs.
    /// </summary>
    [ComImport, Guid("8ba5fb08-5195-40e2-ac58-0d989c3a0102"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcBlob
    {
        /// <summary>
        /// Retrieves a pointer to the blob's data.
        /// </summary>
        [PreserveSig]
        IntPtr GetBufferPointer();
        
        /// <summary>
        /// Retrieves the size, in bytes, of the blob's data.
        /// </summary>
        [PreserveSig]
        IntPtr GetBufferSize();
    }
}

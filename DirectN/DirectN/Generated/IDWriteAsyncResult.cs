// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteAsyncResult interface represents the result of an asynchronous operation. A client can use the interface to wait for the operation to complete and to get the result.
    /// </summary>
    [ComImport, Guid("ce25f8fd-863b-4d13-9651-c1f88dc73fe2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteAsyncResult
    {
        [PreserveSig]
        IntPtr GetWaitHandle();
        
        [PreserveSig]
        HRESULT GetResult();
    }
}

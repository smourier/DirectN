// generated from <Windows SDK Path>\um\d2d1effectauthor.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A transform uses this interface to write new vertices to a vertex buffer.
    /// </summary>
    [ComImport, Guid("9b8b1336-00a5-4668-92b7-ced5d8bf9b7b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1VertexBuffer
    {
        [PreserveSig]
        HRESULT Map(/* _Outptr_result_bytebuffer_(bufferSize) */ out IntPtr data, uint bufferSize);
        
        [PreserveSig]
        HRESULT Unmap();
    }
}

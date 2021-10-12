// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wincodec.h(2826,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("135ff860-22b7-4ddf-b0f6-218f4f299a43"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICStream : IStream
    {
        // IStream
        new void Read(byte[] pv, int cb, IntPtr pcbRead);
        new void Write(byte[] pv, int cb, IntPtr pcbWritten);
        new void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition);
        new void SetSize(long libNewSize);
        new void CopyTo(System.Runtime.InteropServices.ComTypes.IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten);
        new void Commit(int grfCommitFlags);
        new void Revert();
        new void LockRegion(long libOffset, long cb, int dwLockType);
        new void UnlockRegion(long libOffset, long cb, int dwLockType);
        new void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag);
        new void Clone(out System.Runtime.InteropServices.ComTypes.IStream ppstm);
        
        // IWICStream
        [PreserveSig]
        HRESULT InitializeFromIStream(/* [in] __RPC__in_opt */ IStream pIStream);
        
        [PreserveSig]
        HRESULT InitializeFromFilename(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string wzFileName, /* [in] */ uint dwDesiredAccess);
        
        [PreserveSig]
        HRESULT InitializeFromMemory(/* [size_is][in] __RPC__in_ecount_full(cbBufferSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbBuffer, /* [in] */ int cbBufferSize);
        
        [PreserveSig]
        HRESULT InitializeFromIStreamRegion(/* [in] __RPC__in_opt */ IStream pIStream, /* [in] */ ulong ulOffset, /* [in] */ ulong ulMaxSize);
    }
}

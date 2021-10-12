// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmcodecdsp.h(5055,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bfccd196-1244-4840-ab44-480975c4ffe4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFileClient
    {
        [PreserveSig]
        HRESULT GetObjectDiskSize(/* [out] */ out ulong pqwSize);
        
        [PreserveSig]
        HRESULT Write(/* [in] */ IFileIo pFio);
        
        [PreserveSig]
        HRESULT Read(/* [in] */ IFileIo pFio);
    }
}

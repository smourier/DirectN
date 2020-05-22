// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmcodecdsp.h(4684,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("11993196-1244-4840-ab44-480975c4ffe4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFileIo
    {
        [PreserveSig]
        HRESULT Initialize(/* [in] */ FILE_ACCESSMODE eAccessMode, /* [in] */ FILE_OPENMODE eOpenMode, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFileName);
        
        [PreserveSig]
        HRESULT GetLength(/* [out] */ out ulong pqwLength);
        
        [PreserveSig]
        HRESULT SetLength(/* [in] */ ulong qwLength);
        
        [PreserveSig]
        HRESULT GetCurrentPosition(/* [out] */ out ulong pqwPosition);
        
        [PreserveSig]
        HRESULT SetCurrentPosition(/* [in] */ ulong qwPosition);
        
        [PreserveSig]
        HRESULT IsEndOfStream(/* [out] */ out bool pbEndOfStream);
        
        [PreserveSig]
        HRESULT Read(/* [in] */ ref byte pbt, /* [in] */ uint ul, /* [out] */ out uint pulRead);
        
        [PreserveSig]
        HRESULT Write(/* [in] */ ref byte pbt, /* [in] */ uint ul, /* [out] */ out uint pulWritten);
        
        [PreserveSig]
        HRESULT Seek(/* [in] */ SEEK_ORIGIN eSeekOrigin, /* [in] */ ulong qwSeekOffset, /* [in] */ uint dwSeekFlags, /* [out] */ out ulong pqwCurrentPosition);
        
        [PreserveSig]
        HRESULT Close();
    }
}

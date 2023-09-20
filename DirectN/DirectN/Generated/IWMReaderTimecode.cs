// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f369e2f0-e081-4fe6-8450-b810b2f410d1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderTimecode
    {
        [PreserveSig]
        HRESULT GetTimecodeRangeCount(/* [in] */ ushort wStreamNum, /* [out] */ out ushort pwRangeCount);
        
        [PreserveSig]
        HRESULT GetTimecodeRangeBounds(/* [in] */ ushort wStreamNum, /* [in] */ ushort wRangeNum, /* [out] */ out uint pStartTimecode, /* [out] */ out uint pEndTimecode);
    }
}

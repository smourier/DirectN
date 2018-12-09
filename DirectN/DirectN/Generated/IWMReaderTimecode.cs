// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(17444,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f369e2f0-e081-4fe6-8450-b810b2f410d1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderTimecode
    {
        [PreserveSig]
        HRESULT GetTimecodeRangeCount(/* [in] */ ushort wStreamNum, /* [out] */ out ushort pwRangeCount);
        
        [PreserveSig]
        HRESULT GetTimecodeRangeBounds(/* [in] */ ushort wStreamNum, /* [in] */ ushort wRangeNum, /* [out] */ out uint pStartTimecode, /* [out] */ out uint pEndTimecode);
    }
}

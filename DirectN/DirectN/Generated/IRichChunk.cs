// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\structuredquerycondition.h(124,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4fdef69c-dbc9-454e-9910-b34f3c64b510"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IRichChunk
    {
        [PreserveSig]
        HRESULT GetData(/* [annotation][unique][out] _Out_opt_ */ out uint pFirstPos, /* [annotation][unique][out] _Out_opt_ */ out uint pLength, /* [annotation][unique][out] _Outptr_opt_result_maybenull_ */ out IntPtr ppsz, /* [annotation][unique][out] _Out_opt_ */ out PropVariant pValue);
    }
}

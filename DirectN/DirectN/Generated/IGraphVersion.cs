// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(8035,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56a868ab-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGraphVersion
    {
        [PreserveSig]
        HRESULT QueryVersion(/* [annotation] _Out_ */ out int pVersion);
    }
}

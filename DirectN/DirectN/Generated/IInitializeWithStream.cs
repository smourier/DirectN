// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(389,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("b824b49d-22ac-4161-ac8a-9916e8fa3f7f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IInitializeWithStream
    {
        [PreserveSig]
        HRESULT Initialize(/* [annotation][in] _In_ */ IStream pstream, /* [annotation][in] _In_ */ uint grfMode);
    }
}

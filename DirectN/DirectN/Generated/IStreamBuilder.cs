// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(7765,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56a868bf-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IStreamBuilder
    {
        [PreserveSig]
        HRESULT Render(/* [in] */ IPin ppinOut, /* [in] */ IGraphBuilder pGraph);
        
        [PreserveSig]
        HRESULT Backout(/* [in] */ IPin ppinOut, /* [in] */ IGraphBuilder pGraph);
    }
}

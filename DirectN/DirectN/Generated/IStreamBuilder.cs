// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a868bf-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IStreamBuilder
    {
        [PreserveSig]
        HRESULT Render(/* [in] */ IPin ppinOut, /* [in] */ IGraphBuilder pGraph);
        
        [PreserveSig]
        HRESULT Backout(/* [in] */ IPin ppinOut, /* [in] */ IGraphBuilder pGraph);
    }
}

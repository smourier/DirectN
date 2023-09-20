// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a868fd-0ad4-11ce-b0a3-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMFilterGraphCallback
    {
        [PreserveSig]
        HRESULT UnableToRender(IPin pPin);
    }
}

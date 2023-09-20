// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a868a5-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IQualityControl
    {
        [PreserveSig]
        HRESULT Notify(/* [in] */ IBaseFilter pSelf, /* [in] */ tagQuality q);
        
        [PreserveSig]
        HRESULT SetSink(/* [in] */ IQualityControl piqc);
    }
}

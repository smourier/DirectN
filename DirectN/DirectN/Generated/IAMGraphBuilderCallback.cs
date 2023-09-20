// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("4995f511-9ddb-4f12-bd3b-f04611807b79"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMGraphBuilderCallback
    {
        [PreserveSig]
        HRESULT SelectedFilter(/* [in] */ IMoniker pMon);
        
        [PreserveSig]
        HRESULT CreatedFilter(/* [in] */ IBaseFilter pFil);
    }
}

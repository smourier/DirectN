// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(17699,5)
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

// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(18422,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6f497062-f2e2-4624-8ea7-9dd40d81fc8d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWatermarkInfo
    {
        [PreserveSig]
        HRESULT GetWatermarkEntryCount(/* [in] */ tagWMT_WATERMARK_ENTRY_TYPE wmetType, /* [out] */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT GetWatermarkEntry(/* [in] */ tagWMT_WATERMARK_ENTRY_TYPE wmetType, /* [in] */ uint dwEntryNum, /* [out] */ out __WMT_WATERMARK_ENTRY pEntry);
    }
}

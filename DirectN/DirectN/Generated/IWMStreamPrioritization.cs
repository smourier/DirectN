// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(8323,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8c1c6090-f9a8-4748-8ec3-dd1108ba1e77"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMStreamPrioritization
    {
        [PreserveSig]
        HRESULT GetPriorityRecords(/* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] _WMStreamPrioritizationRecord[] pRecordArray, /* [out][in] */ ref ushort pcRecords);
        
        [PreserveSig]
        HRESULT SetPriorityRecords(/* [in] */ ref _WMStreamPrioritizationRecord pRecordArray, /* [in] */ ushort cRecords);
    }
}

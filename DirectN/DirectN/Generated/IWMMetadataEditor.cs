// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(4676,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("96406bd9-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMMetadataEditor
    {
        [PreserveSig]
        HRESULT Open(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFilename);
        
        [PreserveSig]
        HRESULT Close();
        
        [PreserveSig]
        HRESULT Flush();
    }
}

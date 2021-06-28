// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(4772,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("203cffe3-2e18-4fdf-b59d-6e71530534cf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMMetadataEditor2 : IWMMetadataEditor
    {
        // IWMMetadataEditor
        [PreserveSig]
        new HRESULT Open(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFilename);
        
        [PreserveSig]
        new HRESULT Close();
        
        [PreserveSig]
        new HRESULT Flush();
        
        // IWMMetadataEditor2
        [PreserveSig]
        HRESULT OpenEx(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFilename, /* [in] */ uint dwDesiredAccess, /* [in] */ uint dwShareMode);
    }
}

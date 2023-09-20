// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406bd9-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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

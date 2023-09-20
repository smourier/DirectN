// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ba4dcc78-7ee0-4ab8-b27a-dbce8bc51454"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMProfileManagerLanguage
    {
        [PreserveSig]
        HRESULT GetUserLanguageID(ref ushort wLangID);
        
        [PreserveSig]
        HRESULT SetUserLanguageID(ushort wLangID);
    }
}

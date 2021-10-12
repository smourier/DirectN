// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(1367,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a collection of strings indexed by locale name.
    /// </summary>
    [ComImport, Guid("08256209-099a-4b34-b86d-c22b110e7771"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteLocalizedStrings
    {
        [PreserveSig]
        uint GetCount();
        
        [PreserveSig]
        HRESULT FindLocaleName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, /* _Out_ */ out uint index, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        HRESULT GetLocaleNameLength(uint index, /* _Out_ */ out uint length);
        
        [PreserveSig]
        HRESULT GetLocaleName(uint index, /* _Out_writes_z_(size) */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, uint size);
        
        [PreserveSig]
        HRESULT GetStringLength(uint index, /* _Out_ */ out uint length);
        
        [PreserveSig]
        HRESULT GetString(uint index, /* _Out_writes_z_(size) */ [MarshalAs(UnmanagedType.LPWStr)] string stringBuffer, uint size);
    }
}

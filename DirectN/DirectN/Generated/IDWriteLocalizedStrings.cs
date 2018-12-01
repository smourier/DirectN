// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(1367,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("08256209-099a-4b34-b86d-c22b110e7771"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteLocalizedStrings
    {
        [PreserveSig]
        uint GetCount();
        
        [PreserveSig]
        HRESULT FindLocaleName(/* _In_z_ */ ref char localeName, /* _Out_ */ out uint index, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        HRESULT GetLocaleNameLength(uint index, /* _Out_ */ out uint length);
        
        [PreserveSig]
        HRESULT GetLocaleName(uint index, /* _Out_writes_z_(size) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] char[] localeName, uint size);
        
        [PreserveSig]
        HRESULT GetStringLength(uint index, /* _Out_ */ out uint length);
        
        [PreserveSig]
        HRESULT GetString(uint index, /* _Out_writes_z_(size) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] char[] stringBuffer, uint size);
    }
}

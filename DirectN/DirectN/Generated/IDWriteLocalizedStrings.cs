using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("08256209-099a-4b34-b86d-c22b110e7771"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDWriteLocalizedStrings
    {
        [PreserveSig]
        int GetCount();

        [PreserveSig]
        HRESULT FindLocaleName([MarshalAs(UnmanagedType.LPWStr)] string localeName, out int index, out bool exists);

        [PreserveSig]
        HRESULT GetLocaleNameLength(int index, out int length);

        [PreserveSig]
        HRESULT GetLocaleName(int index, [MarshalAs(UnmanagedType.LPWStr)] string localeName, int size);

        [PreserveSig]
        HRESULT GetStringLength(int index, out int length);

        [PreserveSig]
        HRESULT GetString(int index, [MarshalAs(UnmanagedType.LPWStr)] string stringBuffer, int size);
    }
}

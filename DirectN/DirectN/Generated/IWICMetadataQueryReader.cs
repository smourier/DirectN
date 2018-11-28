using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("30989668-E1C9-4597-B395-458EEDB808DF"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICMetadataQueryReader
    {
        [PreserveSig]
        HRESULT GetContainerFormat(out Guid pguidContainerFormat);

        [PreserveSig]
        HRESULT GetLocation(int cchMaxLength, [In, Out, MarshalAs(UnmanagedType.LPWStr)] string wzNamespace, out int pcchActualLength);

        [PreserveSig]
        HRESULT GetMetadataByName(string wzName, [In, Out] PropVariant pvarValue);

        [PreserveSig]
        HRESULT GetEnumerator(out IEnumString ppIEnumString);
    }
}

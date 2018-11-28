using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("A721791A-0DEF-4d06-BD91-2118BF1DB10B"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICMetadataQueryWriter : IWICMetadataQueryReader
    {
        // IWICMetadataQueryReader
        [PreserveSig]
        new HRESULT GetContainerFormat(out Guid pguidContainerFormat);

        [PreserveSig]
        new HRESULT GetLocation(int cchMaxLength, [In, Out, MarshalAs(UnmanagedType.LPWStr)] string wzNamespace, out int pcchActualLength);

        [PreserveSig]
        new HRESULT GetMetadataByName(string wzName, [In, Out] PropVariant pvarValue);

        [PreserveSig]
        new HRESULT GetEnumerator(out IEnumString ppIEnumString);

        // IWICMetadataQueryWriter
        [PreserveSig]
        HRESULT SetMetadataByName([MarshalAs(UnmanagedType.LPWStr)] string wzName, PropVariant pvarValue);

        [PreserveSig]
        HRESULT RemoveMetadataByName([MarshalAs(UnmanagedType.LPWStr)] string wzName);
    }
}

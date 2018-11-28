using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("5BC8A76B-869A-46a3-9B03-FA218A66AEBE"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFCollection
    {
        [PreserveSig]
        HRESULT GetElementCount(out int pcElements);

        [PreserveSig]
        HRESULT GetElement(int dwElementIndex, [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkElement);

        [PreserveSig]
        HRESULT AddElement([MarshalAs(UnmanagedType.IUnknown)] object pUnkElement);

        [PreserveSig]
        HRESULT RemoveElement(int dwElementIndex, [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkElement);

        [PreserveSig]
        HRESULT InsertElementAt(int dwIndex, [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

        [PreserveSig]
        HRESULT RemoveAllElements();
    }
}

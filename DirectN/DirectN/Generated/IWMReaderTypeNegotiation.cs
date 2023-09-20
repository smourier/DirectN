// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fdbe5592-81a1-41ea-93bd-735cad1adc05"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderTypeNegotiation
    {
        [PreserveSig]
        HRESULT TryOutputProps(/* [in] */ uint dwOutputNum, /* [in] */ IWMOutputMediaProps pOutput);
    }
}

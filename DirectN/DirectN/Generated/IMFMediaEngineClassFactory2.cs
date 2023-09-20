// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("09083cef-867f-4bf6-8776-dee3a7b42fca"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineClassFactory2
    {
        [PreserveSig]
        HRESULT CreateMediaKeys2(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.BStr)] string keySystem, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.BStr)] string defaultCdmStorePath, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string inprivateCdmStorePath, /* [annotation] _COM_Outptr_ */ out IMFMediaKeys ppKeys);
    }
}

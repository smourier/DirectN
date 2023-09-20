// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406bd4-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriter
    {
        [PreserveSig]
        HRESULT SetProfileByID(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidProfile);
        
        [PreserveSig]
        HRESULT SetProfile(/* [in] */ IWMProfile pProfile);
        
        [PreserveSig]
        HRESULT SetOutputFilename(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFilename);
        
        [PreserveSig]
        HRESULT GetInputCount(/* [out] */ out uint pcInputs);
        
        [PreserveSig]
        HRESULT GetInputProps(/* [in] */ uint dwInputNum, /* [out] */ out IWMInputMediaProps ppInput);
        
        [PreserveSig]
        HRESULT SetInputProps(/* [in] */ uint dwInputNum, /* [in] */ IWMInputMediaProps pInput);
        
        [PreserveSig]
        HRESULT GetInputFormatCount(/* [in] */ uint dwInputNumber, /* [out] */ out uint pcFormats);
        
        [PreserveSig]
        HRESULT GetInputFormat(/* [in] */ uint dwInputNumber, /* [in] */ uint dwFormatNumber, /* [out] */ out IWMInputMediaProps pProps);
        
        [PreserveSig]
        HRESULT BeginWriting();
        
        [PreserveSig]
        HRESULT EndWriting();
        
        [PreserveSig]
        HRESULT AllocateSample(/* [in] */ uint dwSampleSize, /* [out] */ out INSSBuffer ppSample);
        
        [PreserveSig]
        HRESULT WriteSample(/* [in] */ uint dwInputNum, /* [in] */ ulong cnsSampleTime, /* [in] */ uint dwFlags, /* [in] */ INSSBuffer pSample);
        
        [PreserveSig]
        HRESULT Flush();
    }
}

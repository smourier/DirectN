// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fc54a285-38c4-45b5-aa23-85b9f7cb424b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriterPreprocess
    {
        [PreserveSig]
        HRESULT GetMaxPreprocessingPasses(/* [in] */ uint dwInputNum, /* [in] */ uint dwFlags, /* [out] */ out uint pdwMaxNumPasses);
        
        [PreserveSig]
        HRESULT SetNumPreprocessingPasses(/* [in] */ uint dwInputNum, /* [in] */ uint dwFlags, /* [in] */ uint dwNumPasses);
        
        [PreserveSig]
        HRESULT BeginPreprocessingPass(/* [in] */ uint dwInputNum, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT PreprocessSample(/* [in] */ uint dwInputNum, /* [in] */ ulong cnsSampleTime, /* [in] */ uint dwFlags, /* [in] */ INSSBuffer pSample);
        
        [PreserveSig]
        HRESULT EndPreprocessingPass(/* [in] */ uint dwInputNum, /* [in] */ uint dwFlags);
    }
}

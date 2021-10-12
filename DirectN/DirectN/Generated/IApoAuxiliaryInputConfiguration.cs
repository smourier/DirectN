// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioenginebaseapo.h(1149,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4ceb0aab-fa19-48ed-a857-87771ae1b768"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IApoAuxiliaryInputConfiguration
    {
        [PreserveSig]
        HRESULT AddAuxiliaryInput(/* [in] */ uint dwInputId, /* [in] */ uint cbDataSize, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pbyData, /* [annotation][in] _In_ */ ref APO_CONNECTION_DESCRIPTOR pInputConnection);
        
        [PreserveSig]
        HRESULT RemoveAuxiliaryInput(/* [in] */ uint dwInputId);
        
        [PreserveSig]
        HRESULT IsInputFormatSupported(/* [in] */ IAudioMediaType pRequestedInputFormat, /* [out] */ out IAudioMediaType ppSupportedInputFormat);
    }
}

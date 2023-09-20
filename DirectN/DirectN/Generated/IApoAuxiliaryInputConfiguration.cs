// generated from <Windows SDK Path>\um\audioenginebaseapo.h
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

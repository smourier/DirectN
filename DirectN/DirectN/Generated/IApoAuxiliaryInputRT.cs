// generated from <Windows SDK Path>\um\audioenginebaseapo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f851809c-c177-49a0-b1b2-b66f017943ab"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IApoAuxiliaryInputRT
    {
        [PreserveSig]
        void AcceptInput(/* [annotation][in] _In_ */ uint dwInputId, /* [annotation][in] _In_ */ ref APO_CONNECTION_PROPERTY pInputConnection);
    }
}

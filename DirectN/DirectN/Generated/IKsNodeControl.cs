// generated from <Windows SDK Path>\um\vidcap.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("11737c14-24a7-4bb5-81a0-0d003813b0c4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsNodeControl
    {
        [PreserveSig]
        HRESULT put_NodeId(/* [in] */ uint dwNodeId);
        
        [PreserveSig]
        HRESULT put_KsControl(/* [in] */ IntPtr pKsControl);
    }
}

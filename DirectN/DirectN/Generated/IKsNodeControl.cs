// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\vidcap.h(1787,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("11737c14-24a7-4bb5-81a0-0d003813b0c4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsNodeControl
    {
        [PreserveSig]
        HRESULT put_NodeId(/* [in] */ uint dwNodeId);
        
        [PreserveSig]
        HRESULT put_KsControl(/* [in] */ IntPtr pKsControl);
    }
}

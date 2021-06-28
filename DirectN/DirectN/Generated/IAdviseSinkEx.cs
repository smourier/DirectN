// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ocidl.h(6324,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("3af24290-0c96-11ce-a0cf-00aa00600ab8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAdviseSinkEx : IAdviseSink
    {
        [PreserveSig]
        void OnViewStatusChange(/* [in] */ uint dwViewStatus);
    }
}

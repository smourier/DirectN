using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fabea3fc-b108-45b6-a9fc-8d08fa9f85cf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInkCommitRequestHandler
    {
        [PreserveSig]
        HRESULT OnCommitRequested();
    }
}

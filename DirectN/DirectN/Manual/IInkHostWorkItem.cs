using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ccda0a9a-1b78-4632-bb96-97800662e26c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInkHostWorkItem
    {
        [PreserveSig]
        HRESULT Invoke();
    }
}

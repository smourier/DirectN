// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmcodecdsp.h(2859,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7b12e5d1-bd22-48ea-bc06-98e893221c89"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMInterlaceProps
    {
        [PreserveSig]
        HRESULT SetProcessType(/* [in] */ int iProcessType);
        
        [PreserveSig]
        HRESULT SetInitInverseTeleCinePattern(/* [in] */ int iInitPattern);
        
        [PreserveSig]
        HRESULT SetLastFrame();
    }
}

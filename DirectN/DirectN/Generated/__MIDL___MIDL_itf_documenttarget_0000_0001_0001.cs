// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\documenttarget.h(254,32)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __MIDL___MIDL_itf_documenttarget_0000_0001_0001
    {
        public uint JobId;
        public int CurrentDocument;
        public int CurrentPage;
        public int CurrentPageTotal;
        public PrintDocumentPackageCompletion Completion;
        public HRESULT PackageStatus;
    }
}

// generated from <Windows SDK Path>\um\documenttarget.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __MIDL___MIDL_itf_documenttarget_0000_0002_0001
    {
        public uint JobId;
        public int CurrentDocument;
        public int CurrentPage;
        public int CurrentPageTotal;
        public PrintDocumentPackageCompletion Completion;
        public HRESULT PackageStatus;
    }
}

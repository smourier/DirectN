using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3127CA40-446E-11CE-8135-00AA004BB851"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IErrorLog
    {
        void AddError([MarshalAs(UnmanagedType.LPWStr)] string pszPropName, tagEXCEPINFO pExcepInfo);
    }
}

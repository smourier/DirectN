// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmiutils.h(1051,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tag_SWbemRpnQueryToken
    {
        public uint m_uVersion;
        public uint m_uTokenType;
        public uint m_uSubexpressionShape;
        public uint m_uOperator;
        public IntPtr m_pRightIdent;
        public IntPtr m_pLeftIdent;
        public uint m_uConstApparentType;
        public tag_SWbemRpnConst m_Const;
        public uint m_uConst2ApparentType;
        public tag_SWbemRpnConst m_Const2;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string m_pszRightFunc;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string m_pszLeftFunc;
    }
}

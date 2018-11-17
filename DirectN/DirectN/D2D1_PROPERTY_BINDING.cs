using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_PROPERTY_BINDING
    {
        [MarshalAs(UnmanagedType.LPWStr)]
        public string propertyName;
        public PD2D1_PROPERTY_SET_FUNCTION setFunction;
        public PD2D1_PROPERTY_GET_FUNCTION getFunction;
    }
}

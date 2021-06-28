// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effectauthor.h(252,9)
using System;
using System.Runtime.InteropServices;
using PD2D1_PROPERTY_GET_FUNCTION = System.IntPtr;
using PD2D1_PROPERTY_SET_FUNCTION = System.IntPtr;

namespace DirectN
{
    /// <summary>
    /// Defines a property binding to a function. The name must match the property defined in the registration schema.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_PROPERTY_BINDING
    {
        /// <summary>
        /// The name of the property.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string propertyName;
        /// <summary>
        /// The function that will receive the data to set.
        /// </summary>
        public IntPtr setFunction;
        /// <summary>
        /// The function that will be asked to write the output data.
        /// </summary>
        public IntPtr getFunction;
    }
}

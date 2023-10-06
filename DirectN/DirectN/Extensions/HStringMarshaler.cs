using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public sealed class HStringMarshaler : ICustomMarshaler
    {
        public static readonly HStringMarshaler Instance = new HStringMarshaler();

        // *must* exist for a custom marshaler
        public static ICustomMarshaler GetInstance(string cookie) => Instance;

        public void CleanUpManagedData(object managedObj)
        {
            // nothing to do
        }

        public void CleanUpNativeData(IntPtr nativeData)
        {
            if (nativeData != IntPtr.Zero)
            {
                WindowsDeleteString(nativeData).ThrowOnError();
            }
        }

        public int GetNativeDataSize() => -1;

        public IntPtr MarshalManagedToNative(object managedObj)
        {
            if (managedObj == null)
                return IntPtr.Zero;

            var str = (string)managedObj;
            WindowsCreateString(str, str.Length, out var ptr).ThrowOnError();
            return ptr;
        }

        public object MarshalNativeToManaged(IntPtr nativeData)
        {
            if (nativeData == IntPtr.Zero)
                return null;

            var ptr = WindowsGetStringRawBuffer(nativeData, out var length);
            if (ptr == IntPtr.Zero)
                return null;

            if (length == 0)
                return string.Empty;

            return Marshal.PtrToStringUni(ptr, length);
        }

        [DllImport("api-ms-win-core-winrt-string-l1-1-0.dll")]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        private static extern HRESULT WindowsCreateString([MarshalAs(UnmanagedType.LPWStr)] string sourceString, int length, out IntPtr @string);

        [DllImport("api-ms-win-core-winrt-string-l1-1-0.dll")]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        private static extern HRESULT WindowsDeleteString(IntPtr @string);

        [DllImport("api-ms-win-core-winrt-string-l1-1-0.dll")]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        private static extern IntPtr WindowsGetStringRawBuffer(IntPtr @string, out int length);
    }
}

using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class DWriteFunctions
    {
        [DllImport("DWrite")]
        public static extern HRESULT DWriteCreateFactory(DWRITE_FACTORY_TYPE factoryType, [MarshalAs(UnmanagedType.LPStruct)] Guid iid, [MarshalAs(UnmanagedType.IUnknown)] out object factory);

        public static ComObject<T> DWriteCreateFactory<T>(DWRITE_FACTORY_TYPE type = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) where T : IDWriteFactory
        {
            DWriteCreateFactory(type, typeof(T).GUID, out object factory).ThrowOnError();
            return new ComObject<T>((T)factory);
        }
    }
}

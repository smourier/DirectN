using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class DWriteFunctions
    {
        [DllImport("DWrite", ExactSpelling = true)]
        public static extern HRESULT DWriteCreateFactory(DWRITE_FACTORY_TYPE factoryType, [MarshalAs(UnmanagedType.LPStruct)] Guid iid, [MarshalAs(UnmanagedType.IUnknown)] out object factory);

        public static IComObject<IDWriteFactory> DWriteCreateFactory(DWRITE_FACTORY_TYPE type = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) => DWriteCreateFactory<IDWriteFactory>(type);
        public static IComObject<T> DWriteCreateFactory<T>(DWRITE_FACTORY_TYPE type = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) where T : IDWriteFactory
        {
            DWriteCreateFactory(type, typeof(T).GUID, out object factory).ThrowOnError();
            return new ComObject<T>((T)factory);
        }

        public static IComObject<IDWriteFactory5> DWriteCreateFactory5(DWRITE_FACTORY_TYPE type = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) => DWriteCreateFactory5<IDWriteFactory5>(type);
        public static IComObject<T> DWriteCreateFactory5<T>(DWRITE_FACTORY_TYPE type = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) where T : IDWriteFactory5
        {
            DWriteCreateFactory(type, typeof(T).GUID, out object factory);
            if (factory == null)
                return null;  // win8

            return new ComObject<T>((T)factory);
        }
    }
}

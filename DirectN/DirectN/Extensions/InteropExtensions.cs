using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class InteropExtensions
    {
        private static readonly Lazy<ConcurrentDictionary<Guid, string>> _guids = new Lazy<ConcurrentDictionary<Guid, string>>(ExtractAllGuids, true);

        public static ComMemory StructureToMemory(this object structure) => new ComMemory(structure);

        public static IntPtr StructureToPtr(this object structure)
        {
            if (structure == null)
                return IntPtr.Zero;

            int size = Marshal.SizeOf(structure);
            var ptr = Marshal.AllocCoTaskMem(size);
            Marshal.StructureToPtr(structure, ptr, false);
            return ptr;
        }

        public static IntPtr StructureToPtr<T>(this T structure)
        {
            if (structure == null)
                return IntPtr.Zero;

            int size = Marshal.SizeOf<T>();
            var ptr = Marshal.AllocCoTaskMem(size);
            Marshal.StructureToPtr<T>(structure, ptr, false);
            return ptr;
        }

        public static byte[] StructureToBytes(this object structure)
        {
            var bytes = new byte[Marshal.SizeOf(structure)];
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            Marshal.StructureToPtr(structure, handle.AddrOfPinnedObject(), false);
            handle.Free();
            return bytes;
        }

        public static byte[] StructureToBytes<T>(this T structure) where T : struct
        {
            var bytes = new byte[Marshal.SizeOf<T>()];
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                Marshal.StructureToPtr(structure, handle.AddrOfPinnedObject(), false);
                return bytes;
            }
            finally
            {
                handle.Free();
            }
        }

        public static object BytesToStructure(this byte[] bytes, Type structureType)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            if (structureType == null)
                throw new ArgumentNullException(nameof(structureType));

            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                return Marshal.PtrToStructure(handle.AddrOfPinnedObject(), structureType);
            }
            finally
            {
                handle.Free();
            }
        }

        public static T BytesToStructure<T>(this byte[] bytes) where T : struct
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                return Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());
            }
            finally
            {
                handle.Free();
            }
        }

        public static IntPtr BytesToIntPtr(this byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            if (bytes.Length != IntPtr.Size)
                throw new ArgumentException(null, nameof(bytes));

            if (IntPtr.Size == 4)
            {
                var i = BitConverter.ToInt32(bytes, 0);
                return new IntPtr(i);
            }

            var l = BitConverter.ToInt64(bytes, 0);
            return new IntPtr(l);
        }

        public static byte[] IntPtrToBytes(this IntPtr ptr)
        {
            if (IntPtr.Size == 4)
                return BitConverter.GetBytes(ptr.ToInt32());

            return BitConverter.GetBytes(ptr.ToInt64());
        }

        public static string ToName(this Guid guid, string formatIfNotFound = null)
        {
            if (guid == Guid.Empty)
                return nameof(Guid.Empty);

            if (_guids.Value.TryGetValue(guid, out string name))
                return name;

            if (FourCC.IsFourCC(guid))
            {
                name = FourCC.ToString(guid);
                _guids.Value.AddOrUpdate(guid, name, (k, old) => old);
                return name;
            }

            return guid.ToString(formatIfNotFound);
        }

        private static ConcurrentDictionary<Guid, string> ExtractAllGuids()
        {
            var dic = new ConcurrentDictionary<Guid, string>();
            foreach (var type in typeof(InteropExtensions).Assembly.GetTypes())
            {
                // ids
                var att = type.GetCustomAttribute<InterfaceTypeAttribute>();
                if (att != null)
                {
                    dic[type.GUID] = "IID_" + type.Name;
                }

                // constants
                foreach (var field in type.GetFields(BindingFlags.Static | BindingFlags.Public))
                {
                    if (field.FieldType == typeof(Guid))
                    {
                        dic[(Guid)field.GetValue(null)] = field.Name;
                    }
                }
            }
            return dic;
        }

        public static string ToStringUni(this IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return null;

            return Marshal.PtrToStringUni(ptr);
        }

        public static string ToStringUni(this IntPtr ptr, int len)
        {
            if (ptr == IntPtr.Zero)
                return null;

            return Marshal.PtrToStringUni(ptr, len);
        }
    }
}

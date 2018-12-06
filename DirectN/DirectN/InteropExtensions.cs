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
    }
}

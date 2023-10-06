using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class ID3D12ObjectExtensions
    {
        public static void SetName(this IComObject<ID3D12Object> obj, string name) => SetName(obj?.Object, name);
        public static void SetName(this ID3D12Object obj, string name)
        {
            obj.SetName(name).ThrowOnError();
        }

        public static void SetPrivateData(this IComObject<ID3D12Object> obj, Guid guid, uint dataSize, IntPtr data) => SetPrivateData(obj?.Object, guid, dataSize, data);
        public static void SetPrivateData(this ID3D12Object obj, Guid guid, uint dataSize, IntPtr data)
        {
            obj.SetPrivateData(guid, dataSize, data).ThrowOnError();
        }

        public static void SetPrivateDataInterface(this IComObject<ID3D12Object> obj, Guid guid, IntPtr data) => SetPrivateDataInterface(obj?.Object, guid, data);
        public static void SetPrivateDataInterface(this ID3D12Object obj, Guid guid, IntPtr data)
        {
            obj.SetPrivateDataInterface(guid, data).ThrowOnError();
        }

        public static IComObject<ID3D12Device> GetDevice(this IComObject<ID3D12DeviceChild> child) => GetDevice<ID3D12Device>(child?.Object);
        public static IComObject<ID3D12Device> GetDevice(this ID3D12DeviceChild child) => GetDevice<ID3D12Device>(child);
        public static IComObject<T> GetDevice<T>(this IComObject<ID3D12DeviceChild> child) where T : ID3D12Device => GetDevice<T>(child?.Object);
        public static IComObject<T> GetDevice<T>(this ID3D12DeviceChild child) where T : ID3D12Device
        {
            if (child == null)
                throw new ArgumentNullException(nameof(child));

            child.GetDevice(typeof(T).GUID, out var device).ThrowOnError();
            return new ComObject<T>((T)device);
        }

        public static D3D12_HEAP_PROPERTIES GetHeapProperties(this IComObject<ID3D12Resource> resource) => GetHeapProperties(resource?.Object);
        public static D3D12_HEAP_PROPERTIES GetHeapProperties(this ID3D12Resource resource)
        {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            using (var mem = new ComMemory(Marshal.SizeOf<D3D12_HEAP_PROPERTIES>()))
            {
                resource.GetHeapProperties(mem.Pointer, IntPtr.Zero);
                return mem.ToStructure<D3D12_HEAP_PROPERTIES>();
            }
        }

        public static D3D12_HEAP_FLAGS GetHeapFlags(this IComObject<ID3D12Resource> resource) => GetHeapFlags(resource?.Object);
        public static D3D12_HEAP_FLAGS GetHeapFlags(this ID3D12Resource resource)
        {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            using (var mem = new ComMemory(Marshal.SizeOf<D3D12_HEAP_FLAGS>()))
            {
                resource.GetHeapProperties(IntPtr.Zero, mem.Pointer);
                return mem.ToStructure<D3D12_HEAP_FLAGS>();
            }
        }

        public static ulong GetGPUVirtualAddress(this IComObject<ID3D12Resource> resource) => GetGPUVirtualAddress(resource?.Object);
        public static ulong GetGPUVirtualAddress(this ID3D12Resource resource)
        {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            return resource.GetGPUVirtualAddress();
        }

        public static D3D12_RESOURCE_DESC GetDesc(this IComObject<ID3D12Resource> resource) => GetDesc(resource?.Object);
        public static D3D12_RESOURCE_DESC GetDesc(this ID3D12Resource resource)
        {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            resource.GetDesc(out var desc);
            return desc;
        }

        public static IntPtr Map(this IComObject<ID3D12Resource> resource, uint subresource, D3D12_RANGE? readRange = null) => Map(resource?.Object, subresource, readRange);
        public static IntPtr Map(this ID3D12Resource resource, uint subresource, D3D12_RANGE? readRange = null)
        {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            using (var mem = new ComMemory(readRange))
            {
                resource.Map(subresource, mem.Pointer, out var data).ThrowOnError();
                return data;
            }
        }

        public static void Unmap(this IComObject<ID3D12Resource> resource, uint subresource, D3D12_RANGE? writtenRange = null) => Unmap(resource?.Object, subresource, writtenRange);
        public static void Unmap(this ID3D12Resource resource, uint subresource, D3D12_RANGE? writtenRange = null)
        {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            using (var mem = new ComMemory(writtenRange))
            {
                resource.Unmap(subresource, mem.Pointer);
            }
        }

        public static void WithMap(this IComObject<ID3D12Resource> resource, uint subresource, Action<IntPtr> action, D3D12_RANGE? readRange = null, D3D12_RANGE? writtenRange = null) => WithMap(resource?.Object, subresource, action, readRange, writtenRange);
        public static void WithMap(this ID3D12Resource resource, uint subresource, Action<IntPtr> action, D3D12_RANGE? readRange = null, D3D12_RANGE? writtenRange = null)
        {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var ptr = resource.Map(subresource, readRange);
            try
            {
                action(ptr);
            }
            finally
            {
                resource.Unmap(subresource, writtenRange);
            }
        }

        public static T WithMap<T>(this IComObject<ID3D12Resource> resource, uint subresource, Func<IntPtr, T> func, D3D12_RANGE? readRange = null, D3D12_RANGE? writtenRange = null) => WithMap(resource?.Object, subresource, func, readRange, writtenRange);
        public static T WithMap<T>(this ID3D12Resource resource, uint subresource, Func<IntPtr, T> func, D3D12_RANGE? readRange = null, D3D12_RANGE? writtenRange = null)
        {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            if (func == null)
                throw new ArgumentNullException(nameof(func));

            var ptr = resource.Map(subresource, readRange);
            try
            {
                return func(ptr);
            }
            finally
            {
                resource.Unmap(subresource, writtenRange);
            }
        }

        public static void WriteToSubresource(this IComObject<ID3D12Resource> resource, uint subresource, IntPtr srcData, uint srcRowPitch, uint srcDepthPitch, D3D12_BOX? dstBox = null) => WriteToSubresource(resource?.Object, subresource, srcData, srcRowPitch, srcDepthPitch, dstBox);
        public static void WriteToSubresource(this ID3D12Resource resource, uint subresource, IntPtr srcData, uint srcRowPitch, uint srcDepthPitch, D3D12_BOX? dstBox = null)
        {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            using (var mem = new ComMemory(dstBox))
            {
                resource.WriteToSubresource(subresource, mem.Pointer, srcData, srcRowPitch, srcDepthPitch).ThrowOnError();
            }
        }

        public static void ReadFromSubresource(this IComObject<ID3D12Resource> resource, IntPtr dstData, uint dstRowPitch, uint dstDepthPitch, uint srcSubresource, D3D12_BOX? dstBox = null) => ReadFromSubresource(resource?.Object, dstData, dstRowPitch, dstDepthPitch, srcSubresource, dstBox);
        public static void ReadFromSubresource(this ID3D12Resource resource, IntPtr dstData, uint dstRowPitch, uint dstDepthPitch, uint srcSubresource, D3D12_BOX? dstBox = null)
        {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            using (var mem = new ComMemory(dstBox))
            {
                resource.ReadFromSubresource(dstData, dstRowPitch, dstDepthPitch, srcSubresource, mem.Pointer).ThrowOnError();
            }
        }

        public static void Reset(this IComObject<ID3D12CommandAllocator> resource) => Reset(resource?.Object);
        public static void Reset(this ID3D12CommandAllocator allocator)
        {
            if (allocator == null)
                throw new ArgumentNullException(nameof(allocator));

            allocator.Reset().ThrowOnError();
        }
    }
}

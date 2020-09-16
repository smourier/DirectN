using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class ID3D11DeviceContextExtensions
    {
        public delegate void MapAction<T>(ref D3D11_MAPPED_SUBRESOURCE mapped, ref T structure);

        public static void WithMap<T>(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, MapAction<T> action, D3D11_MAP_FLAG mapFlag = 0)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var map = Map(context, resource, subResource, mapType, mapFlag);
            try
            {
                var structure = Marshal.PtrToStructure<T>(map.pData);
                action(ref map, ref structure);
                Marshal.StructureToPtr(structure, map.pData, false);
            }
            finally
            {
                Unmap(context, resource, subResource);
            }
        }

        public static D3D11_MAPPED_SUBRESOURCE Map(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, D3D11_MAP_FLAG mapFlag = 0) => Map(context?.Object, resource?.Object, subResource, mapType, mapFlag);
        public static D3D11_MAPPED_SUBRESOURCE Map(this ID3D11DeviceContext context, ID3D11Resource resource, int subResource, D3D11_MAP mapType, D3D11_MAP_FLAG mapFlag = 0)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            using (var ptr = new ComMemory(Marshal.SizeOf<D3D11_MAPPED_SUBRESOURCE>()))
            {
                context.Map(resource, (uint)subResource, mapType, (uint)mapFlag, ptr.Pointer).ThrowOnError();
                return ptr.ToStructure<D3D11_MAPPED_SUBRESOURCE>();
            }
        }

        public static void Unmap(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource) => Unmap(context?.Object, resource?.Object, subResource);
        public static void Unmap(this ID3D11DeviceContext context, ID3D11Resource resource, int subResource)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            context.Unmap(resource, (uint)subResource);
        }
    }
}

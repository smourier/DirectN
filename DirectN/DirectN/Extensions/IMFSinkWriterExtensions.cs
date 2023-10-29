using System;

namespace DirectN
{
    public static class IMFSinkWriterExtensions
    {
        public static IComObject<T> GetServiceForStream<T>(this IComObject<IMFSinkWriter> obj, uint streamIndex) => GetServiceForStream<T>(obj?.Object, streamIndex, Guid.Empty, typeof(T).GUID);
        public static IComObject<T> GetServiceForStream<T>(this IComObject<IMFSinkWriter> obj, uint streamIndex, Guid serviceId, Guid interfaceId) => GetServiceForStream<T>(obj?.Object, streamIndex, serviceId, interfaceId);
        public static IComObject<T> GetServiceForStream<T>(this IMFSinkWriter obj, uint streamIndex) => GetServiceForStream<T>(obj, streamIndex, Guid.Empty, typeof(T).GUID);
        public static IComObject<T> GetServiceForStream<T>(this IMFSinkWriter obj, uint streamIndex, Guid serviceId, Guid interfaceId)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetServiceForStream(streamIndex, serviceId, interfaceId, out var ppv).IsError)
                return null;

            return new ComObject<T>((T)ppv);
        }
    }
}

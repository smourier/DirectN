using System;

namespace DirectN
{
    public static class IMFSinkWriterExtensions
    {
        public static ComObject<T> GetServiceForStream<T>(this ComObject<IMFSinkWriter> obj, int streamIndex) => GetServiceForStream<T>(obj?.Object, streamIndex, Guid.Empty, typeof(T).GUID);
        public static ComObject<T> GetServiceForStream<T>(this ComObject<IMFSinkWriter> obj, int streamIndex, Guid serviceId, Guid interfaceId) => GetServiceForStream<T>(obj?.Object, streamIndex, serviceId, interfaceId);
        public static ComObject<T> GetServiceForStream<T>(this IMFSinkWriter obj, int streamIndex) => GetServiceForStream<T>(obj, streamIndex, Guid.Empty, typeof(T).GUID);
        public static ComObject<T> GetServiceForStream<T>(this IMFSinkWriter obj, int streamIndex, Guid serviceId, Guid interfaceId)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetServiceForStream(streamIndex, serviceId, interfaceId, out var ppv).IsError)
                return null;

            return new ComObject<T>((T)ppv);
        }
    }
}

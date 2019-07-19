using System;

namespace DirectN
{
    public static class IMFSinkWriterExtensions
    {
        public static ComObject<T> GetServiceForStream<T>(this ComObject<IMFSinkWriter> input, uint streamIndex) => GetServiceForStream<T>(input?.Object, streamIndex, Guid.Empty, typeof(T).GUID);
        public static ComObject<T> GetServiceForStream<T>(this ComObject<IMFSinkWriter> input, uint streamIndex, Guid serviceId, Guid interfaceId) => GetServiceForStream<T>(input?.Object, streamIndex, serviceId, interfaceId);
        public static ComObject<T> GetServiceForStream<T>(this IMFSinkWriter input, uint streamIndex) => GetServiceForStream<T>(input, streamIndex, Guid.Empty, typeof(T).GUID);
        public static ComObject<T> GetServiceForStream<T>(this IMFSinkWriter input, uint streamIndex, Guid serviceId, Guid interfaceId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetServiceForStream(streamIndex, serviceId, interfaceId, out var ppv).IsError)
                return null;

            return new ComObject<T>((T)ppv);
        }
    }
}

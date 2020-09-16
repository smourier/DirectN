using System;

namespace DirectN
{
    public class CodecApi : ComObject
    {
        private ICodecAPI _api;

        public CodecApi(object api)
            : base(api)
        {
            _api = (ICodecAPI)api;
        }

        public void SetValue(Guid api, IntPtr value) => _api.SetValue(api, value);
        public IntPtr GetValue(Guid api)
        {
            _api.GetValue(api, out var value).ThrowOnError();
            return value;
        }

        public bool TryGetValue(Guid api, out IntPtr value) => _api.GetValue(api, out value) == 0;
    }
}

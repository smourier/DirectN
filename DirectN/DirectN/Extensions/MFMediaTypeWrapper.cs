using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DirectN
{
    public class MFMediaTypeWrapper : IMFMediaType
    {
        public static ILogger Logger { get; set; }
        private IMFMediaType _type;

        [Conditional("DEBUG")]
        public static void Trace(string message = null, [CallerMemberName] string methodName = null) => Logger?.Log(TraceLevel.Info, message, methodName);

        public MFMediaTypeWrapper(IMFMediaType type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            _type = type;
        }

        public HRESULT Compare(IMFAttributes pTheirs, _MF_ATTRIBUTES_MATCH_TYPE MatchType, out bool pbResult)
        {
            var hr = _type.Compare(pTheirs, MatchType, out pbResult);
            Trace("theirs: " + pTheirs.Trace() + " type: " + MatchType + " result: " + pbResult + " hr: " + hr);
            return hr;
        }

        public HRESULT CompareItem(Guid guidKey, PropVariant Value, out bool pbResult)
        {
            var hr = _type.CompareItem(guidKey, Value, out pbResult);
            Trace("key: " + guidKey.ToName() + " value: " + Value + " result: " + pbResult + " hr: " + hr);
            return hr;
        }

        public HRESULT CopyAllItems(IMFAttributes pDest)
        {
            var hr = _type.CopyAllItems(pDest);
            Trace("hr: " + hr);
            return hr;
        }

        public HRESULT DeleteAllItems()
        {
            var hr = _type.DeleteAllItems();
            Trace("hr: " + hr);
            return hr;
        }

        public HRESULT DeleteItem(Guid guidKey)
        {
            var hr = _type.DeleteItem(guidKey);
            Trace("key: " + guidKey.ToName() + " hr: " + hr);
            return hr;
        }
        public HRESULT FreeRepresentation(Guid guidRepresentation, IntPtr pvRepresentation)
        {
            var hr = _type.FreeRepresentation(guidRepresentation, pvRepresentation);
            Trace("guid: " + guidRepresentation.ToName() + " pv: " + pvRepresentation + " hr: " + hr);
            return hr;
        }

        public HRESULT GetAllocatedBlob(Guid guidKey, out IntPtr ppBuf, out uint pcbSize)
        {
            var hr = _type.GetAllocatedBlob(guidKey, out ppBuf, out pcbSize);
            Trace("guid: " + guidKey.ToName() + " pv: " + ppBuf + " size: " + pcbSize + " hr: " + hr);
            return hr;
        }

        public HRESULT GetAllocatedString(Guid guidKey, IntPtr ppwszValue, out uint pcchLength)
        {
            var hr = _type.GetAllocatedString(guidKey, ppwszValue, out pcchLength);
            Trace("guid: " + guidKey.ToName() + " pv: " + ppwszValue + " len: " + pcchLength + " hr: " + hr);
            return hr;
        }

        public HRESULT GetBlob(Guid guidKey, byte[] pBuf, int cbBufSize, IntPtr pcbBlobSize)
        {
            var hr = _type.GetBlob(guidKey, pBuf, cbBufSize, pcbBlobSize);
            Trace("guid: " + guidKey.ToName() + " buf: " + Conversions.ToHexa(pBuf, 64) + " size: " + cbBufSize + " len: " + pcbBlobSize + " hr: " + hr);
            return hr;
        }

        public HRESULT GetBlobSize(Guid guidKey, out uint pcbBlobSize)
        {
            var hr = _type.GetBlobSize(guidKey, out pcbBlobSize);
            Trace("guid: " + guidKey.ToName() + " size: " + pcbBlobSize + " hr: " + hr);
            return hr;
        }

        public HRESULT GetCount(out uint pcItems)
        {
            var hr = _type.GetCount(out pcItems);
            Trace("count: " + pcItems + " hr: " + hr);
            return hr;
        }

        public HRESULT GetDouble(Guid guidKey, out double pfValue)
        {
            var hr = _type.GetDouble(guidKey, out pfValue);
            Trace("guid: " + guidKey.ToName() + " value: " + pfValue + " hr: " + hr);
            return hr;
        }

        public HRESULT GetGUID(Guid guidKey, out Guid pguidValue)
        {
            var hr = _type.GetGUID(guidKey, out pguidValue);
            Trace("guid: " + guidKey.ToName() + " value: " + pguidValue.ToName() + " hr: " + hr);
            return hr;
        }

        public HRESULT GetItem(Guid guidKey, PropVariant pValue)
        {
            var hr = _type.GetItem(guidKey, pValue);
            Trace("guid: " + guidKey.ToName() + " value: " + (pValue != null ? pValue.ToString() : "<null>") + " hr: " + hr);
            return hr;
        }

        public HRESULT GetItemByIndex(uint unIndex, out Guid pguidKey, PropVariant pValue)
        {
            var hr = _type.GetItemByIndex(unIndex, out pguidKey, pValue);
            Trace("index: " + unIndex + " guid: " + pguidKey.ToName() + " value: " + (pValue != null  ? pValue.ToString() : "<null>") + " hr: " + hr);
            return hr;
        }

        public HRESULT GetItemType(Guid guidKey, out _MF_ATTRIBUTE_TYPE pType)
        {
            var hr = _type.GetItemType(guidKey, out pType);
            Trace("guid: " + guidKey.ToName() + " type: " + pType + " hr: " + hr);
            return hr;
        }

        public HRESULT GetMajorType(out Guid pguidMajorType)
        {
            var hr = _type.GetMajorType(out pguidMajorType);
            Trace("guid: " + pguidMajorType.ToName() + " hr: " + hr);
            return hr;
        }

        public HRESULT GetRepresentation(Guid guidRepresentation, out IntPtr ppvRepresentation)
        {
            var hr = _type.GetRepresentation(guidRepresentation, out ppvRepresentation);
            Trace("guid: " + guidRepresentation.ToName() + " ppv: " + ppvRepresentation + " hr: " + hr);
            return hr;
        }

        public HRESULT GetString(Guid guidKey, string pwszValue, uint cchBufSize, IntPtr pcchLength)
        {
            var hr = _type.GetString(guidKey, pwszValue, cchBufSize, pcchLength);
            Trace("guid: " + guidKey.ToName() + " value: " + pwszValue + " size: " + cchBufSize + " hr: " + hr);
            return hr;
        }

        public HRESULT GetStringLength(Guid guidKey, out uint pcchLength)
        {
            var hr = _type.GetStringLength(guidKey, out pcchLength);
            Trace("guid: " + guidKey.ToName() + " len: " + pcchLength + " hr: " + hr);
            return hr;
        }

        public HRESULT GetUINT32(Guid guidKey, out uint punValue)
        {
            var hr = _type.GetUINT32(guidKey, out punValue);
            Trace("guid: " + guidKey.ToName() + " value: " + punValue + " hr: " + hr);
            return hr;
        }

        public HRESULT GetUINT64(Guid guidKey, out ulong punValue)
        {
            var hr = _type.GetUINT64(guidKey, out punValue);
            Trace("guid: " + guidKey.ToName() + " value: " + punValue + " hr: " + hr);
            return hr;
        }

        public HRESULT GetUnknown(Guid guidKey, Guid riid, out object ppv)
        {
            var hr = _type.GetUnknown(guidKey, riid, out ppv);
            Trace("guid: " + guidKey.ToName() + " riid: " + riid.ToName() + " value: " + ppv + " hr: " + hr);
            return hr;
        }

        public HRESULT IsCompressedFormat(out bool pfCompressed)
        {
            var hr = _type.IsCompressedFormat(out pfCompressed);
            Trace("compressed: " + pfCompressed + " hr: " + hr);
            return hr;
        }

        public HRESULT IsEqual(IMFMediaType pIMediaType, out uint pdwFlags)
        {
            var hr = _type.IsEqual(pIMediaType, out pdwFlags);
            var flags = (MF_MEDIATYPE_EQUAL_FLAGS)pdwFlags;
            Trace("type: " + pIMediaType + " flags: " + flags + " hr: " + hr);
            return hr;
        }

        public HRESULT SetBlob(Guid guidKey, byte[] pBuf, int cbBufSize)
        {
            var hr = _type.SetBlob(guidKey, pBuf, cbBufSize);
            Trace("key: " + guidKey.ToName() + " buf: " + Conversions.ToHexa(pBuf, 64) + " size: " + cbBufSize + " hr: " + hr);
            return hr;
        }

        public HRESULT SetDouble(Guid guidKey, double fValue)
        {
            var hr = _type.SetDouble(guidKey, fValue);
            Trace("key: " + guidKey.ToName() + " value: " + fValue + " hr: " + hr);
            return hr;
        }

        public HRESULT SetGUID(Guid guidKey, Guid guidValue)
        {
            var hr = _type.SetGUID(guidKey, guidValue);
            Trace("key: " + guidKey.ToName() + " value: " + guidValue.ToName() + " hr: " + hr);
            return hr;
        }

        public HRESULT SetItem(Guid guidKey, PropVariant Value)
        {
            var hr = _type.SetItem(guidKey, Value);
            Trace("key: " + guidKey.ToName() + " value: " + Value + " hr: " + hr);
            return hr;
        }

        public HRESULT SetString(Guid guidKey, string wszValue)
        {
            var hr = _type.SetString(guidKey, wszValue);
            Trace("key: " + guidKey.ToName() + " value: " + wszValue + " hr: " + hr);
            return hr;
        }

        public HRESULT SetUINT32(Guid guidKey, uint unValue)
        {
            var hr = _type.SetUINT32(guidKey, unValue);
            Trace("key: " + guidKey.ToName() + " value: " + unValue + " hr: " + hr);
            return hr;
        }

        public HRESULT SetUINT64(Guid guidKey, ulong unValue)
        {
            var hr = _type.SetUINT64(guidKey, unValue);
            Trace("key: " + guidKey.ToName() + " value: " + unValue + " hr: " + hr);
            return hr;
        }

        public HRESULT SetUnknown(Guid guidKey, object pUnknown)
        {
            var hr = _type.SetUnknown(guidKey, pUnknown);
            Trace("key: " + guidKey.ToName() + " unk: " + pUnknown + " hr: " + hr);
            return hr;
        }

        public HRESULT LockStore()
        {
            var hr = _type.LockStore();
            Trace("hr: " + hr);
            return hr;
        }

        public HRESULT UnlockStore()
        {
            var hr = _type.UnlockStore();
            Trace("values: " + _type.Trace() + " hr: " + hr);
            return hr;
        }
    }
}

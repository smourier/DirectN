namespace DirectN
{
    public enum HRESULTS
    {
        S_OK = 0,
        S_FALSE = 1,
        E_FAIL = unchecked((int)0x80004005),
        E_NOINTERFACE = unchecked((int)0x80004002),
        E_INVALIDARG = unchecked((int)0x80070057),
        E_ACCESSDENIED = unchecked((int)0x80070005),
        ERROR_CANCELLED = unchecked((int)0x800704C7),

        // storage
        STG_E_INVALIDFUNCTION = unchecked((int)0x80030001),

        // dxgi
        DXGI_ERROR_WAIT_TIMEOUT = unchecked((int)0x887A0027),
        DXGI_ERROR_ACCESS_LOST = unchecked((int)0x887A0026),
        DXGI_ERROR_INVALID_CALL = unchecked((int)0x887A0001),

        // mf
        MF_E_UNSUPPORTED_SERVICE = unchecked((int)0xC00D36BA),
    }
}

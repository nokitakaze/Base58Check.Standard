namespace NokitaKaze.Base58Check
{
    /// <summary>
    /// 
    /// </summary>
    /// https://en.bitcoin.it/wiki/List_of_address_prefixes
    public enum Base58DataType
    {
        // Main network
        /// <summary>
        /// Pubkey hash (P2PKH address)
        /// https://en.bitcoin.it/wiki/Transaction#Pay-to-PubkeyHash
        /// </summary>
        P2PKH,

        /// <summary>
        /// Script hash (P2SH address)
        /// https://en.bitcoin.it/wiki/Pay_to_script_hash
        /// </summary>
        P2SH,

        /// <summary>
        /// Private key (WIF, uncompressed pubkey)
        /// https://en.bitcoin.it/wiki/Wallet_import_format
        /// </summary>
        PRIVATE_KEY_WIF,

        /// <summary>
        /// BIP32 pubkey
        /// https://en.bitcoin.it/wiki/BIP_0032
        /// </summary>
        BIP32_PUBLIC_KEY,

        /// <summary>
        /// BIP32 private key
        /// </summary>
        BIP32_PRIVATE_KEY,

        // Test network
        /// <summary>
        /// Testnet pubkey hash (P2PKH address)
        /// https://en.bitcoin.it/wiki/Transaction#Pay-to-PubkeyHash
        /// </summary>
        P2PKH_TESTNET,

        /// <summary>
        /// Testnet script hash (P2SH address)
        /// https://en.bitcoin.it/wiki/Pay_to_script_hash
        /// </summary>
        P2SH_TESTNET,

        /// <summary>
        /// Testnet private key (WIF, uncompressed pubkey)
        /// https://en.bitcoin.it/wiki/Wallet_import_format
        /// </summary>
        PRIVATE_KEY_WIF_TESTNET,

        /// <summary>
        /// Testnet BIP32 pubkey
        /// </summary>
        BIP32_PUBLIC_KEY_TESTNET,

        /// <summary>
        /// Testnet BIP32 private key
        /// </summary>
        BIP32_PRIVATE_KEY_TESTNET,

        UNKNOWN,
    }
}
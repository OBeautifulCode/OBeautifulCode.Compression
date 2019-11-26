// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICompress.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Compression
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Compression.Internal;

    /// <summary>
    /// Interface to compress.
    /// </summary>
    public interface ICompress : IHaveCompressionKind
    {
        /// <summary>
        /// Compresses the provided byte array.
        /// </summary>
        /// <param name="uncompressedBytes">Byte array to compress.</param>
        /// <returns>
        /// Compressed version of the supplied byte array.
        /// </returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "bytes", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddsClarityToIdentifierAndNoGoodAlternative)]
        byte[] CompressBytes(
            byte[] uncompressedBytes);
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDecompress.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Compression
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;

    /// <summary>
    /// Interface to decompress.
    /// </summary>
    public interface IDecompress
    {
        /// <summary>
        /// Decompresses the provided byte array.
        /// </summary>
        /// <param name="compressedBytes">Byte array to decompress.</param>
        /// <returns>
        /// Decompressed version of the supplied byte array.
        /// </returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "bytes", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddsClarityToIdentifierAndNoGoodAlternative)]
        byte[] DecompressBytes(
            byte[] compressedBytes);
    }
}

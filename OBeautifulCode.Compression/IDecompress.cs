// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDecompress.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Compression
{
    /// <summary>
    /// Interface to decompress.
    /// </summary>
    public interface IDecompress : IHaveCompressionKind
    {
        /// <summary>
        /// Decompresses the provided byte array.
        /// </summary>
        /// <param name="compressedBytes">Byte array to decompress.</param>
        /// <returns>Decompressed version of the supplied byte array.</returns>
        byte[] DecompressBytes(
            byte[] compressedBytes);
    }
}

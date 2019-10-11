// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICompress.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Compression
{
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
        byte[] CompressBytes(
            byte[] uncompressedBytes);
    }
}

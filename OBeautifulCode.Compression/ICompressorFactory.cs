// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICompressorFactory.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Compression
{
    /// <summary>
    /// Abstract factory interface for building compressors.
    /// </summary>
    public interface ICompressorFactory
    {
        /// <summary>
        /// Builds the correct <see cref="ICompressAndDecompress" /> implementation based on the kind.
        /// </summary>
        /// <param name="compressionKind">Kind of compression.</param>
        /// <returns><see cref="ICompressAndDecompress" /> implementation based on the kind.</returns>
        ICompressAndDecompress BuildCompressor(
            CompressionKind compressionKind);
    }
}

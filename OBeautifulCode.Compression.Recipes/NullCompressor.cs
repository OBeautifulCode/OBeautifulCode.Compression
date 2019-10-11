// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NullCompressor.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Compression.Recipes
{
    /// <summary>
    /// Null implementation of <see cref="ICompressAndDecompress"/>.
    /// </summary>
    public class NullCompressor : ICompressAndDecompress
    {
        /// <inheritdoc cref="ICompressAndDecompress"/>
        public CompressionKind CompressionKind => CompressionKind.None;

        /// <inheritdoc cref="ICompressAndDecompress"/>
        public byte[] CompressBytes(
            byte[] uncompressedBytes)
        {
            var result = uncompressedBytes;

            return result;
        }

        /// <inheritdoc cref="ICompressAndDecompress"/>
        public byte[] DecompressBytes(
            byte[] compressedBytes)
        {
            var result = compressedBytes;

            return result;
        }
    }
}

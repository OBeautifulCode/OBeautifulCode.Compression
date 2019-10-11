﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DotNetZipCompressor.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Compression.Recipes
{
    using System.IO;
    using System.IO.Compression;

    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Build in dot net implementation of <see cref="ICompressAndDecompress"/>.
    /// Implementation from: <a href="https://stackoverflow.com/questions/40909052/using-gzip-to-compress-decompress-an-array-of-bytes" />.
    /// </summary>
    public class DotNetZipCompressor : ICompressAndDecompress
    {
        /// <inheritdoc />
        public CompressionKind CompressionKind => CompressionKind.DotNetZip;

        /// <summary>
        /// Compresses the provided byte array.
        /// </summary>
        /// <param name="uncompressedBytes">Byte array to compress.</param>
        /// <returns>
        /// Compressed version of the supplied byte array.
        /// </returns>
        public static byte[] CompressBytes(
            byte[] uncompressedBytes)
        {
            new { uncompressedBytes }.AsArg().Must().NotBeNull();

            byte[] result;

            using (var compressedStream = new MemoryStream())
            {
                using (var zipStream = new GZipStream(compressedStream, CompressionMode.Compress))
                {
                    zipStream.Write(uncompressedBytes, 0, uncompressedBytes.Length);

                    zipStream.Close();

                    result = compressedStream.ToArray();
                }
            }

            return result;
        }

        /// <summary>
        /// Decompresses the provided byte array.
        /// </summary>
        /// <param name="compressedBytes">Byte array to decompress.</param>
        /// <returns>
        /// Decompressed version of the supplied byte array.
        /// </returns>
        public static byte[] DecompressBytes(
            byte[] compressedBytes)
        {
            new { compressedBytes }.AsArg().Must().NotBeNull();

            byte[] result;

            using (var compressedStream = new MemoryStream(compressedBytes))
            {
                using (var zipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
                {
                    using (var resultStream = new MemoryStream())
                    {
                        zipStream.CopyTo(resultStream);

                        result = resultStream.ToArray();
                    }
                }
            }

            return result;
        }

        /// <inheritdoc />
        byte[] ICompress.CompressBytes(
            byte[] uncompressedBytes)
        {
            new { uncompressedBytes }.AsArg().Must().NotBeNull();

            var result = CompressBytes(uncompressedBytes);

            return result;
        }

        /// <inheritdoc />
        byte[] IDecompress.DecompressBytes(
            byte[] compressedBytes)
        {
            new { compressedBytes }.AsArg().Must().NotBeNull();

            var result = DecompressBytes(compressedBytes);

            return result;
        }
    }
}
﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompressorFactory.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Compression.Recipes
{
    using System;

    using OBeautifulCode.Assertion.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Get the correct <see cref="ICompressAndDecompress" /> implementation based on the kind.
    /// </summary>
    public class CompressorFactory : ICompressorFactory
    {
        private static readonly CompressorFactory InternalInstance = new CompressorFactory();

        private CompressorFactory()
        {
            /* no-op to make sure this can only be accessed via instance property */
        }

        /// <summary>
        /// Gets the singleton entry point to the code.
        /// </summary>
        public static ICompressorFactory Instance => InternalInstance;

        /// <inheritdoc />
        public ICompressAndDecompress BuildCompressor(
            CompressionKind compressionKind)
        {
            new { compressionKind }.AsArg().Must().NotBeEqualTo(CompressionKind.Invalid);

            ICompressAndDecompress result;

            switch (compressionKind)
            {
                case CompressionKind.None:
                    result = new NullCompressor();
                    break;
                case CompressionKind.DotNetZip:
                    result = new DotNetZipCompressor();
                    break;
                default:
                    throw new NotSupportedException(Invariant($"{nameof(CompressionKind)} value {compressionKind} is not currently supported."));
            }

            return result;
        }
    }
}

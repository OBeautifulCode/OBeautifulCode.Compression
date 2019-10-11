// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompressionKind.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Compression
{
    /// <summary>
    /// Kind of compression.
    /// </summary>
    public enum CompressionKind
    {
        /// <summary>
        /// Invalid default option.
        /// </summary>
        Invalid,

        /// <summary>
        /// No compression, pass through.
        /// </summary>
        None,

        /// <summary>
        /// Zip compression using <see cref="System.IO.Compression" /> logic.
        /// </summary>
        DotNetZip,
    }
}
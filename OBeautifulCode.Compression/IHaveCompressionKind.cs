// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHaveCompressionKind.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Compression
{
    /// <summary>
    /// Interface to expose the <see cref="CompressionKind" />.
    /// </summary>
    public interface IHaveCompressionKind
    {
        /// <summary>
        /// Gets the kind of compression supported.
        /// </summary>
        CompressionKind CompressionKind { get; }
    }
}

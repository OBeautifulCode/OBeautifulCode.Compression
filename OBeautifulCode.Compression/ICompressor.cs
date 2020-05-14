// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICompressor.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Compression
{
    /// <summary>
    /// An object that compresses and decompresses.
    /// </summary>
    public interface ICompressor : ICompressAndDecompress, IHaveCompressionKind
    {
    }
}
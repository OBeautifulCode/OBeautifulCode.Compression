﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DotNetZipCompressorTests.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Compression.Recipes.Test
{
    using System;
    using System.Text;

    using FakeItEasy;

    using FluentAssertions;

    using Xunit;

    public static class DotNetZipCompressorTests
    {
        [Fact]
        public static void CompressBytes___With_null_bytes___Throws()
        {
            // Arrange
            ICompressAndDecompress compressor = new DotNetZipCompressor();
            Action action = () => compressor.CompressBytes(null);

            // Act
            var exception = Record.Exception(action);

            // Assert
            exception.Should().NotBeNull();
            exception.Should().BeOfType<ArgumentNullException>();
            exception.Message.Should().Contain("Parameter name: uncompressedBytes");
        }

        [Fact]
        public static void DecompressBytes___With_null_bytes___Throws()
        {
            // Arrange
            ICompressAndDecompress compressor = new DotNetZipCompressor();
            Action action = () => compressor.DecompressBytes(null);

            // Act
            var exception = Record.Exception(action);

            // Assert
            exception.Should().NotBeNull();
            exception.Should().BeOfType<ArgumentNullException>();
            exception.Message.Should().Contain("Parameter name: compressedBytes");
        }

        [Fact]
        public static void RoundtripCompressDecompress___With_zero_bytes___Works()
        {
            // Arrange
            var expected = new byte[0];

            // Act
            var compressed = DotNetZipCompressor.CompressBytes(expected);
            var actual = DotNetZipCompressor.DecompressBytes(compressed);

            // Assert
            actual.Should().Equal(expected);
        }

        [Fact]
        public static void RoundtripCompressDecompress___With_some_bytes___Works()
        {
            // Arrange
            var expected = Encoding.UTF32.GetBytes(A.Dummy<string>());

            // Act
            var compressed = DotNetZipCompressor.CompressBytes(expected);
            var actual = DotNetZipCompressor.DecompressBytes(compressed);

            // Assert
            actual.Should().Equal(expected);
        }
    }
}

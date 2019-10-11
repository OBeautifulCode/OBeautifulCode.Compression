// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompressorFactoryTests.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Compression.Recipes.Test
{
    using System;

    using FluentAssertions;

    using Xunit;

    public static class CompressorFactoryTests
    {
        [Fact]
        public static void BuildCompressor___Invalid_kind___Throws()
        {
            // Arrange
            var kind = CompressionKind.Invalid;
            Action action = () => CompressorFactory.Instance.BuildCompressor(kind);

            // Act
            var exception = Record.Exception(action);

            // Assert
            exception.Should().NotBeNull();
            exception.Should().BeOfType<ArgumentOutOfRangeException>();
            exception.Message.Should().Be("Provided value (name: 'compressionKind') is equal to the comparison value using EqualityExtensions.IsEqualTo<T>, where T: CompressionKind.  Specified 'comparisonValue' is 'Invalid'.");
        }

        [Fact]
        public static void BuildCompressor___None_kind___NullCompressor()
        {
            // Arrange
            var kind = CompressionKind.None;
            var expectedType = typeof(NullCompressor);

            // Act
            var actual = CompressorFactory.Instance.BuildCompressor(kind);

            // Assert
            actual.Should().NotBeNull();
            actual.Should().BeOfType(expectedType);
            actual.CompressionKind.Should().Be(kind);
        }

        [Fact]
        public static void BuildCompressor___DotNetZip_kind___DotNetZipCompressor()
        {
            // Arrange
            var kind = CompressionKind.DotNetZip;
            var expectedType = typeof(DotNetZipCompressor);

            // Act
            var actual = CompressorFactory.Instance.BuildCompressor(kind);

            // Assert
            actual.Should().NotBeNull();
            actual.Should().BeOfType(expectedType);
            actual.CompressionKind.Should().Be(kind);
        }
    }
}

namespace Common.Extensions.Tests
{
    using System;
    using FluentAssertions;
    using Xunit;

    public class StringExtensionsTests
    {
        [Theory]
        [InlineData("a", false)]
        [InlineData(" ", false)]
        public void IsEmpty_StrWithValueTest_ShouldBeFalse(string str, bool expected)
        {
            // Act & Assert
            str.IsEmpty().Should().Be(expected);
        }

        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        public void IsEmpty_InvalidString_IsEmptyShouldBeTrue(string str, bool expected)
        {
            // Act & Assert
            str.IsEmpty().Should().Be(expected);
        }

        [Theory]
        [InlineData("a", true)]
        [InlineData(" ", true)]
        public void IsNotEmpty_StrHasValueTests_ShouldBeTrue(string str, bool expected)
        {
            // Act & Assert
            str.IsNotEmpty().Should().Be(expected);
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        public void IsNotEmpty_InvalidString_ShouldBeFalse(string str, bool expected)
        {
            // Act & Assert
            str.IsNotEmpty().Should().Be(expected);
        }

        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData("  ", true)]
        public void IsWhitespace_InvalidString_ShouldBeTrue(string str, bool expected)
        {
            // Act & Assert
            str.IsWhitespace().Should().Be(expected);
        }

        [Fact]
        public void IsWhitespace_StrHasNoWhitespace_ShouldBeFalse()
        {
            // Act & Assert
            "a".IsWhitespace().Should().BeFalse();
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("  ", false)]
        public void IsNotWhitespace_InvalidString_ShouldBeFalse(string str, bool expected)
        {
            // Act & Assert
            str.IsNotWhitespace().Should().Be(expected);
        }

        [Fact]
        public void ToUri_StrIsUriWithoutSlash_ShouldBeWellFormedUri()
        {
            // Act & Assert
            "http://test.test".ToUri().Should().Be("http://test.test/");
        }

        [Fact]
        public void ToUri_StrHasValeOfA_ShouldThrowUriFormatException()
        {
            // Act
            Action act = () => "a".ToUri();

            // Assert
            act.ShouldThrow<UriFormatException>();
        }

        [Fact]
        public void ToUri_NullString_ShouldThrowArgumentNullException()
        {
            // Act
            Action act = () => ((string) null).ToUri();

            // Assert
            act.ShouldThrow<ArgumentNullException>();
        }
    }
}
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

        [Fact]
        public void ToInt_ValidString_ShouldBe1()
        {
            // Act
            "1".ToInt().Should().Be(1);
        }

        [Fact]
        public void ToInt_InvalidString_ShouldThrowFormatException()
        {
            // Act
            Action act = () => "a".ToInt();

            // Assert
            act.ShouldThrow<FormatException>();
        }

        [Fact]
        public void ToInt_InvalidString_ShouldThrowOverflowException()
        {
            // Act
            Action act = () => long.MinValue.ToString().ToInt();

            // Assert
            act.ShouldThrow<OverflowException>();
        }

        [Theory]
        [InlineData(" ", 0)]
        [InlineData(null, 0)]
        [InlineData("", 0)]
        public void ToInt_InvalidString_ShouldBe0(string str, int expected)
        {
            // Act
            str.ToInt().Should().Be(expected);
        }

        [Fact]
        public void ToShort_ValidString_ShouldBe1()
        {
            // Act
            "1".ToShort().Should().Be(1);
        }

        [Fact]
        public void ToShort_InvalidString_ShouldThrowFormatException()
        {
            // Act
            Action act = () => "a".ToShort();

            // Assert
            act.ShouldThrow<FormatException>();
        }

        [Fact]
        public void ToShort_InvalidString_ShouldThrowOverflowException()
        {
            // Act
            Action act = () => int.MaxValue.ToString().ToShort();

            // Assert
            act.ShouldThrow<OverflowException>();
        }

        [Theory]
        [InlineData(" ", 0)]
        [InlineData(null, 0)]
        [InlineData("", 0)]
        public void ToShort_InvalidString_ShouldBe0(string str, short expected)
        {
            // Act
            str.ToShort().Should().Be(expected);
        }

        [Fact]
        public void ToLong_ValidString_ShouldBe1()
        {
            // Act
            "1".ToShort().Should().Be(1);
        }

        [Fact]
        public void ToLong_InvalidString_ShouldThrowFormatException()
        {
            // Act
            Action act = () => "a".ToLong();

            // Assert
            act.ShouldThrow<FormatException>();
        }

        [Theory]
        [InlineData(" ", 0)]
        [InlineData(null, 0)]
        [InlineData("", 0)]
        public void ToLong_InvalidString_ShouldBe0(string str, long expected)
        {
            // Act
            str.ToLong().Should().Be(expected);
        }

        [Fact]
        public void ToBoolean_ValidStringIsTrue_ShouldBeTrue()
        {
            // Act
            "true".ToBoolean().Should().BeTrue();
        }

        [Fact]
        public void ToBoolean_ValidStringIsFalse_ShouldBeFalse()
        {
            // Act
            "false".ToBoolean().Should().BeFalse();
        }
    }
}
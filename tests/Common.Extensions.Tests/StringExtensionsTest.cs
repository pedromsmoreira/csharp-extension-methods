namespace Common.Extensions.Tests
{
    using System;
    using FluentAssertions;
    using Xunit;

    public class StringExtensionsTests
    {
        [Fact]
        public void IsEmpty_StrWithValueTest_IsEmptyShouldBeFalse()
        {
            // Act & Assert
            "a".IsEmpty().Should().BeFalse();
        }

        [Fact]
        public void IsEmpty_StrIsNull_IsEmptyShouldBeTrue()
        {
            // Act & Assert
            ((string)null).IsEmpty().Should().BeTrue();
        }

        [Fact]
        public void IsEmpty_StrIsEmpty_IsEmptyShouldBeTrue()
        {
            // Act & Assert
            string.Empty.IsEmpty().Should().BeTrue();
        }

        [Fact]
        public void IsNotEmpty_StrHasValueTests_ShouldBeTrue()
        {
            // Act & Assert
            "a".IsNotEmpty().Should().BeTrue();
        }

        [Fact]
        public void IsNotEmpty_StrIsNull_ShouldBeFalse()
        {
            // Act & Assert
            ((string)null).IsNotEmpty().Should().BeFalse();
        }

        [Fact]
        public void IsNotEmpty_StrHasWhitespace_ShouldBeFalse()
        {
            // Act & Assert
            string.Empty.IsNotEmpty().Should().BeFalse();
        }

        [Fact]
        public void IsWhitespace_StrIsNull_ShouldBeTrue()
        {
            // Act & Assert
            ((string)null).IsWhitespace().Should().BeTrue();
        }

        [Fact]
        public void IsWhitespace_StrHasWhitespace_ShouldBeTrue()
        {
            // Act & Assert
            " ".IsWhitespace().Should().BeTrue();
        }

        [Fact]
        public void IsWhitespace_StrHasMultipleWhitespace_ShouldBeTrue()
        {
            // Act & Assert
            "    ".IsWhitespace().Should().BeTrue();
        }

        [Fact]
        public void IsWhitespace_StrHasNoWhitespace_ShouldBeFalse()
        {
            // Act & Assert
            "a".IsWhitespace().Should().BeFalse();
        }

        [Fact]
        public void IsNotWhitespace_StrIsNull_ShouldBeFalse()
        {
            // Act & Assert
            ((string)null).IsNotWhitespace().Should().BeFalse();
        }

        [Fact]
        public void IsNotWhitespace_StrHasNoWhitespace_ShouldBeTrue()
        {
            // Act & Assert
            "a".IsNotWhitespace().Should().BeTrue();
        }

        [Fact]
        public void IsNotWhitespace_StrHasWhitespace_ShouldBeFalse()
        {
            // Act & Assert
            " ".IsNotWhitespace().Should().BeFalse();
        }

        [Fact]
        public void IsNotWhitespace_StrHasMultipleWhitespace_ShouldBeFalse()
        {
            // Act & Assert
            "    ".IsNotWhitespace().Should().BeFalse();
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
    }
}
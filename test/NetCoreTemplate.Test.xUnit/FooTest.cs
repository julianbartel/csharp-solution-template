// Copyright (c) <Author>. All rights reserved.

namespace NetCoreTemplate.Test.xUnit
{
    using System;
    using FluentAssertions;
    using Xunit;

    public class FooTest
    {
        private Foo Testee { get; } = new Foo();

        [Fact]
        public void GetEndOfString_ReturnsLastTwoCharacters()
        {
            Testee.GetEndOfString("test", 2).Should().Be("st");
        }

        [Theory]
        [InlineData(null, 1, typeof(ArgumentNullException))]
        [InlineData("", 1, typeof(ArgumentNullException))]
        [InlineData(" ", 1, typeof(ArgumentNullException))]
        [InlineData("test", 0, typeof(ArgumentOutOfRangeException))]
        public void GetEndOfString_PerformsParameterChecks(string testParameter, int countParameter, Type expectedException)
        {
            Action act = () => Testee.GetEndOfString(testParameter, countParameter);

            act.Should().Throw<ArgumentException>().And.Should().BeOfType(expectedException);
        }

        [Fact]
        public void GetEndOfString_ThrowsInvalidOperationExceptionWhenCountExceedsLengthOfString()
        {
            Action act = () => Testee.GetEndOfString("a", 2);

            act.Should().Throw<InvalidOperationException>();
        }
    }
}
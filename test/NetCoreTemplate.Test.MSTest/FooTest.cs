// Copyright (c) <Author>. All rights reserved.

namespace NetCoreTemplate.Test.MSTest
{
    using System;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FooTest
    {
        private Foo Testee { get; } = new Foo();

        [TestMethod]
        public void GetEndOfString_ReturnsLastTwoCharacters()
        {
            Testee.GetEndOfString("test", 2).Should().Be("st");
        }

        [DataTestMethod]
        [DataRow(null, 1, typeof(ArgumentNullException))]
        [DataRow("", 1, typeof(ArgumentNullException))]
        [DataRow(" ", 1, typeof(ArgumentNullException))]
        [DataRow("test", 0, typeof(ArgumentOutOfRangeException))]
        public void GetEndOfString_PerformsParameterChecks(string testParameter, int countParameter, Type expectedException)
        {
            Action act = () => Testee.GetEndOfString(testParameter, countParameter);

            act.Should().Throw<ArgumentException>().And.Should().BeOfType(expectedException);
        }

        [TestMethod]
        public void GetEndOfString_ThrowsInvalidOperationExceptionWhenCountExceedsLengthOfString()
        {
            Action act = () => Testee.GetEndOfString("a", 2);

            act.Should().Throw<InvalidOperationException>();
        }
    }
}
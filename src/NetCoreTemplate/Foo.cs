// Copyright (c) <Author>. All rights reserved.

namespace NetCoreTemplate
{
    using System;
    using PostSharp.Patterns.Contracts;

    /// <summary>
    /// Test implementation of <see cref="IFoo" />.
    /// </summary>
    internal class Foo : IFoo
    {
        /// <inheritdoc />
        public string GetEndOfString(string test, int count)
        {
            if (count > test.Length)
            {
                throw new InvalidOperationException();
            }

            return test.Substring(test.Length - count);
        }
    }
}
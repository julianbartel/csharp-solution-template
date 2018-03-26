// Copyright (c) <Author>. All rights reserved.

namespace NetCoreTemplate
{
    using PostSharp.Patterns.Contracts;

    /// <summary>
    /// A placeholder interface.
    /// </summary>
    public interface IFoo
    {
        /// <summary>
        /// Returns the last <paramref name="count" /> characters from a string <paramref name="test" />.
        /// </summary>
        /// <param name="test">The string from which the end is returned.</param>
        /// <param name="count">The number of characters to get.</param>
        /// <returns>The last <paramref name="count" /> characters of <paramref name="test" />.</returns>
        string GetEndOfString([Required] string test, [StrictlyPositive] int count);
    }
}
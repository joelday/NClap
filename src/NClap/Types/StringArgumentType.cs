﻿using System;

namespace NClap.Types
{
    /// <summary>
    /// Implementation to describe System.Stringean.
    /// </summary>
    internal class StringArgumentType : ArgumentTypeBase
    {
        private static readonly StringArgumentType s_instance = new StringArgumentType();

        /// <summary>
        /// Primary constructor.
        /// </summary>
        private StringArgumentType() : base(typeof(string))
        {
        }

        /// <summary>
        /// Public factory method.
        /// </summary>
        /// <returns>A constructed object.</returns>
        public static StringArgumentType Create() => s_instance;

        /// <summary>
        /// Parses the provided string.  Throws an exception if the string
        /// cannot be parsed.
        /// </summary>
        /// <param name="context">Context for parsing.</param>
        /// <param name="stringToParse">String to parse.</param>
        /// <returns>The parsed object.</returns>
        protected override object Parse(ArgumentParseContext context, string stringToParse)
        {
            if (string.IsNullOrEmpty(stringToParse) && !context.AllowEmpty)
            {
                throw new ArgumentOutOfRangeException(nameof(stringToParse));
            }

            return stringToParse;
        }
    }
}

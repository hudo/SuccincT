﻿namespace SuccincT.Unions
{
    /// <summary>
    /// Singleton value sealed class that encapsulates the None literal used by various Succinct sealed classes.
    /// </summary>
    public sealed class None
    {
        private static readonly None TheNone = new None();

        private None() { }

        /// <summary>
        /// The sole implemented value of None. If pattern matching is used, this value need never be explicitly accessed.
        /// </summary>
        public static None Value { get { return TheNone; } }
    }
}
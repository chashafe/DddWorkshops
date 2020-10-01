﻿using System;

namespace DddWorkshops.Common.Guard
{
    public interface IGuardContext<TException> where TException : Exception
    {
        /// <summary>
        ///     Specifies assertion (if an <paramref name="expression" /> is true, <typeparamref name="TException" /> instance is
        ///     thrown with provided <paramref name="message" />).
        /// </summary>
        /// <param name="expression">Expression to guard against.</param>
        /// <param name="message">Optional exception message.</param>
        void Against(bool expression, string? message = null);

        /// <summary>
        ///     Verifies assertion.
        /// </summary>
        /// <param name="expression">Boolean expression to be verified.</param>
        /// <param name="arguments">Exception constructor arguments.</param>
        /// <remarks>If <paramref name="expression" />is true, assertion fails.</remarks>
        void Against(bool expression, params object[] arguments);
    }
}
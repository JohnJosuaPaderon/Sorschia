﻿using System;

namespace Sorschia
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="char"/>&gt;
        /// </summary>
        public static char? ToNullableChar(object value)
        {
            return ConvertNullableBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="char"/>&gt; using the specified formatting information
        /// </summary>
        public static char? ToNullableChar(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="char"/>&gt;
        /// </summary>
        public static char? ToNullableChar(string value)
        {
            return ConvertNullableBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="char"/>&gt; using the specified formatting information
        /// </summary>
        public static char? ToNullableChar(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToChar);
        }
    }
}

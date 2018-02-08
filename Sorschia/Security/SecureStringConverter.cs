using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Sorschia.Security
{
    /// <summary>
    /// Exposes functions that converts <see cref="string"/> and <see cref="SecureString"/>
    /// </summary>
    public static class SecureStringConverter
    {
        /// <summary>
        /// Converts <see cref="SecureString"/> to <see cref="string"/>
        /// </summary>
        public static string Convert(SecureString secureValue)
        {
            if (secureValue != null)
            {
                IntPtr unmanagedString = IntPtr.Zero;
                try
                {
                    unmanagedString = SecureStringMarshal.SecureStringToGlobalAllocUnicode(secureValue);
                    return Marshal.PtrToStringUni(unmanagedString);
                }
                finally
                {
                    Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="SecureString"/>
        /// </summary>
        public static SecureString Convert(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                unsafe
                {
                    fixed (char* passwordChars = value)
                    {
                        var secureValue = new SecureString(passwordChars, value.Length);
                        secureValue.MakeReadOnly();
                        return secureValue;
                    }
                }
            }
            else
            {
                return null;
            }
        }
    }
}

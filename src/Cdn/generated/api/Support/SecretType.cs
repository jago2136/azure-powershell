// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    /// <summary>The type of the secret resource.</summary>
    public partial struct SecretType :
        System.IEquatable<SecretType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SecretType AzureFirstPartyManagedCertificate = @"AzureFirstPartyManagedCertificate";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SecretType CustomerCertificate = @"CustomerCertificate";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SecretType ManagedCertificate = @"ManagedCertificate";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SecretType UrlSigningKey = @"UrlSigningKey";

        /// <summary>the value for an instance of the <see cref="SecretType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to SecretType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SecretType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new SecretType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type SecretType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SecretType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type SecretType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SecretType && Equals((SecretType)obj);
        }

        /// <summary>Returns hashCode for enum SecretType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="SecretType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SecretType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for SecretType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to SecretType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SecretType" />.</param>

        public static implicit operator SecretType(string value)
        {
            return new SecretType(value);
        }

        /// <summary>Implicit operator to convert SecretType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SecretType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SecretType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum SecretType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SecretType e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SecretType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum SecretType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SecretType e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SecretType e2)
        {
            return e2.Equals(e1);
        }
    }
}
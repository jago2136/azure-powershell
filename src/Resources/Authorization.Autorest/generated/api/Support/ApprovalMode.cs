// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support
{

    /// <summary>The type of rule</summary>
    public partial struct ApprovalMode :
        System.IEquatable<ApprovalMode>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode NoApproval = @"NoApproval";

        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode Parallel = @"Parallel";

        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode Serial = @"Serial";

        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode SingleStage = @"SingleStage";

        /// <summary>the value for an instance of the <see cref="ApprovalMode" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ApprovalMode"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ApprovalMode(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ApprovalMode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ApprovalMode" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ApprovalMode(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ApprovalMode</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ApprovalMode (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ApprovalMode && Equals((ApprovalMode)obj);
        }

        /// <summary>Returns hashCode for enum ApprovalMode</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ApprovalMode</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ApprovalMode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ApprovalMode" />.</param>

        public static implicit operator ApprovalMode(string value)
        {
            return new ApprovalMode(value);
        }

        /// <summary>Implicit operator to convert ApprovalMode to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ApprovalMode" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ApprovalMode</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode e1, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ApprovalMode</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode e1, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode e2)
        {
            return e2.Equals(e1);
        }
    }
}
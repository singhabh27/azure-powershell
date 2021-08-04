// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support
{

    /// <summary>The HA mode for the server.</summary>
    public partial struct HighAvailabilityMode :
        System.IEquatable<HighAvailabilityMode>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode Disabled = @"Disabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode ZoneRedundant = @"ZoneRedundant";

        /// <summary>the value for an instance of the <see cref="HighAvailabilityMode" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to HighAvailabilityMode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="HighAvailabilityMode" />.</param>
        internal static object CreateFrom(object value)
        {
            return new HighAvailabilityMode(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type HighAvailabilityMode</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type HighAvailabilityMode (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is HighAvailabilityMode && Equals((HighAvailabilityMode)obj);
        }

        /// <summary>Returns hashCode for enum HighAvailabilityMode</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="HighAvailabilityMode" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private HighAvailabilityMode(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for HighAvailabilityMode</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to HighAvailabilityMode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="HighAvailabilityMode" />.</param>

        public static implicit operator HighAvailabilityMode(string value)
        {
            return new HighAvailabilityMode(value);
        }

        /// <summary>Implicit operator to convert HighAvailabilityMode to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="HighAvailabilityMode" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum HighAvailabilityMode</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode e1, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum HighAvailabilityMode</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode e1, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode e2)
        {
            return e2.Equals(e1);
        }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    /// <summary> IP address allocation method. </summary>
    public readonly partial struct IPAddressAllocationMethod : IEquatable<IPAddressAllocationMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IPAddressAllocationMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IPAddressAllocationMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnsetValue = "unset";
        private const string DynamicValue = "dynamic";
        private const string StaticValue = "static";
        private const string LinklayerValue = "linklayer";
        private const string RandomValue = "random";
        private const string OtherValue = "other";

        /// <summary> unset. </summary>
        public static IPAddressAllocationMethod Unset { get; } = new IPAddressAllocationMethod(UnsetValue);
        /// <summary> dynamic. </summary>
        public static IPAddressAllocationMethod Dynamic { get; } = new IPAddressAllocationMethod(DynamicValue);
        /// <summary> static. </summary>
        public static IPAddressAllocationMethod Static { get; } = new IPAddressAllocationMethod(StaticValue);
        /// <summary> linklayer. </summary>
        public static IPAddressAllocationMethod Linklayer { get; } = new IPAddressAllocationMethod(LinklayerValue);
        /// <summary> random. </summary>
        public static IPAddressAllocationMethod Random { get; } = new IPAddressAllocationMethod(RandomValue);
        /// <summary> other. </summary>
        public static IPAddressAllocationMethod Other { get; } = new IPAddressAllocationMethod(OtherValue);
        /// <summary> Determines if two <see cref="IPAddressAllocationMethod"/> values are the same. </summary>
        public static bool operator ==(IPAddressAllocationMethod left, IPAddressAllocationMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IPAddressAllocationMethod"/> values are not the same. </summary>
        public static bool operator !=(IPAddressAllocationMethod left, IPAddressAllocationMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IPAddressAllocationMethod"/>. </summary>
        public static implicit operator IPAddressAllocationMethod(string value) => new IPAddressAllocationMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IPAddressAllocationMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IPAddressAllocationMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

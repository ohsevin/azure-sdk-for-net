// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMware;

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    /// <summary> Describes the Machine Extensions List Result. </summary>
    internal partial class MachineExtensionsListResult
    {
        /// <summary> Initializes a new instance of MachineExtensionsListResult. </summary>
        internal MachineExtensionsListResult()
        {
            Value = new ChangeTrackingList<MachineExtensionData>();
        }

        /// <summary> Initializes a new instance of MachineExtensionsListResult. </summary>
        /// <param name="value"> The list of extensions. </param>
        /// <param name="nextLink"> The uri to fetch the next page of machine extensions. Call ListNext() with this to fetch the next page of extensions. </param>
        internal MachineExtensionsListResult(IReadOnlyList<MachineExtensionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of extensions. </summary>
        public IReadOnlyList<MachineExtensionData> Value { get; }
        /// <summary> The uri to fetch the next page of machine extensions. Call ListNext() with this to fetch the next page of extensions. </summary>
        public string NextLink { get; }
    }
}

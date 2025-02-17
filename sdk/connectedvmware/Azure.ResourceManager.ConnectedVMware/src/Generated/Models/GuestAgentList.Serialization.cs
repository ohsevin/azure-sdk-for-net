// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMware;

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    internal partial class GuestAgentList
    {
        internal static GuestAgentList DeserializeGuestAgentList(JsonElement element)
        {
            Optional<string> nextLink = default;
            IReadOnlyList<GuestAgentData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<GuestAgentData> array = new List<GuestAgentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GuestAgentData.DeserializeGuestAgentData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new GuestAgentList(nextLink.Value, value);
        }
    }
}

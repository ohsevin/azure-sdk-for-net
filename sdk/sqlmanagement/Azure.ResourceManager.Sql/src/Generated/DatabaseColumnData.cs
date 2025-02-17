// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the DatabaseColumn data model. </summary>
    public partial class DatabaseColumnData : Resource
    {
        /// <summary> Initializes a new instance of DatabaseColumnData. </summary>
        public DatabaseColumnData()
        {
        }

        /// <summary> Initializes a new instance of DatabaseColumnData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="columnType"> The column data type. </param>
        /// <param name="temporalType"> The table temporal type. </param>
        /// <param name="memoryOptimized"> Whether or not the column belongs to a memory optimized table. </param>
        /// <param name="isComputed"> Whether or not the column is computed. </param>
        internal DatabaseColumnData(ResourceIdentifier id, string name, ResourceType type, ColumnDataType? columnType, TableTemporalType? temporalType, bool? memoryOptimized, bool? isComputed) : base(id, name, type)
        {
            ColumnType = columnType;
            TemporalType = temporalType;
            MemoryOptimized = memoryOptimized;
            IsComputed = isComputed;
        }

        /// <summary> The column data type. </summary>
        public ColumnDataType? ColumnType { get; set; }
        /// <summary> The table temporal type. </summary>
        public TableTemporalType? TemporalType { get; set; }
        /// <summary> Whether or not the column belongs to a memory optimized table. </summary>
        public bool? MemoryOptimized { get; set; }
        /// <summary> Whether or not the column is computed. </summary>
        public bool? IsComputed { get; set; }
    }
}

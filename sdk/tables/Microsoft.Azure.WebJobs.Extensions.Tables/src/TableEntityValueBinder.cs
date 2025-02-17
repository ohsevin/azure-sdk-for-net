﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs.Host.Bindings;
using Microsoft.Azure.WebJobs.Host.Protocols;
using Azure.Data.Tables;

namespace Microsoft.Azure.WebJobs.Extensions.Tables
{
    internal class TableEntityValueBinder : IValueBinder, IWatchable, IWatcher
    {
        private readonly TableEntityContext _entityContext;
        private readonly ITableEntity _value;
        private readonly Type _valueType;
        // TODO: Change detection
        //private readonly IDictionary<string, EntityProperty> _originalProperties;

        public TableEntityValueBinder(TableEntityContext entityContext, ITableEntity entity, Type valueType)
        {
            _entityContext = entityContext;
            _value = entity;
            _valueType = valueType;
            // TODO: Change detection
            //_originalProperties = DeepClone(entity.WriteEntity(null));
        }

        public Type Type => _valueType;

        public IWatcher Watcher => this;

        public static bool HasChanged => true; // TODO: HasChanges(_originalProperties, _value.WriteEntity(operationContext: null));

        public Task<object> GetValueAsync()
        {
            return Task.FromResult<object>(_value);
        }

        public Task SetValueAsync(object value, CancellationToken cancellationToken)
        {
            // Not ByRef, so can ignore value argument.
            if (_value.PartitionKey != _entityContext.PartitionKey || _value.RowKey != _entityContext.RowKey)
            {
                throw new InvalidOperationException(
                    "When binding to a table entity, the partition key and row key must not be changed.");
            }

            if (HasChanged)
            {
                var table = _entityContext.Table;
                return table.UpdateEntityAsync(_value, _value.ETag, cancellationToken: cancellationToken);
            }

            return Task.FromResult(0);
        }

        public string ToInvokeString()
        {
            return _entityContext.ToInvokeString();
        }

        public ParameterLog GetStatus()
        {
            return HasChanged ? new TableParameterLog { EntitiesWritten = 1 } : null;
        }

        internal static bool HasChanges(TableEntity originalProperties,
            TableEntity currentProperties)
        {
            if (originalProperties.Count != currentProperties.Count)
            {
                return true;
            }

            if (!Enumerable.SequenceEqual(originalProperties.Keys, currentProperties.Keys))
            {
                return true;
            }

            foreach (string key in currentProperties.Keys)
            {
                object originalValue = originalProperties[key];
                object newValue = currentProperties[key];
                if (originalValue == null)
                {
                    if (newValue != null)
                    {
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (!originalValue.Equals(newValue))
                {
                    return true;
                }
            }

            return false;
        }

        // internal static IDictionary<string, EntityProperty> DeepClone(IDictionary<string, EntityProperty> value)
        // {
        //     if (value == null)
        //     {
        //         return null;
        //     }
        //
        //     IDictionary<string, EntityProperty> clone = new Dictionary<string, EntityProperty>();
        //     foreach (KeyValuePair<string, EntityProperty> item in value)
        //     {
        //         clone.Add(item.Key, DeepClone(item.Value));
        //     }
        //
        //     return clone;
        // }
        //
        // internal static EntityProperty DeepClone(EntityProperty property)
        // {
        //     EdmType propertyType = property.PropertyType;
        //     switch (propertyType)
        //     {
        //         case EdmType.Binary:
        //             byte[] existingBytes = property.BinaryValue;
        //             byte[] clonedBytes;
        //             if (existingBytes == null)
        //             {
        //                 clonedBytes = null;
        //             }
        //             else
        //             {
        //                 clonedBytes = new byte[existingBytes.LongLength];
        //                 Array.Copy(existingBytes, clonedBytes, existingBytes.LongLength);
        //             }
        //
        //             return new EntityProperty(clonedBytes);
        //         case EdmType.Boolean:
        //             return new EntityProperty(property.BooleanValue);
        //         case EdmType.DateTime:
        //             return new EntityProperty(property.DateTime);
        //         case EdmType.Double:
        //             return new EntityProperty(property.DoubleValue);
        //         case EdmType.Guid:
        //             return new EntityProperty(property.GuidValue);
        //         case EdmType.Int32:
        //             return new EntityProperty(property.Int32Value);
        //         case EdmType.Int64:
        //             return new EntityProperty(property.Int64Value);
        //         case EdmType.String:
        //             return new EntityProperty(property.StringValue);
        //         default:
        //             string message = String.Format(CultureInfo.CurrentCulture, "Unknown PropertyType {0}.",
        //                 propertyType);
        //             throw new NotSupportedException(message);
        //     }
        // }
    }
}
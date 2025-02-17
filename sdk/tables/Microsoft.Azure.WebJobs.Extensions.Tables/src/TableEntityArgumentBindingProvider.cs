﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Reflection;
using Microsoft.Azure.WebJobs.Host.Bindings;

namespace Microsoft.Azure.WebJobs.Extensions.Tables
{
    internal class TableEntityArgumentBindingProvider : ITableEntityArgumentBindingProvider
    {
        public IArgumentBinding<TableEntityContext> TryCreate(ParameterInfo parameter)
        {
            if (parameter.ParameterType.ContainsGenericParameters)
            {
                return null;
            }

            if (!TableClientHelpers.ImplementsITableEntity(parameter.ParameterType))
            {
                return null;
            }

            TableClientHelpers.VerifyDefaultConstructor(parameter.ParameterType);
            return CreateBinding(parameter.ParameterType);
        }

        private static IArgumentBinding<TableEntityContext> CreateBinding(Type entityType)
        {
            Type genericType = typeof(TableEntityArgumentBinding<>).MakeGenericType(entityType);
            return (IArgumentBinding<TableEntityContext>)Activator.CreateInstance(genericType);
        }
    }
}
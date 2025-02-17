// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    /// <summary> Error details. </summary>
    public partial class ErrorDetail
    {
        /// <summary> Initializes a new instance of ErrorDetail. </summary>
        /// <param name="code"> The error&apos;s code. </param>
        /// <param name="message"> A human readable error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal ErrorDetail(string code, string message)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
            Details = new ChangeTrackingList<ErrorDetail>();
        }

        /// <summary> Initializes a new instance of ErrorDetail. </summary>
        /// <param name="code"> The error&apos;s code. </param>
        /// <param name="message"> A human readable error message. </param>
        /// <param name="target"> Indicates which property in the request is responsible for the error. </param>
        /// <param name="details"> Additional error details. </param>
        internal ErrorDetail(string code, string message, string target, IReadOnlyList<ErrorDetail> details)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
        }

        /// <summary> The error&apos;s code. </summary>
        public string Code { get; }
        /// <summary> A human readable error message. </summary>
        public string Message { get; }
        /// <summary> Indicates which property in the request is responsible for the error. </summary>
        public string Target { get; }
        /// <summary> Additional error details. </summary>
        public IReadOnlyList<ErrorDetail> Details { get; }
    }
}

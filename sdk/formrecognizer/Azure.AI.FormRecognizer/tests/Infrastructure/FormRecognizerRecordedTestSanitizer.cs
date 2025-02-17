﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.AI.FormRecognizer.Tests
{
    public class FormRecognizerRecordedTestSanitizer : RecordedTestSanitizer
    {
        public FormRecognizerRecordedTestSanitizer()
            : base()
        {
            AddJsonPathSanitizer("$..accessToken");
            AddJsonPathSanitizer("$..source");
            SanitizedHeaders.Add(Constants.AuthorizationHeader);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes a blob output data source. </summary>
    public partial class BlobOutputDataSource : StreamingJobOutputDataSource
    {
        /// <summary> Initializes a new instance of BlobOutputDataSource. </summary>
        public BlobOutputDataSource()
        {
            StorageAccounts = new ChangeTrackingList<StreamAnalyticsStorageAccount>();
            OutputDataSourceType = "Microsoft.Storage/Blob";
        }

        /// <summary> Initializes a new instance of BlobOutputDataSource. </summary>
        /// <param name="outputDataSourceType"> Indicates the type of data source output will be written to. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="storageAccounts"> A list of one or more Azure Storage accounts. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="container"> The name of a container within the associated Storage account. This container contains either the blob(s) to be read from or written to. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="pathPattern"> The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job. See https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input or https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for a more detailed explanation and example. </param>
        /// <param name="dateFormat"> The date format. Wherever {date} appears in pathPattern, the value of this property is used as the date format instead. </param>
        /// <param name="timeFormat"> The time format. Wherever {time} appears in pathPattern, the value of this property is used as the time format instead. </param>
        /// <param name="authenticationMode"> Authentication Mode. </param>
        /// <param name="blobPathPrefix"> Blob path prefix. </param>
        /// <param name="blobWriteMode"> Blob write mode. </param>
        internal BlobOutputDataSource(string outputDataSourceType, IList<StreamAnalyticsStorageAccount> storageAccounts, string container, string pathPattern, string dateFormat, string timeFormat, StreamAnalyticsAuthenticationMode? authenticationMode, string blobPathPrefix, BlobOutputWriteMode? blobWriteMode) : base(outputDataSourceType)
        {
            StorageAccounts = storageAccounts;
            Container = container;
            PathPattern = pathPattern;
            DateFormat = dateFormat;
            TimeFormat = timeFormat;
            AuthenticationMode = authenticationMode;
            BlobPathPrefix = blobPathPrefix;
            BlobWriteMode = blobWriteMode;
            OutputDataSourceType = outputDataSourceType ?? "Microsoft.Storage/Blob";
        }

        /// <summary> A list of one or more Azure Storage accounts. Required on PUT (CreateOrReplace) requests. </summary>
        public IList<StreamAnalyticsStorageAccount> StorageAccounts { get; }
        /// <summary> The name of a container within the associated Storage account. This container contains either the blob(s) to be read from or written to. Required on PUT (CreateOrReplace) requests. </summary>
        public string Container { get; set; }
        /// <summary> The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job. See https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input or https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for a more detailed explanation and example. </summary>
        public string PathPattern { get; set; }
        /// <summary> The date format. Wherever {date} appears in pathPattern, the value of this property is used as the date format instead. </summary>
        public string DateFormat { get; set; }
        /// <summary> The time format. Wherever {time} appears in pathPattern, the value of this property is used as the time format instead. </summary>
        public string TimeFormat { get; set; }
        /// <summary> Authentication Mode. </summary>
        public StreamAnalyticsAuthenticationMode? AuthenticationMode { get; set; }
        /// <summary> Blob path prefix. </summary>
        public string BlobPathPrefix { get; set; }
        /// <summary> Blob write mode. </summary>
        public BlobOutputWriteMode? BlobWriteMode { get; set; }
    }
}

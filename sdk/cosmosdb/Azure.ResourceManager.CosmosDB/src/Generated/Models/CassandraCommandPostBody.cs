// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Specification of which command to run where. </summary>
    public partial class CassandraCommandPostBody
    {
        /// <summary> Initializes a new instance of CassandraCommandPostBody. </summary>
        /// <param name="command"> The command which should be run. </param>
        /// <param name="host"> IP address of the cassandra host to run the command on. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="command"/> or <paramref name="host"/> is null. </exception>
        public CassandraCommandPostBody(string command, string host)
        {
            Argument.AssertNotNull(command, nameof(command));
            Argument.AssertNotNull(host, nameof(host));

            Command = command;
            Arguments = new ChangeTrackingDictionary<string, string>();
            Host = host;
        }

        /// <summary> The command which should be run. </summary>
        public string Command { get; }
        /// <summary> The arguments for the command to be run. </summary>
        public IDictionary<string, string> Arguments { get; }
        /// <summary> IP address of the cassandra host to run the command on. </summary>
        public string Host { get; }
        /// <summary> If true, stops cassandra before executing the command and then start it again. </summary>
        public bool? CassandraStopStart { get; set; }
        /// <summary> If true, allows the command to *write* to the cassandra directory, otherwise read-only. </summary>
        public bool? AllowWrite { get; set; }
    }
}

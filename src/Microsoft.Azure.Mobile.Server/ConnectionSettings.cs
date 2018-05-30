// ---------------------------------------------------------------------------- 
// Copyright (c) Microsoft Corporation. All rights reserved.
// ---------------------------------------------------------------------------- 

using System;

namespace Microsoft.Azure.Mobile.Server
{
    /// <summary>
    /// This class provides configuration information for connection strings.
    /// </summary>
    public class ConnectionSettings
    {
        private string _name;
        private string _connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSettings"/> with a given <paramref name="name"/>
        /// and <paramref name="connectionString"/>.
        /// </summary>
        /// <param name="name">The name of the connection string setting.</param>
        /// <param name="connectionString">The actual connection string.</param>
        public ConnectionSettings(string name, string connectionString)
        {
            this._name = name ?? throw new ArgumentNullException(nameof(name));
            this._connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        /// <summary>
        /// Gets or sets the name of the connection string.
        /// </summary>
        public string Name
        {
            get => this._name;

            set => this._name = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Gets or sets the actual connection string.
        /// </summary>
        public string ConnectionString
        {
            get => this._connectionString;

            set => this._connectionString = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Gets or sets the provider to be used by this connection string, e.g. <c>System.Data.SqlClient</c>.
        /// </summary>
        public string Provider { get; set; }
    }
}

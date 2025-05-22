// Copyright (C) 2023 NinjaTrader LLC. All rights reserved.
// </copyright>
#region Using declarations
using System;
using System.Runtime.Serialization; // Added for DataContract
#endregion

namespace NinjaTrader.Core
{
    /// <summary>
    /// Provides access to global application settings and constants for the NinjaTrader platform.
    /// </summary>
    /// <remarks>
    /// This class is likely used to store and retrieve configuration values that are relevant
    /// across different parts of the application. The <c>[Serializable]</c> and <c>[DataContract]</c>
    /// attributes suggest that instances of this class may be persisted or transferred, for example,
    /// when saving application settings or in inter-process communication.
    /// The documentation for this class and its members is primarily inferred from their names and common usage patterns
    /// in application frameworks, as direct online documentation lookup was not possible during generation.
    /// </remarks>
    [Serializable]
    [DataContract]
    public partial class Globals
    {
        #region Properties
        /// <summary>
        /// Gets or sets the official product name of the NinjaTrader application.
        /// </summary>
        /// <value>
        /// A string representing the product name (e.g., "NinjaTrader 8").
        /// </value>
        /// <remarks>This documentation is inferred.</remarks>
        [DataMember]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the name of the primary folder where NinjaTrader's core data is stored.
        /// This may not include user-specific data, which is typically in <see cref="UserDataDir"/>.
        /// </summary>
        /// <value>
        /// A string representing the name of the data folder (e.g., "NinjaTrader 8").
        /// </value>
        /// <remarks>This documentation is inferred. The path might be relative to the installation directory.</remarks>
        [DataMember]
        public string DataFolderName { get; set; }

        /// <summary>
        /// Gets or sets the full directory path where user-specific data is stored.
        /// This typically includes workspaces, templates, custom NinjaScript files, log files, etc.
        /// </summary>
        /// <value>
        /// A string representing the absolute path to the user data directory (e.g., "C:\Users\YourUser\Documents\NinjaTrader 8").
        /// </value>
        /// <remarks>This documentation is inferred.</remarks>
        [DataMember]
        public string UserDataDir { get; set; }
        #endregion

        #region Methods
        // Methods would be defined here if any.
        #endregion
    }
}

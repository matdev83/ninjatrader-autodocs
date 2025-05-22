// Copyright (C) 2023 NinjaTrader LLC. All rights reserved.
// </copyright>
#region Using declarations
using System;
#endregion

namespace NinjaTrader.Cbi
{
    /// <summary>
    /// Defines the different levels for tracing or logging within the NinjaTrader application.
    /// These levels can be combined as this enum is marked with the [Flags] attribute.
    /// </summary>
    /// <remarks>
    /// Trace levels are used to control the verbosity of logging output for different components of NinjaTrader.
    /// This allows developers and support staff to diagnose issues by enabling detailed logging for specific areas.
    /// This documentation is inferred based on the element names and common practices in similar APIs, as direct online lookup was not possible.
    /// </remarks>
    [Flags]
    public enum TraceLevels : int
    {
        /// <summary>
        /// Enables all tracing levels.
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        All = 268435455,

        /// <summary>
        /// Disables all tracing. No trace output will be generated.
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        None = 0,

        /// <summary>
        /// Enables tracing for bar-related activities (e.g., historical bars, real-time bar formation).
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        Bars = 1,

        /// <summary>
        /// Enables tracing for connection-related events (e.g., connecting to brokers, data feeds).
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        Connect = 4,

        /// <summary>
        /// Enables tracing for database operations (e.g., reading from or writing to the NinjaTrader database).
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        Database = 8,

        /// <summary>
        /// Enables tracing for Graphical User Interface (GUI) events and activities.
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        Gui = 16,

        /// <summary>
        /// Enables tracing for NinjaScript Indicator calculations and events.
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        Indicator = 32,

        /// <summary>
        /// Enables tracing for instrument resolution processes (e.g., looking up symbol details).
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        ResolveInstrument = 64,

        /// <summary>
        /// Enables tracing for market data events (e.g., ticks, last, bid, ask updates).
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        MarketData = 128,

        /// <summary>
        /// Enables tracing for market depth data (Level II data).
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        MarketDepth = 256,

        /// <summary>
        /// Enables tracing for native code modules or platform-specific operations.
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        Native = 512,

        /// <summary>
        /// Enables tracing for news-related events and data feeds.
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        News = 1024,

        /// <summary>
        /// Enables tracing for order-related activities (e.g., submissions, modifications, fills, cancellations).
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        Order = 2048,

        /// <summary>
        /// Enables tracing for NinjaScript Strategy executions and events.
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        Strategy = 4096,

        /// <summary>
        /// Enables a stricter or more verbose mode of tracing, possibly in conjunction with other levels.
        /// The exact behavior might depend on the specific NinjaTrader component being traced.
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        Strict = 8192,

        /// <summary>
        /// Enables tracing specifically for testing purposes or test harnesses.
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        Test = 16384,

        /// <summary>
        /// Enables tracing for timer-related events or scheduled tasks within the application.
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        Timer = 32768,

        /// <summary>
        /// Enables tracing for server-side communications or operations if applicable.
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        Server = 65536,

        /// <summary>
        /// Enables tracing for alert conditions and their notifications.
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        Alerts = 131072,

        /// <summary>
        /// Enables tracing for fundamental data requests and processing.
        /// </summary>
        /// <remarks>
        /// This documentation is inferred.
        /// </remarks>
        FundamentalData = 262144
    }
}

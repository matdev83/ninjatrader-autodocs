// Copyright (C) 2023 NinjaTrader LLC. All rights reserved.
// </copyright>
#region Using declarations
using System;
#endregion

namespace NinjaTrader.Data
{
    /// <summary>
    /// Specifies the different types of market data points that can be requested or referenced.
    /// </summary>
    /// <remarks>
    /// This enumeration is likely used to identify specific pieces of market information for an instrument,
    /// for example, when querying current market data or historical data points.
    /// The documentation for this enum and its members is primarily inferred from their names and common usage
    /// in financial trading platforms, as direct online documentation lookup was not possible during generation.
    /// </remarks>
    public enum MarketDataType : int
    {
        /// <summary>
        /// The current best ask price for the instrument.
        /// </summary>
        /// <remarks>This documentation is inferred.</remarks>
        Ask = 0,

        /// <summary>
        /// The current best bid price for the instrument.
        /// </summary>
        /// <remarks>This documentation is inferred.</remarks>
        Bid = 1,

        /// <summary>
        /// The price of the last executed trade for the instrument.
        /// </summary>
        /// <remarks>This documentation is inferred.</remarks>
        Last = 2,

        /// <summary>
        /// The highest price reached by the instrument during the current trading day.
        /// </summary>
        /// <remarks>This documentation is inferred.</remarks>
        DailyHigh = 3,

        /// <summary>
        /// The lowest price reached by the instrument during the current trading day.
        /// </summary>
        /// <remarks>This documentation is inferred.</remarks>
        DailyLow = 4,

        /// <summary>
        /// The total volume traded for the instrument during the current trading day.
        /// </summary>
        /// <remarks>This documentation is inferred.</remarks>
        DailyVolume = 5,

        /// <summary>
        /// The closing price of the instrument from the previous trading session.
        /// </summary>
        /// <remarks>This documentation is inferred.</remarks>
        LastClose = 6,

        /// <summary>
        /// The opening price of the instrument for the current trading session.
        /// </summary>
        /// <remarks>This documentation is inferred.</remarks>
        Opening = 7,

        /// <summary>
        /// The total number of outstanding derivative contracts (e.g., futures, options) that have not been settled.
        /// </summary>
        /// <remarks>This documentation is inferred.</remarks>
        OpenInterest = 8,

        /// <summary>
        /// The official settlement price for a contract at the end of a trading session (primarily for futures).
        /// </summary>
        /// <remarks>This documentation is inferred.</remarks>
        Settlement = 9,

        /// <summary>
        /// Represents an unknown or unspecified market data type.
        /// </summary>
        /// <remarks>This documentation is inferred.</remarks>
        Unknown = 10
    }
}

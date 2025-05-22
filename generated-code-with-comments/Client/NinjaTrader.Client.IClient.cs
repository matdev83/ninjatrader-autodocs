// Copyright (C) 2023 NinjaTrader LLC. All rights reserved.
// </copyright>
#region Using declarations
using System;
#endregion

namespace NinjaTrader.Client
{
    /// <summary>
    /// Defines the contract for a client interacting with the NinjaTrader platform.
    /// This interface outlines methods for trading operations, market data handling,
    /// account information retrieval, and managing the connection to NinjaTrader server components.
    /// </summary>
    /// <remarks>
    /// Implementations of this interface, such as the <c>NinjaTrader.Client.Client</c> class, provide
    /// concrete functionality for these operations.
    /// The documentation for this interface and its members is primarily inferred from their names,
    /// parameters, and return types, as direct online documentation lookup was not possible during generation.
    /// </remarks>
    public partial interface IClient
    {
        #region Properties
        // Properties contracts would be defined here if any.
        #endregion

        #region Methods
        /// <summary>
        /// Submits an Ask (offer) order to the market for the specified instrument.
        /// </summary>
        /// <param name="instrument">The instrument symbol (e.g., "ES 03-23", "MSFT").</param>
        /// <param name="price">The ask price for the order.</param>
        /// <param name="size">The quantity or size of the order.</param>
        /// <returns>An integer status code or identifier related to the operation. The exact meaning is inferred.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        int Ask(string instrument, double price, int size);

        /// <summary>
        /// Submits an Ask (offer) order during a playback or simulation session.
        /// </summary>
        /// <param name="instrument">The instrument symbol.</param>
        /// <param name="price">The ask price for the order.</param>
        /// <param name="size">The quantity or size of the order.</param>
        /// <param name="timestamp">A string representation of the timestamp for the playback event.</param>
        /// <returns>An integer status code or identifier. The exact meaning is inferred.</returns>
        /// <remarks>This documentation is inferred. Used for replaying or simulating market activity.</remarks>
        int AskPlayback(string instrument, double price, int size, string timestamp);

        /// <summary>
        /// Retrieves the average entry price for the current position in the specified instrument and account.
        /// </summary>
        /// <param name="instrument">The instrument symbol.</param>
        /// <param name="account">The account name or identifier.</param>
        /// <returns>The average entry price as a double. Returns 0 or a specific value if no position exists (inferred).</returns>
        /// <remarks>This documentation is inferred.</remarks>
        double AvgEntryPrice(string instrument, string account);

        /// <summary>
        /// Retrieves the average fill price for a specific order.
        /// </summary>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <returns>The average fill price of the order as a double. Returns 0 if the order is not found or not filled (inferred).</returns>
        /// <remarks>This documentation is inferred.</remarks>
        double AvgFillPrice(string orderId);

        /// <summary>
        /// Submits a Bid order to the market for the specified instrument.
        /// </summary>
        /// <param name="instrument">The instrument symbol.</param>
        /// <param name="price">The bid price for the order.</param>
        /// <param name="size">The quantity or size of the order.</param>
        /// <returns>An integer status code or identifier. The exact meaning is inferred.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        int Bid(string instrument, double price, int size);

        /// <summary>
        /// Submits a Bid order during a playback or simulation session.
        /// </summary>
        /// <param name="instrument">The instrument symbol.</param>
        /// <param name="price">The bid price for the order.</param>
        /// <param name="size">The quantity or size of the order.</param>
        /// <param name="timestamp">A string representation of the timestamp for the playback event.</param>
        /// <returns>An integer status code or identifier. The exact meaning is inferred.</returns>
        /// <remarks>This documentation is inferred. Used for replaying or simulating market activity.</remarks>
        int BidPlayback(string instrument, double price, int size, string timestamp);

        /// <summary>
        /// Retrieves the available buying power for the specified account.
        /// </summary>
        /// <param name="account">The account name or identifier.</param>
        /// <returns>The buying power as a double.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        double BuyingPower(string account);

        /// <summary>
        /// Retrieves the cash value of the specified account.
        /// </summary>
        /// <param name="account">The account name or identifier.</param>
        /// <returns>The cash value as a double.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        double CashValue(string account);

        /// <summary>
        /// Executes a generic command, likely related to order management or other platform actions.
        /// </summary>
        /// <param name="command">The command to execute (e.g., "PLACE", "MODIFY", "CANCEL").</param>
        /// <param name="account">The account name or identifier.</param>
        /// <param name="instrument">The instrument symbol.</param>
        /// <param name="action">The order action (e.g., "BUY", "SELL").</param>
        /// <param name="quantity">The order quantity.</param>
        /// <param name="orderType">The type of order (e.g., "LIMIT", "MARKET", "STOPMARKET").</param>
        /// <param name="limitPrice">The limit price for Limit orders.</param>
        /// <param name="stopPrice">The stop price for Stop orders.</param>
        /// <param name="timeInForce">The time in force for the order (e.g., "DAY", "GTC").</param>
        /// <param name="oco">The OCO (One-Cancels-Other) identifier, if applicable.</param>
        /// <param name="orderId">The order ID, used for modifying or canceling existing orders.</param>
        /// <param name="tpl">The template name for ATM strategies (Trade Performance Logic), if applicable.</param>
        /// <param name="strategy">The name or identifier of the strategy submitting the order, if applicable.</param>
        /// <returns>An integer status code or identifier. The exact meaning is inferred.</returns>
        /// <remarks>This is a versatile command method. The specific behavior depends on the 'command' parameter and other arguments. This documentation is inferred.</remarks>
        int Command(string command, string account, string instrument, string action, int quantity, string orderType, double limitPrice, double stopPrice, string timeInForce, string oco, string orderId, string tpl, string strategy);

        /// <summary>
        /// Enables or disables order confirmations.
        /// </summary>
        /// <param name="confirm">An integer value, likely 1 to enable confirmations and 0 to disable.</param>
        /// <returns>An integer status code. The exact meaning is inferred.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        int ConfirmOrders(int confirm);

        /// <summary>
        /// Checks the connection status to the NinjaTrader server.
        /// </summary>
        /// <param name="showMessage">An integer value, possibly a flag (0 or 1) to indicate whether to display a message about the connection status.</param>
        /// <returns>An integer indicating connection status (e.g., 1 for connected, 0 for disconnected). The exact meaning is inferred.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        int Connected(int showMessage);

        /// <summary>
        /// Retrieves the filled quantity for a specific order.
        /// </summary>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <returns>The total filled quantity for the order as an integer.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        int Filled(string orderId);

        /// <summary>
        /// Retrieves a double-precision floating-point value associated with the given key.
        /// This could be used for retrieving application settings or other named values.
        /// </summary>
        /// <param name="key">The key identifying the value to retrieve.</param>
        /// <returns>The double value associated with the key. Returns 0.0 if the key is not found (inferred).</returns>
        /// <remarks>This documentation is inferred.</remarks>
        double GetDouble(string key);

        /// <summary>
        /// Retrieves an integer value associated with the given key.
        /// This could be used for retrieving application settings or other named values.
        /// </summary>
        /// <param name="key">The key identifying the value to retrieve.</param>
        /// <returns>The integer value associated with the key. Returns 0 if the key is not found (inferred).</returns>
        /// <remarks>This documentation is inferred.</remarks>
        int GetInt(string key);

        /// <summary>
        /// Retrieves a string value associated with the given key.
        /// This could be used for retrieving application settings or other named values.
        /// </summary>
        /// <param name="key">The key identifying the value to retrieve.</param>
        /// <returns>The string value associated with the key. Returns null or empty if the key is not found (inferred).</returns>
        /// <remarks>This documentation is inferred.</remarks>
        string GetString(string key);

        /// <summary>
        /// Submits information about the last traded price and volume for an instrument.
        /// This might be used in custom data feed implementations or simulated environments.
        /// </summary>
        /// <param name="instrument">The instrument symbol.</param>
        /// <param name="price">The last traded price.</param>
        /// <param name="size">The volume of the last trade.</param>
        /// <returns>An integer status code or identifier. The exact meaning is inferred.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        int Last(string instrument, double price, int size);

        /// <summary>
        /// Submits information about the last traded price and volume during a playback or simulation session.
        /// </summary>
        /// <param name="instrument">The instrument symbol.</param>
        /// <param name="price">The last traded price.</param>
        /// <param name="size">The volume of the last trade.</param>
        /// <param name="timestamp">A string representation of the timestamp for the playback event.</param>
        /// <returns>An integer status code or identifier. The exact meaning is inferred.</returns>
        /// <remarks>This documentation is inferred. Used for replaying or simulating market activity.</remarks>
        int LastPlayback(string instrument, double price, int size, string timestamp);

        /// <summary>
        /// Retrieves a specific type of market data for the given instrument.
        /// </summary>
        /// <param name="instrument">The instrument symbol.</param>
        /// <param name="type">An integer representing the type of market data to retrieve (e.g., current bid, ask, last price). The specific mapping of type values is not known without further documentation.</param>
        /// <returns>The requested market data value as a double. Returns 0.0 if data is unavailable (inferred).</returns>
        /// <remarks>The 'type' parameter likely corresponds to an enum or predefined constants. This documentation is inferred.</remarks>
        double MarketData(string instrument, int type);

        /// <summary>
        /// Retrieves the current market position (e.g., Long, Short, Flat) for the specified instrument and account.
        /// </summary>
        /// <param name="instrument">The instrument symbol.</param>
        /// <param name="account">The account name or identifier.</param>
        /// <returns>An integer representing the market position (e.g., positive for long, negative for short, 0 for flat). The exact convention is inferred.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        int MarketPosition(string instrument, string account);

        /// <summary>
        /// Generates a new, unique order identifier string.
        /// </summary>
        /// <returns>A string representing a new unique order ID.</returns>
        /// <remarks>This documentation is inferred. Useful for placing new orders that require a client-generated ID.</remarks>
        string NewOrderId();

        /// <summary>
        /// Retrieves a list or summary of orders for the specified account.
        /// </summary>
        /// <param name="account">The account name or identifier.</param>
        /// <returns>A string containing order information, possibly in a serialized format like XML or JSON. The exact format is inferred.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        string Orders(string account);

        /// <summary>
        /// Retrieves the current status of a specific order.
        /// </summary>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <returns>A string representing the order status (e.g., "Filled", "Working", "Cancelled"). The exact status strings are inferred.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        string OrderStatus(string orderId);

        /// <summary>
        /// Queries and retrieves information about available instruments.
        /// </summary>
        /// <returns>A string containing instrument information, possibly in a serialized format. The exact format is inferred.</returns>
        /// <remarks>This documentation is inferred. This might return a list of tradable symbols or contract details.</remarks>
        string QueryInstrument();

        /// <summary>
        /// Retrieves the realized profit and loss (PnL) for the specified account.
        /// </summary>
        /// <param name="account">The account name or identifier.</param>
        /// <returns>The realized PnL as a double.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        double RealizedPnL(string account);

        /// <summary>
        /// Configures string allocation behavior, possibly for methods returning strings to native code.
        /// </summary>
        /// <param name="value">An integer value to control string allocation. Its specific meaning is inferred.</param>
        /// <returns>An integer status code. The exact meaning is inferred.</returns>
        /// <remarks>This might relate to pre-allocating buffers for string data returned from the API. This documentation is inferred.</remarks>
        int SetAllocReturnString(int value);

        /// <summary>
        /// Sets the maximum length for strings returned by API methods.
        /// </summary>
        /// <param name="value">The maximum length for returned strings.</param>
        /// <returns>An integer status code. The exact meaning is inferred.</returns>
        /// <remarks>This might be used to prevent buffer overflows when dealing with strings from native code or fixed-size buffers. This documentation is inferred.</remarks>
        int SetMaxReturnStringLength(int value);

        /// <summary>
        /// Sets up and initializes the connection to the NinjaTrader server.
        /// </summary>
        /// <param name="host">The hostname or IP address of the server.</param>
        /// <param name="port">The port number for the server connection.</param>
        /// <returns>An integer status code indicating success or failure of the setup. The exact meaning is inferred.</returns>
        /// <remarks>This method should typically be called before other interaction methods. This documentation is inferred.</remarks>
        int SetUp(string host, int port);

        /// <summary>
        /// Retrieves stop orders associated with a specific strategy.
        /// </summary>
        /// <param name="strategyId">The identifier of the strategy.</param>
        /// <returns>A string containing information about stop orders, possibly in a serialized format. The exact format is inferred.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        string StopOrders(string strategyId);

        /// <summary>
        /// Subscribes to real-time market data for the specified instrument.
        /// </summary>
        /// <param name="instrument">The instrument symbol to subscribe to.</param>
        /// <returns>An integer status code indicating success or failure of the subscription. The exact meaning is inferred.</returns>
        /// <remarks>After successful subscription, the client should start receiving market data updates for this instrument. This documentation is inferred.</remarks>
        int SubscribeMarketData(string instrument);

        /// <summary>
        /// Retrieves a list or summary of strategies associated with the specified account.
        /// </summary>
        /// <param name="account">The account name or identifier.</param>
        /// <returns>A string containing strategy information, possibly in a serialized format. The exact format is inferred.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        string Strategies(string account);

        /// <summary>
        /// Retrieves the current market position held by a specific strategy.
        /// </summary>
        /// <param name="strategyId">The identifier of the strategy.</param>
        /// <returns>An integer representing the strategy's position (e.g., positive for long, negative for short, 0 for flat). The exact convention is inferred.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        int StrategyPosition(string strategyId);

        /// <summary>
        /// Retrieves target orders (e.g., profit targets) associated with a specific strategy.
        /// </summary>
        /// <param name="strategyId">The identifier of the strategy.</param>
        /// <returns>A string containing information about target orders, possibly in a serialized format. The exact format is inferred.</returns>
        /// <remarks>This documentation is inferred.</remarks>
        string TargetOrders(string strategyId);

        /// <summary>
        /// Tears down the connection to the NinjaTrader server and performs cleanup.
        /// </summary>
        /// <returns>An integer status code indicating success or failure of the teardown. The exact meaning is inferred.</returns>
        /// <remarks>This method should be called when the client is finished interacting with the server. This documentation is inferred.</remarks>
        int TearDown();

        /// <summary>
        /// Unsubscribes from real-time market data for the specified instrument.
        /// </summary>
        /// <param name="instrument">The instrument symbol to unsubscribe from.</param>
        /// <returns>An integer status code indicating success or failure of the unsubscription. The exact meaning is inferred.</returns>
        /// <remarks>After unsubscription, the client should stop receiving market data updates for this instrument. This documentation is inferred.</remarks>
        int UnsubscribeMarketData(string instrument);
        #endregion
    }
}

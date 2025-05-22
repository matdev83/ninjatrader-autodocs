[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Position
    {
        #region Properties
        /// <summary>
        /// Gets or sets the StatementDate.
        /// </summary>
        [DataMember]
        public System.DateTime StatementDate { get; set; }
        /// <summary>
        /// Gets or sets the UseFifo4AveragePrice.
        /// </summary>
        [DataMember]
        public bool UseFifo4AveragePrice { get; set; }
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Account Account { get; set; }
        /// <summary>
        /// Gets or sets the AveragePrice.
        /// </summary>
        [DataMember]
        public double AveragePrice { get; set; }
        /// <summary>
        /// Gets or sets the FirstEntry.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Execution FirstEntry { get; set; }
        /// <summary>
        /// Gets or sets the Entries.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Execution[] Entries { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the MarketPosition.
        /// </summary>
        [DataMember]
        public MarketPosition MarketPosition { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public int Quantity { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// BreakEven method.
        /// </summary>
        /// <param name="orders">System.Collections.Generic.ICollection<NinjaTrader.Cbi.Order></param>
        public void BreakEven(System.Collections.Generic.ICollection<NinjaTrader.Cbi.Order> orders)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <returns>System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Position></returns>
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Position> DbGet(NinjaTrader.Cbi.Account account)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="minDate">System.DateTime</param>
        /// <param name="maxDate">System.DateTime</param>
        /// <returns>System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Position></returns>
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Position> DbGet(NinjaTrader.Cbi.Account account, System.DateTime minDate, System.DateTime maxDate)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// AddExecution method.
        /// </summary>
        /// <param name="execution">NinjaTrader.Cbi.Execution</param>
        /// <param name="performance">NinjaTrader.Cbi.SystemPerformance</param>
        public void AddExecution(NinjaTrader.Cbi.Execution execution, NinjaTrader.Cbi.SystemPerformance performance)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Close method.
        /// </summary>
        /// <param name="signalName">string</param>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task Close(string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Close method.
        /// </summary>
        /// <param name="signalName">string</param>
        /// <param name="onBehalfOf">string</param>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task Close(string signalName, string onBehalfOf)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetMarketPrice method.
        /// </summary>
        /// <returns>double</returns>
        public double GetMarketPrice()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetUnrealizedProfitLoss method.
        /// </summary>
        /// <param name="unit">PerformanceUnit</param>
        /// <param name="price">double</param>
        /// <returns>double</returns>
        public double GetUnrealizedProfitLoss(PerformanceUnit unit, double price)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Reverse method.
        /// </summary>
        /// <param name="tif">TimeInForce</param>
        /// <param name="gtdDate">System.DateTime</param>
        public void Reverse(TimeInForce tif, System.DateTime gtdDate)
        {
            // Method implementation goes here
        }
        #endregion
    }
}

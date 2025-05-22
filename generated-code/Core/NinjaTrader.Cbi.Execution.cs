[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Execution
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarIndex.
        /// </summary>
        [DataMember]
        public int BarIndex { get; set; }
        /// <summary>
        /// Gets or sets the BarsInProgress.
        /// </summary>
        [DataMember]
        public int BarsInProgress { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the IsEntry.
        /// </summary>
        [DataMember]
        public bool IsEntry { get; set; }
        /// <summary>
        /// Gets or sets the IsEntryStrategy.
        /// </summary>
        [DataMember]
        public bool IsEntryStrategy { get; set; }
        /// <summary>
        /// Gets or sets the IsExit.
        /// </summary>
        [DataMember]
        public bool IsExit { get; set; }
        /// <summary>
        /// Gets or sets the IsExitStrategy.
        /// </summary>
        [DataMember]
        public bool IsExitStrategy { get; set; }
        /// <summary>
        /// Gets or sets the IsInitialEntry.
        /// </summary>
        [DataMember]
        public bool IsInitialEntry { get; set; }
        /// <summary>
        /// Gets or sets the IsLastExit.
        /// </summary>
        [DataMember]
        public bool IsLastExit { get; set; }
        /// <summary>
        /// Gets or sets the IsSod.
        /// </summary>
        [DataMember]
        public bool IsSod { get; set; }
        /// <summary>
        /// Gets or sets the ServerName.
        /// </summary>
        [DataMember]
        public string ServerName { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Order Order { get; set; }
        /// <summary>
        /// Gets or sets the Position.
        /// </summary>
        [DataMember]
        public int Position { get; set; }
        /// <summary>
        /// Gets or sets the PositionStrategy.
        /// </summary>
        [DataMember]
        public int PositionStrategy { get; set; }
        /// <summary>
        /// Gets or sets the StatementDate.
        /// </summary>
        [DataMember]
        public System.DateTime StatementDate { get; set; }
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Account Account { get; set; }
        /// <summary>
        /// Gets or sets the Commission.
        /// </summary>
        [DataMember]
        public double Commission { get; set; }
        /// <summary>
        /// Gets or sets the Exchange.
        /// </summary>
        [DataMember]
        public Exchange Exchange { get; set; }
        /// <summary>
        /// Gets or sets the ExecutionId.
        /// </summary>
        [DataMember]
        public string ExecutionId { get; set; }
        /// <summary>
        /// Gets or sets the Fee.
        /// </summary>
        [DataMember]
        public double Fee { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the LotSize.
        /// </summary>
        [DataMember]
        public double LotSize { get; set; }
        /// <summary>
        /// Gets or sets the MarketPosition.
        /// </summary>
        [DataMember]
        public MarketPosition MarketPosition { get; set; }
        /// <summary>
        /// Gets or sets the MaxPrice.
        /// </summary>
        [DataMember]
        public double MaxPrice { get; set; }
        /// <summary>
        /// Gets or sets the MinPrice.
        /// </summary>
        [DataMember]
        public double MinPrice { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public string OrderId { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public double Price { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the Rate.
        /// </summary>
        [DataMember]
        public double Rate { get; set; }
        /// <summary>
        /// Gets or sets the Slippage.
        /// </summary>
        [DataMember]
        public double Slippage { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public System.DateTime Time { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// DbAdd method.
        /// </summary>
        public void DbAdd()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="minTime">System.DateTime</param>
        /// <param name="maxTime">System.DateTime</param>
        /// <returns>System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Execution></returns>
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Execution> DbGet(NinjaTrader.Cbi.Account account, System.DateTime minTime, System.DateTime maxTime)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="minTime">System.DateTime</param>
        /// <param name="maxTime">System.DateTime</param>
        /// <returns>System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Execution></returns>
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Execution> DbGet(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, System.DateTime minTime, System.DateTime maxTime)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="accounts">System.Collections.Generic.ICollection<NinjaTrader.Cbi.Account></param>
        /// <param name="minTime">System.DateTime</param>
        /// <param name="maxTime">System.DateTime</param>
        /// <returns>System.Collections.Generic.ICollection<System.Tuple<NinjaTrader.Cbi.Execution, string>></returns>
        public System.Collections.Generic.ICollection<System.Tuple<NinjaTrader.Cbi.Execution, string>> DbGet(System.Collections.Generic.ICollection<NinjaTrader.Cbi.Account> accounts, System.DateTime minTime, System.DateTime maxTime)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbRemove method.
        /// </summary>
        public void DbRemove()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbRemoveAll method.
        /// </summary>
        public void DbRemoveAll()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbUpdateExecutions method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="time">System.DateTime</param>
        public void DbUpdateExecutions(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, System.DateTime time)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Init method.
        /// </summary>
        public void Init()
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
        #endregion
    }
}

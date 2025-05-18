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
        public Int32 BarIndex { get; set; }
        /// <summary>
        /// Gets or sets the BarsInProgress.
        /// </summary>
        [DataMember]
        public Int32 BarsInProgress { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the IsEntry.
        /// </summary>
        [DataMember]
        public Boolean IsEntry { get; set; }
        /// <summary>
        /// Gets or sets the IsEntryStrategy.
        /// </summary>
        [DataMember]
        public Boolean IsEntryStrategy { get; set; }
        /// <summary>
        /// Gets or sets the IsExit.
        /// </summary>
        [DataMember]
        public Boolean IsExit { get; set; }
        /// <summary>
        /// Gets or sets the IsExitStrategy.
        /// </summary>
        [DataMember]
        public Boolean IsExitStrategy { get; set; }
        /// <summary>
        /// Gets or sets the IsInitialEntry.
        /// </summary>
        [DataMember]
        public Boolean IsInitialEntry { get; set; }
        /// <summary>
        /// Gets or sets the IsLastExit.
        /// </summary>
        [DataMember]
        public Boolean IsLastExit { get; set; }
        /// <summary>
        /// Gets or sets the IsSod.
        /// </summary>
        [DataMember]
        public Boolean IsSod { get; set; }
        /// <summary>
        /// Gets or sets the ServerName.
        /// </summary>
        [DataMember]
        public String ServerName { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public Order Order { get; set; }
        /// <summary>
        /// Gets or sets the Position.
        /// </summary>
        [DataMember]
        public Int32 Position { get; set; }
        /// <summary>
        /// Gets or sets the PositionStrategy.
        /// </summary>
        [DataMember]
        public Int32 PositionStrategy { get; set; }
        /// <summary>
        /// Gets or sets the StatementDate.
        /// </summary>
        [DataMember]
        public DateTime StatementDate { get; set; }
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public Account Account { get; set; }
        /// <summary>
        /// Gets or sets the Commission.
        /// </summary>
        [DataMember]
        public Double Commission { get; set; }
        /// <summary>
        /// Gets or sets the Exchange.
        /// </summary>
        [DataMember]
        public Exchange Exchange { get; set; }
        /// <summary>
        /// Gets or sets the ExecutionId.
        /// </summary>
        [DataMember]
        public String ExecutionId { get; set; }
        /// <summary>
        /// Gets or sets the Fee.
        /// </summary>
        [DataMember]
        public Double Fee { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the LotSize.
        /// </summary>
        [DataMember]
        public Double LotSize { get; set; }
        /// <summary>
        /// Gets or sets the MarketPosition.
        /// </summary>
        [DataMember]
        public MarketPosition MarketPosition { get; set; }
        /// <summary>
        /// Gets or sets the MaxPrice.
        /// </summary>
        [DataMember]
        public Double MaxPrice { get; set; }
        /// <summary>
        /// Gets or sets the MinPrice.
        /// </summary>
        [DataMember]
        public Double MinPrice { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public String OrderId { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public Double Price { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public Int32 Quantity { get; set; }
        /// <summary>
        /// Gets or sets the Rate.
        /// </summary>
        [DataMember]
        public Double Rate { get; set; }
        /// <summary>
        /// Gets or sets the Slippage.
        /// </summary>
        [DataMember]
        public Double Slippage { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public DateTime Time { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// DbAdd method.
        /// </summary>
        public Void DbAdd();
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="minTime">DateTime</param>
        /// <param name="maxTime">DateTime</param>
        /// <returns>Collection`1</returns>
        public Collection<Execution> DbGet(Account account, DateTime minTime, DateTime maxTime);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="instrument">Instrument</param>
        /// <param name="minTime">DateTime</param>
        /// <param name="maxTime">DateTime</param>
        /// <returns>Collection`1</returns>
        public Collection<Execution> DbGet(Account account, Instrument instrument, DateTime minTime, DateTime maxTime);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="accounts">ICollection`1</param>
        /// <param name="minTime">DateTime</param>
        /// <param name="maxTime">DateTime</param>
        /// <returns>ICollection`1</returns>
        public ICollection<Tuple<Execution, String>> DbGet(ICollection<Account> accounts, DateTime minTime, DateTime maxTime);
        /// <summary>
        /// DbRemove method.
        /// </summary>
        public Void DbRemove();
        /// <summary>
        /// DbRemoveAll method.
        /// </summary>
        public Void DbRemoveAll();
        /// <summary>
        /// DbUpdateExecutions method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="instrument">Instrument</param>
        /// <param name="time">DateTime</param>
        public Void DbUpdateExecutions(Account account, Instrument instrument, DateTime time);
        /// <summary>
        /// Init method.
        /// </summary>
        public Void Init();
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}

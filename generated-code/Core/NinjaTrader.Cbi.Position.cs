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
        public DateTime StatementDate { get; set; }
        /// <summary>
        /// Gets or sets the UseFifo4AveragePrice.
        /// </summary>
        [DataMember]
        public Boolean UseFifo4AveragePrice { get; set; }
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public Account Account { get; set; }
        /// <summary>
        /// Gets or sets the AveragePrice.
        /// </summary>
        [DataMember]
        public Double AveragePrice { get; set; }
        /// <summary>
        /// Gets or sets the FirstEntry.
        /// </summary>
        [DataMember]
        public Execution FirstEntry { get; set; }
        /// <summary>
        /// Gets or sets the Entries.
        /// </summary>
        [DataMember]
        public Execution[] Entries { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the MarketPosition.
        /// </summary>
        [DataMember]
        public MarketPosition MarketPosition { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public Int32 Quantity { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// BreakEven method.
        /// </summary>
        /// <param name="orders">ICollection`1</param>
        public Void BreakEven(ICollection<Order> orders);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <returns>Collection`1</returns>
        public Collection<Position> DbGet(Account account);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="minDate">DateTime</param>
        /// <param name="maxDate">DateTime</param>
        /// <returns>Collection`1</returns>
        public Collection<Position> DbGet(Account account, DateTime minDate, DateTime maxDate);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// AddExecution method.
        /// </summary>
        /// <param name="execution">Execution</param>
        /// <param name="performance">SystemPerformance</param>
        public Void AddExecution(Execution execution, SystemPerformance performance);
        /// <summary>
        /// Close method.
        /// </summary>
        /// <param name="signalName">String</param>
        /// <returns>Task</returns>
        public Task Close(String signalName);
        /// <summary>
        /// Close method.
        /// </summary>
        /// <param name="signalName">String</param>
        /// <param name="onBehalfOf">String</param>
        /// <returns>Task</returns>
        public Task Close(String signalName, String onBehalfOf);
        /// <summary>
        /// GetMarketPrice method.
        /// </summary>
        /// <returns>Double</returns>
        public Double GetMarketPrice();
        /// <summary>
        /// GetUnrealizedProfitLoss method.
        /// </summary>
        /// <param name="unit">PerformanceUnit</param>
        /// <param name="price">Double</param>
        /// <returns>Double</returns>
        public Double GetUnrealizedProfitLoss(PerformanceUnit unit, Double price);
        /// <summary>
        /// Reverse method.
        /// </summary>
        /// <param name="tif">TimeInForce</param>
        /// <param name="gtdDate">DateTime</param>
        public Void Reverse(TimeInForce tif, DateTime gtdDate);
        #endregion
    }
}

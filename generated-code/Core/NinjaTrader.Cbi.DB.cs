[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class DB
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ConnectionString.
        /// </summary>
        [DataMember]
        public String ConnectionString { get; set; }
        /// <summary>
        /// Gets or sets the Current.
        /// </summary>
        [DataMember]
        public IDbConnection Current { get; set; }
        /// <summary>
        /// Gets or sets the DBDir.
        /// </summary>
        [DataMember]
        public String DBDir { get; set; }
        /// <summary>
        /// Gets or sets the DbFileExtension.
        /// </summary>
        [DataMember]
        public String DbFileExtension { get; set; }
        /// <summary>
        /// Gets or sets the SyncRoot.
        /// </summary>
        [DataMember]
        public Object SyncRoot { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Compact method.
        /// </summary>
        public Void Compact();
        /// <summary>
        /// DoRepairDB method.
        /// </summary>
        public Void DoRepairDB();
        /// <summary>
        /// ExecuteCommand method.
        /// </summary>
        /// <param name="connection">IDbConnection</param>
        /// <param name="commandText">String</param>
        public Void ExecuteCommand(IDbConnection connection, String commandText);
        /// <summary>
        /// NewParameter method.
        /// </summary>
        /// <param name="type">OleDbType</param>
        /// <returns>IDataParameter</returns>
        public IDataParameter NewParameter(OleDbType type);
        /// <summary>
        /// Flush method.
        /// </summary>
        public Void Flush();
        /// <summary>
        /// Persist method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="operation">Operation</param>
        public Void Persist(Account account, Operation operation);
        /// <summary>
        /// Persist method.
        /// </summary>
        /// <param name="execution">Execution</param>
        /// <param name="operation">Operation</param>
        public Void Persist(Execution execution, Operation operation);
        /// <summary>
        /// Persist method.
        /// </summary>
        /// <param name="order">Order</param>
        /// <param name="operation">Operation</param>
        public Void Persist(Order order, Operation operation);
        /// <summary>
        /// Persist method.
        /// </summary>
        /// <param name="e">PositionEventArgs</param>
        public Void Persist(PositionEventArgs e);
        /// <summary>
        /// Persist method.
        /// </summary>
        /// <param name="strategy">StrategyBase</param>
        /// <param name="operation">Operation</param>
        public Void Persist(StrategyBase strategy, Operation operation);
        /// <summary>
        /// Shutdown method.
        /// </summary>
        public Void Shutdown();
        #endregion
    }
}

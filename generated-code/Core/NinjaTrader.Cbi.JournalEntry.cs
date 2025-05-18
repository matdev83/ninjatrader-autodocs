[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class JournalEntry : NotifyPropertyChangedBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Execution.
        /// </summary>
        [DataMember]
        public Execution Execution { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the JournalEntries.
        /// </summary>
        [DataMember]
        public Collection<JournalEntry> JournalEntries { get; set; }
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public String Text { get; set; }
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
        /// DbRemove method.
        /// </summary>
        public Void DbRemove();
        /// <summary>
        /// DbUpdate method.
        /// </summary>
        public Void DbUpdate();
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="journalEntry">JournalEntry</param>
        /// <returns>Boolean</returns>
        public Boolean IsEqual(JournalEntry journalEntry);
        #endregion
    }
}

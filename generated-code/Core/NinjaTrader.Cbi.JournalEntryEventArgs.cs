[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class JournalEntryEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the JournalEntry.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.JournalEntry JournalEntry { get; set; }
        /// <summary>
        /// Gets or sets the Operation.
        /// </summary>
        [DataMember]
        public Operation Operation { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}

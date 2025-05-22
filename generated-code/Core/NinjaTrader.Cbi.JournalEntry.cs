[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class JournalEntry : NinjaTrader.Gui.NotifyPropertyChangedBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Execution.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Execution Execution { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the JournalEntries.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.JournalEntry> JournalEntries { get; set; }
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public string Text { get; set; }
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
        /// DbRemove method.
        /// </summary>
        public void DbRemove()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbUpdate method.
        /// </summary>
        public void DbUpdate()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="journalEntry">NinjaTrader.Cbi.JournalEntry</param>
        /// <returns>bool</returns>
        public bool IsEqual(NinjaTrader.Cbi.JournalEntry journalEntry)
        {
            // Method implementation goes here
        }
        #endregion
    }
}

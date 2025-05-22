[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class DelayedDataArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}

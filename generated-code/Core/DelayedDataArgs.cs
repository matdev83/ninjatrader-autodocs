[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class DelayedDataArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}

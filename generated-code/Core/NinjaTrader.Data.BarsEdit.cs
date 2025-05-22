[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsEdit : NinjaTrader.Gui.NotifyPropertyChangedBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Ask.
        /// </summary>
        [DataMember]
        public double Ask { get; set; }
        /// <summary>
        /// Gets or sets the Bid.
        /// </summary>
        [DataMember]
        public double Bid { get; set; }
        /// <summary>
        /// Gets or sets the Close.
        /// </summary>
        [DataMember]
        public double Close { get; set; }
        /// <summary>
        /// Gets or sets the High.
        /// </summary>
        [DataMember]
        public double High { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the IsEdited.
        /// </summary>
        [DataMember]
        public bool IsEdited { get; set; }
        /// <summary>
        /// Gets or sets the IsHidden.
        /// </summary>
        [DataMember]
        public bool IsHidden { get; set; }
        /// <summary>
        /// Gets or sets the Low.
        /// </summary>
        [DataMember]
        public double Low { get; set; }
        /// <summary>
        /// Gets or sets the Open.
        /// </summary>
        [DataMember]
        public double Open { get; set; }
        /// <summary>
        /// Gets or sets the Operation.
        /// </summary>
        [DataMember]
        public Operation? Operation { get; set; }
        /// <summary>
        /// Gets or sets the OriginalAsk.
        /// </summary>
        [DataMember]
        public double OriginalAsk { get; set; }
        /// <summary>
        /// Gets or sets the OriginalBid.
        /// </summary>
        [DataMember]
        public double OriginalBid { get; set; }
        /// <summary>
        /// Gets or sets the OriginalClose.
        /// </summary>
        [DataMember]
        public double OriginalClose { get; set; }
        /// <summary>
        /// Gets or sets the OriginalHigh.
        /// </summary>
        [DataMember]
        public double OriginalHigh { get; set; }
        /// <summary>
        /// Gets or sets the OriginalLow.
        /// </summary>
        [DataMember]
        public double OriginalLow { get; set; }
        /// <summary>
        /// Gets or sets the OriginalOpen.
        /// </summary>
        [DataMember]
        public double OriginalOpen { get; set; }
        /// <summary>
        /// Gets or sets the OriginalTime.
        /// </summary>
        [DataMember]
        public System.DateTime OriginalTime { get; set; }
        /// <summary>
        /// Gets or sets the OriginalVolume.
        /// </summary>
        [DataMember]
        public long OriginalVolume { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public System.DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [DataMember]
        public DataType Type { get; set; }
        /// <summary>
        /// Gets or sets the Volume.
        /// </summary>
        [DataMember]
        public long Volume { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// NTStringToDateTime method.
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime NTStringToDateTime(string value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// TimeToNTString method.
        /// </summary>
        /// <param name="time">System.DateTime</param>
        /// <param name="includeDate">bool</param>
        /// <returns>string</returns>
        public string TimeToNTString(System.DateTime time, bool includeDate)
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

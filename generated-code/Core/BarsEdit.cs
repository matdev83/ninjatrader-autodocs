[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsEdit : NotifyPropertyChangedBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Ask.
        /// </summary>
        [DataMember]
        public Double Ask { get; set; }
        /// <summary>
        /// Gets or sets the Bid.
        /// </summary>
        [DataMember]
        public Double Bid { get; set; }
        /// <summary>
        /// Gets or sets the Close.
        /// </summary>
        [DataMember]
        public Double Close { get; set; }
        /// <summary>
        /// Gets or sets the High.
        /// </summary>
        [DataMember]
        public Double High { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the IsEdited.
        /// </summary>
        [DataMember]
        public Boolean IsEdited { get; set; }
        /// <summary>
        /// Gets or sets the IsHidden.
        /// </summary>
        [DataMember]
        public Boolean IsHidden { get; set; }
        /// <summary>
        /// Gets or sets the Low.
        /// </summary>
        [DataMember]
        public Double Low { get; set; }
        /// <summary>
        /// Gets or sets the Open.
        /// </summary>
        [DataMember]
        public Double Open { get; set; }
        /// <summary>
        /// Gets or sets the Operation.
        /// </summary>
        [DataMember]
        public Nullable<Operation> Operation { get; set; }
        /// <summary>
        /// Gets or sets the OriginalAsk.
        /// </summary>
        [DataMember]
        public Double OriginalAsk { get; set; }
        /// <summary>
        /// Gets or sets the OriginalBid.
        /// </summary>
        [DataMember]
        public Double OriginalBid { get; set; }
        /// <summary>
        /// Gets or sets the OriginalClose.
        /// </summary>
        [DataMember]
        public Double OriginalClose { get; set; }
        /// <summary>
        /// Gets or sets the OriginalHigh.
        /// </summary>
        [DataMember]
        public Double OriginalHigh { get; set; }
        /// <summary>
        /// Gets or sets the OriginalLow.
        /// </summary>
        [DataMember]
        public Double OriginalLow { get; set; }
        /// <summary>
        /// Gets or sets the OriginalOpen.
        /// </summary>
        [DataMember]
        public Double OriginalOpen { get; set; }
        /// <summary>
        /// Gets or sets the OriginalTime.
        /// </summary>
        [DataMember]
        public DateTime OriginalTime { get; set; }
        /// <summary>
        /// Gets or sets the OriginalVolume.
        /// </summary>
        [DataMember]
        public Int64 OriginalVolume { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [DataMember]
        public DataType Type { get; set; }
        /// <summary>
        /// Gets or sets the Volume.
        /// </summary>
        [DataMember]
        public Int64 Volume { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// NTStringToDateTime method.
        /// </summary>
        /// <param name="value">String</param>
        /// <returns>DateTime</returns>
        public DateTime NTStringToDateTime(String value);
        /// <summary>
        /// TimeToNTString method.
        /// </summary>
        /// <param name="time">DateTime</param>
        /// <param name="includeDate">Boolean</param>
        /// <returns>String</returns>
        public String TimeToNTString(DateTime time, Boolean includeDate);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}

[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class AlertEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DataSeries.
        /// </summary>
        [DataMember]
        public String DataSeries { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public String Period { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public String Id { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [DataMember]
        public String Message { get; set; }
        /// <summary>
        /// Gets or sets the Priority.
        /// </summary>
        [DataMember]
        public Priority Priority { get; set; }
        /// <summary>
        /// Gets or sets the Foreground.
        /// </summary>
        [DataMember]
        public Brush Foreground { get; set; }
        /// <summary>
        /// Gets or sets the Background.
        /// </summary>
        [DataMember]
        public Brush Background { get; set; }
        /// <summary>
        /// Gets or sets the Source.
        /// </summary>
        [DataMember]
        public Object Source { get; set; }
        /// <summary>
        /// Gets or sets the SourceTabName.
        /// </summary>
        [DataMember]
        public String SourceTabName { get; set; }
        /// <summary>
        /// Gets or sets the SoundLocation.
        /// </summary>
        [DataMember]
        public String SoundLocation { get; set; }
        /// <summary>
        /// Gets or sets the OwnerAlert.
        /// </summary>
        [DataMember]
        public Alert OwnerAlert { get; set; }
        /// <summary>
        /// Gets or sets the OwnerName.
        /// </summary>
        [DataMember]
        public String OwnerName { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the Workspace.
        /// </summary>
        [DataMember]
        public String Workspace { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="copy">AlertEventArgs</param>
        public Void CopyTo(AlertEventArgs copy);
        #endregion
    }
}

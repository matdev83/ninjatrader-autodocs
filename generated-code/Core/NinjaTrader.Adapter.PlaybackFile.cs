[Serializable]
[DataContract]
namespace NinjaTrader.Adapter
{
    public partial class PlaybackFile
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Filename.
        /// </summary>
        [DataMember]
        public string Filename { get; set; }
        /// <summary>
        /// Gets or sets the From.
        /// </summary>
        [DataMember]
        public System.DateTime From { get; set; }
        /// <summary>
        /// Gets or sets the To.
        /// </summary>
        [DataMember]
        public System.DateTime To { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}

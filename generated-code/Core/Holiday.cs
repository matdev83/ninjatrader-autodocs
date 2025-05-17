[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class Holiday
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public String Description { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}

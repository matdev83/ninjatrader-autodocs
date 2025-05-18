[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class SkipOnCopyToAttribute : Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the SkipOnCopyTo.
        /// </summary>
        [DataMember]
        public Boolean SkipOnCopyTo { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}

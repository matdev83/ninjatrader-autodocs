[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class SkipOnCopyToAttribute : System.Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the SkipOnCopyTo.
        /// </summary>
        [DataMember]
        public bool SkipOnCopyTo { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}

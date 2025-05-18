[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class MigrateError
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ErrorText.
        /// </summary>
        [DataMember]
        public String ErrorText { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}

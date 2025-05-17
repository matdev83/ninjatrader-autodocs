[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.ShareServices
{
    public partial class ShareServicePreconfiguredProviderConverter : StringConverter
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// GetStandardValues method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <returns>StandardValuesCollection</returns>
        public StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
        /// <summary>
        /// GetStandardValuesExclusive method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <returns>Boolean</returns>
        public Boolean GetStandardValuesExclusive(ITypeDescriptorContext context);
        /// <summary>
        /// GetStandardValuesSupported method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <returns>Boolean</returns>
        public Boolean GetStandardValuesSupported(ITypeDescriptorContext context);
        #endregion
    }
}

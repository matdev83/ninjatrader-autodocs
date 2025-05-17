[Serializable]
[DataContract]
namespace NinjaTrader.ServerAtm
{
    public partial class TemplateChangedArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the TemplateName.
        /// </summary>
        [DataMember]
        public String TemplateName { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}

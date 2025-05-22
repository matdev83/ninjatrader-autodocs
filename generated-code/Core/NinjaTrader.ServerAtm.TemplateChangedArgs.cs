[Serializable]
[DataContract]
namespace NinjaTrader.ServerAtm
{
    public partial class TemplateChangedArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the TemplateName.
        /// </summary>
        [DataMember]
        public string TemplateName { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}

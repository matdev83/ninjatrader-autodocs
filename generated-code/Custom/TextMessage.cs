[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.ShareServices
{
    public partial class TextMessage : ShareService, IPreconfiguredProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        /// <summary>
        /// Gets or sets the PreconfiguredNames.
        /// </summary>
        [DataMember]
        public List<String> PreconfiguredNames { get; set; }
        /// <summary>
        /// Gets or sets the SelectedPreconfiguredSetting.
        /// </summary>
        [DataMember]
        public String SelectedPreconfiguredSetting { get; set; }
        /// <summary>
        /// Gets or sets the Email.
        /// </summary>
        [DataMember]
        public String Email { get; set; }
        /// <summary>
        /// Gets or sets the MmsAddress.
        /// </summary>
        [DataMember]
        public String MmsAddress { get; set; }
        /// <summary>
        /// Gets or sets the PhoneNumber.
        /// </summary>
        [DataMember]
        public Int64 PhoneNumber { get; set; }
        /// <summary>
        /// Gets or sets the SmsAddress.
        /// </summary>
        [DataMember]
        public String SmsAddress { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        /// <summary>
        /// OnShare method.
        /// </summary>
        /// <param name="text">String</param>
        /// <param name="imageFilePath">String</param>
        /// <returns>Task</returns>
        public Task OnShare(String text, String imageFilePath);
        /// <summary>
        /// ApplyPreconfiguredSettings method.
        /// </summary>
        /// <param name="name">String</param>
        public Void ApplyPreconfiguredSettings(String name);
        #endregion
    }
}

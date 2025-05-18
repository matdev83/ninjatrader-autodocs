[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.SuperDomColumns
{
    public partial class Notes : SuperDomColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BackColor.
        /// </summary>
        [DataMember]
        public Brush BackColor { get; set; }
        /// <summary>
        /// Gets or sets the BackBrushSerialize.
        /// </summary>
        [DataMember]
        public String BackBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ForeColor.
        /// </summary>
        [DataMember]
        public Brush ForeColor { get; set; }
        /// <summary>
        /// Gets or sets the ForeColorSerialize.
        /// </summary>
        [DataMember]
        public String ForeColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the NotesSerializable.
        /// </summary>
        [DataMember]
        public List<String> NotesSerializable { get; set; }
        /// <summary>
        /// Gets or sets the PriceStringValues.
        /// </summary>
        [DataMember]
        public ConcurrentDictionary<Double, String> PriceStringValues { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// DisplayTextBoxExecuted method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">ExecutedRoutedEventArgs</param>
        public Void DisplayTextBoxExecuted(Object sender, ExecutedRoutedEventArgs e);
        /// <summary>
        /// CopyCustomData method.
        /// </summary>
        /// <param name="newInstance">SuperDomColumn</param>
        public Void CopyCustomData(SuperDomColumn newInstance);
        /// <summary>
        /// OnRestoreValues method.
        /// </summary>
        public Void OnRestoreValues();
        /// <summary>
        /// SetBindings method.
        /// </summary>
        public Void SetBindings();
        #endregion
    }
}

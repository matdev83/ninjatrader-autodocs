[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class PropertyEditorAttribute : Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EditorType.
        /// </summary>
        [DataMember]
        public String EditorType { get; set; }
        /// <summary>
        /// Gets or sets the Filter.
        /// </summary>
        [DataMember]
        public String Filter { get; set; }
        /// <summary>
        /// Gets or sets the InitialDirectory.
        /// </summary>
        [DataMember]
        public String InitialDirectory { get; set; }
        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        [DataMember]
        public String Title { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 GetHashCode();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object obj);
        #endregion
    }
}

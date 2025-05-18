[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class CategoryEditorAttribute : Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EditorType.
        /// </summary>
        [DataMember]
        public String EditorType { get; set; }
        /// <summary>
        /// Gets or sets the CategoryName.
        /// </summary>
        [DataMember]
        public String CategoryName { get; set; }
        /// <summary>
        /// Gets or sets the ResourceType.
        /// </summary>
        [DataMember]
        public Type ResourceType { get; set; }
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

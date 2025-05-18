[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class PropertyDescriptorExtended : PropertyDescriptor
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ComponentType.
        /// </summary>
        [DataMember]
        public Type ComponentType { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the IsReadOnly.
        /// </summary>
        [DataMember]
        public Boolean IsReadOnly { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the PropertyType.
        /// </summary>
        [DataMember]
        public Type PropertyType { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CanResetValue method.
        /// </summary>
        /// <param name="component">Object</param>
        /// <returns>Boolean</returns>
        public Boolean CanResetValue(Object component);
        /// <summary>
        /// GetValue method.
        /// </summary>
        /// <param name="component">Object</param>
        /// <returns>Object</returns>
        public Object GetValue(Object component);
        /// <summary>
        /// ResetValue method.
        /// </summary>
        /// <param name="component">Object</param>
        public Void ResetValue(Object component);
        /// <summary>
        /// SetValue method.
        /// </summary>
        /// <param name="component">Object</param>
        /// <param name="value">Object</param>
        public Void SetValue(Object component, Object value);
        /// <summary>
        /// ShouldSerializeValue method.
        /// </summary>
        /// <param name="component">Object</param>
        /// <returns>Boolean</returns>
        public Boolean ShouldSerializeValue(Object component);
        #endregion
    }
}

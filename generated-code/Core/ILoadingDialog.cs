namespace NinjaTrader.Gui
{
    public partial interface ILoadingDialog
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ActionButtonText.
        /// </summary>
        [DataMember]
        public String ActionButtonText { get; set; }
        /// <summary>
        /// Gets or sets the Caption.
        /// </summary>
        [DataMember]
        public String Caption { get; set; }
        /// <summary>
        /// Gets or sets the DefaultFileName.
        /// </summary>
        [DataMember]
        public String DefaultFileName { get; set; }
        /// <summary>
        /// Gets or sets the Directory.
        /// </summary>
        [DataMember]
        public String Directory { get; set; }
        /// <summary>
        /// Gets or sets the FileFilter.
        /// </summary>
        [DataMember]
        public String FileFilter { get; set; }
        /// <summary>
        /// Gets or sets the FileAction.
        /// </summary>
        [DataMember]
        public FileAction FileAction { get; set; }
        /// <summary>
        /// Gets or sets the FileName.
        /// </summary>
        [DataMember]
        public String FileName { get; set; }
        /// <summary>
        /// Gets or sets the FileNames.
        /// </summary>
        [DataMember]
        public String[] FileNames { get; set; }
        /// <summary>
        /// Gets or sets the IsFullBrowsingAllowed.
        /// </summary>
        [DataMember]
        public Boolean IsFullBrowsingAllowed { get; set; }
        /// <summary>
        /// Gets or sets the IsBreadcrumbVisible.
        /// </summary>
        [DataMember]
        public Boolean IsBreadcrumbVisible { get; set; }
        /// <summary>
        /// Gets or sets the IsFilterVisible.
        /// </summary>
        [DataMember]
        public Boolean IsFilterVisible { get; set; }
        /// <summary>
        /// Gets or sets the IsMultiSelectEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsMultiSelectEnabled { get; set; }
        /// <summary>
        /// Gets or sets the Owner.
        /// </summary>
        [DataMember]
        public Window Owner { get; set; }
        /// <summary>
        /// Gets or sets the ValidationCallback.
        /// </summary>
        [DataMember]
        public Func<String, String> ValidationCallback { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ShowDialog method.
        /// </summary>
        /// <returns>Nullable`1</returns>
        public Nullable<Boolean> ShowDialog();
        #endregion
    }
}

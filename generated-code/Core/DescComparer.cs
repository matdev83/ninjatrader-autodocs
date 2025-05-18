[Serializable]
[DataContract]
    public partial class DescComparer : IComparer<Double>
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Compare method.
        /// </summary>
        /// <param name="x">Double</param>
        /// <param name="y">Double</param>
        /// <returns>Int32</returns>
        public Int32 Compare(Double x, Double y);
        #endregion
    }

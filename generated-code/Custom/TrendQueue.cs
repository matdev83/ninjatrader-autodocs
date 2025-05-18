[Serializable]
[DataContract]
    public partial class TrendQueue : Queue<TrendRay>
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Enqueue method.
        /// </summary>
        /// <param name="trend">TrendRay</param>
        public Void Enqueue(TrendRay trend);
        #endregion
    }

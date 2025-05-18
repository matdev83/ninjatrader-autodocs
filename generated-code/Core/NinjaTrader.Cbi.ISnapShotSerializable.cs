namespace NinjaTrader.Cbi
{
    public partial interface ISnapShotSerializable
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">Boolean</param>
        public Void SnapShotPersist(Boolean updateVersion);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}

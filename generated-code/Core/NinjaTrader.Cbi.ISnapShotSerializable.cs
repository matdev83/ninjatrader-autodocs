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
        /// <param name="updateVersion">bool</param>
        public void SnapShotPersist(bool updateVersion);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString();
        #endregion
    }
}

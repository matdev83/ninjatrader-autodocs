[Serializable]
[DataContract]
namespace NinjaTrader.FIX
{
    public partial class FixMessage
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Append method.
        /// </summary>
        /// <param name="tag">String</param>
        /// <param name="value">Char</param>
        public Void Append(String tag, Char value);
        /// <summary>
        /// Append method.
        /// </summary>
        /// <param name="tag">String</param>
        /// <param name="value">Double</param>
        public Void Append(String tag, Double value);
        /// <summary>
        /// Append method.
        /// </summary>
        /// <param name="tag">String</param>
        /// <param name="value">Int32</param>
        public Void Append(String tag, Int32 value);
        /// <summary>
        /// Append method.
        /// </summary>
        /// <param name="tag">String</param>
        /// <param name="value">String</param>
        public Void Append(String tag, String value);
        /// <summary>
        /// FillFixFrame method.
        /// </summary>
        /// <param name="fixVersion">String</param>
        /// <param name="msgType">String</param>
        /// <param name="targetCompID">String</param>
        /// <param name="senderCompID">String</param>
        /// <param name="sendMsgSeqNum">Int32&</param>
        public Void FillFixFrame(String fixVersion, String msgType, String targetCompID, String senderCompID, Int32& sendMsgSeqNum);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}

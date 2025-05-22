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
        /// <param name="tag">string</param>
        /// <param name="value">char</param>
        public void Append(string tag, char value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Append method.
        /// </summary>
        /// <param name="tag">string</param>
        /// <param name="value">double</param>
        public void Append(string tag, double value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Append method.
        /// </summary>
        /// <param name="tag">string</param>
        /// <param name="value">int</param>
        public void Append(string tag, int value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Append method.
        /// </summary>
        /// <param name="tag">string</param>
        /// <param name="value">string</param>
        public void Append(string tag, string value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// FillFixFrame method.
        /// </summary>
        /// <param name="fixVersion">string</param>
        /// <param name="msgType">string</param>
        /// <param name="targetCompID">string</param>
        /// <param name="senderCompID">string</param>
        /// <param name="sendMsgSeqNum">System.Int32&</param>
        public void FillFixFrame(string fixVersion, string msgType, string targetCompID, string senderCompID, System.Int32& sendMsgSeqNum)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}

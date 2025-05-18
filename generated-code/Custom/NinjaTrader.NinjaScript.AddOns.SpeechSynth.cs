[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.AddOns
{
    public partial class SpeechSynth
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// GetInstance method.
        /// </summary>
        /// <returns>SpeechSynth</returns>
        public SpeechSynth GetInstance();
        /// <summary>
        /// PlayTTS method.
        /// </summary>
        /// <param name="textToSpeak">String</param>
        public Void PlayTTS(String textToSpeak);
        /// <summary>
        /// PlayTTS method.
        /// </summary>
        /// <param name="instrumentFullName">String</param>
        /// <param name="text">String</param>
        public Void PlayTTS(String instrumentFullName, String text);
        #endregion
    }
}

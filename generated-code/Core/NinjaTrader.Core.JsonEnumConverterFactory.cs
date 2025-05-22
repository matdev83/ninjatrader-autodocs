[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class JsonEnumConverterFactory : System.Text.Json.Serialization.JsonConverterFactory
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// CanConvert method.
        /// </summary>
        /// <param name="typeToConvert">System.Type</param>
        /// <returns>bool</returns>
        public bool CanConvert(System.Type typeToConvert)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CreateConverter method.
        /// </summary>
        /// <param name="typeToConvert">System.Type</param>
        /// <param name="options">System.Text.Json.JsonSerializerOptions</param>
        /// <returns>System.Text.Json.Serialization.JsonConverter</returns>
        public System.Text.Json.Serialization.JsonConverter CreateConverter(System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
        {
            // Method implementation goes here
        }
        #endregion
    }
}

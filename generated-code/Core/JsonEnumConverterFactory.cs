[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class JsonEnumConverterFactory : JsonConverterFactory
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// CanConvert method.
        /// </summary>
        /// <param name="typeToConvert">Type</param>
        /// <returns>Boolean</returns>
        public Boolean CanConvert(Type typeToConvert);
        /// <summary>
        /// CreateConverter method.
        /// </summary>
        /// <param name="typeToConvert">Type</param>
        /// <param name="options">JsonSerializerOptions</param>
        /// <returns>JsonConverter</returns>
        public JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options);
        #endregion
    }
}

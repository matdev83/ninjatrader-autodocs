[Serializable]
[DataContract]
namespace NinjaTrader.Code
{
    public partial class LegacyCompiler
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Compile method.
        /// </summary>
        /// <param name="checkCompileOnly">Boolean</param>
        /// <param name="debugBuild">Boolean</param>
        /// <param name="filesToIgnore">IEnumerable`1</param>
        /// <param name="filesInTmp">IEnumerable`1</param>
        /// <returns>CompilerResults</returns>
        public CompilerResults Compile(Boolean checkCompileOnly, Boolean debugBuild, IEnumerable<String> filesToIgnore, IEnumerable<String> filesInTmp);
        /// <summary>
        /// HasCompileErrors method.
        /// </summary>
        /// <param name="result">CompilerResults</param>
        /// <returns>Boolean</returns>
        public Boolean HasCompileErrors(CompilerResults result);
        /// <summary>
        /// EmbedNeutralCultureResources method.
        /// </summary>
        /// <param name="compileParameters">CompilerParameters</param>
        /// <param name="rootCustomDir">String</param>
        /// <param name="tmpDir">String</param>
        public Void EmbedNeutralCultureResources(CompilerParameters compileParameters, String rootCustomDir, String tmpDir);
        #endregion
    }
}

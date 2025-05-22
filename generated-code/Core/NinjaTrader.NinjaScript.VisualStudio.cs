[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class VisualStudio
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// UpdateVisualStudioSolution method.
        /// </summary>
        /// <param name="vsProjectFileName">string</param>
        public void UpdateVisualStudioSolution(string vsProjectFileName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateVisualStudioSolutionFiles method.
        /// </summary>
        /// <param name="vsProjectFileName">string</param>
        /// <param name="changedFiles">System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Operation>></param>
        public void UpdateVisualStudioSolutionFiles(string vsProjectFileName, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Operation>> changedFiles)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateVisualStudioSolutionRenames method.
        /// </summary>
        /// <param name="vsProjectFileName">string</param>
        /// <param name="renamedFiles">System.Collections.Generic.IEnumerable<System.Tuple<string, string>></param>
        public void UpdateVisualStudioSolutionRenames(string vsProjectFileName, System.Collections.Generic.IEnumerable<System.Tuple<string, string>> renamedFiles)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateVisualStudioResourceFiles method.
        /// </summary>
        /// <param name="vsProjectFileName">string</param>
        public void UpdateVisualStudioResourceFiles(string vsProjectFileName)
        {
            // Method implementation goes here
        }
        #endregion
    }
}

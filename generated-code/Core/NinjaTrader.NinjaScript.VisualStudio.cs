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
        /// <param name="vsProjectFileName">String</param>
        public Void UpdateVisualStudioSolution(String vsProjectFileName);
        /// <summary>
        /// UpdateVisualStudioSolutionFiles method.
        /// </summary>
        /// <param name="vsProjectFileName">String</param>
        /// <param name="changedFiles">IEnumerable`1</param>
        public Void UpdateVisualStudioSolutionFiles(String vsProjectFileName, IEnumerable<KeyValuePair<String, Operation>> changedFiles);
        /// <summary>
        /// UpdateVisualStudioSolutionRenames method.
        /// </summary>
        /// <param name="vsProjectFileName">String</param>
        /// <param name="renamedFiles">IEnumerable`1</param>
        public Void UpdateVisualStudioSolutionRenames(String vsProjectFileName, IEnumerable<Tuple<String, String>> renamedFiles);
        /// <summary>
        /// UpdateVisualStudioResourceFiles method.
        /// </summary>
        /// <param name="vsProjectFileName">String</param>
        public Void UpdateVisualStudioResourceFiles(String vsProjectFileName);
        #endregion
    }
}

[Serializable]
[DataContract]
namespace NinjaTrader.Code
{
    public partial class Compiler
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AssemblyToLoad.
        /// </summary>
        [DataMember]
        public String AssemblyToLoad { get; set; }
        /// <summary>
        /// Gets or sets the CachedTime.
        /// </summary>
        [DataMember]
        public DateTime CachedTime { get; set; }
        /// <summary>
        /// Gets or sets the References.
        /// </summary>
        [DataMember]
        public Collection<String> References { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CollapseSystemDirectories method.
        /// </summary>
        /// <param name="originalList">IList`1</param>
        /// <returns>ICollection`1</returns>
        public ICollection<String> CollapseSystemDirectories(IList<String> originalList);
        /// <summary>
        /// RemoveCompilerReference method.
        /// </summary>
        /// <param name="name">String</param>
        public Void RemoveCompilerReference(String name);
        /// <summary>
        /// BuildReferences method.
        /// </summary>
        /// <param name="stringReferences">IEnumerable`1</param>
        /// <returns>Collection`1</returns>
        public Collection<PortableExecutableReference> BuildReferences(IEnumerable<String> stringReferences);
        /// <summary>
        /// Compile method.
        /// </summary>
        /// <param name="checkCompileOnly">Boolean</param>
        /// <param name="debugBuild">Boolean</param>
        /// <param name="filesToIgnore">IEnumerable`1</param>
        /// <param name="filesInTmp">IEnumerable`1</param>
        /// <returns>EmitResult</returns>
        public EmitResult Compile(Boolean checkCompileOnly, Boolean debugBuild, IEnumerable<String> filesToIgnore, IEnumerable<String> filesInTmp);
        /// <summary>
        /// GetNeutralCultureResources method.
        /// </summary>
        /// <param name="rootCustomDir">String</param>
        /// <param name="tmpDir">String</param>
        /// <returns>ResourceDescription</returns>
        public ResourceDescription GetNeutralCultureResources(String rootCustomDir, String tmpDir);
        /// <summary>
        /// ExpandSystemDirs method.
        /// </summary>
        /// <param name="origList">IEnumerable`1</param>
        /// <returns>List`1</returns>
        public List<String> ExpandSystemDirs(IEnumerable<String> origList);
        /// <summary>
        /// GetAssemblySubfiles method.
        /// </summary>
        /// <param name="file">String</param>
        /// <returns>Collection`1</returns>
        public Collection<String> GetAssemblySubfiles(String file);
        /// <summary>
        /// GetCustomFiles method.
        /// </summary>
        /// <param name="rootDir">String</param>
        /// <param name="includeIgnored">Boolean</param>
        /// <param name="includeXaml">Boolean</param>
        /// <returns>IEnumerable`1</returns>
        public IEnumerable<String> GetCustomFiles(String rootDir, Boolean includeIgnored, Boolean includeXaml);
        /// <summary>
        /// GetNinjaScriptSubfiles method.
        /// </summary>
        /// <param name="file">String</param>
        /// <returns>Collection`1</returns>
        public Collection<String> GetNinjaScriptSubfiles(String file);
        /// <summary>
        /// GenerateSatelliteAssembly method.
        /// </summary>
        /// <param name="assemblyName">String</param>
        /// <param name="resxFiles">IEnumerable`1</param>
        /// <param name="cultureCode">String</param>
        /// <param name="baseOutputDir">String</param>
        public Void GenerateSatelliteAssembly(String assemblyName, IEnumerable<String> resxFiles, String cultureCode, String baseOutputDir);
        #endregion
    }
}

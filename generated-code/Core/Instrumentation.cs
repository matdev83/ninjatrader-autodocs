[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class Instrumentation
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// IsActivityTypeEnabled method.
        /// </summary>
        /// <param name="activityType">ActivityType</param>
        /// <returns>Boolean</returns>
        public Boolean IsActivityTypeEnabled(ActivityType activityType);
        /// <summary>
        /// LogActivity method.
        /// </summary>
        /// <param name="activityType">ActivityType</param>
        /// <param name="errorCode">ErrorCode</param>
        /// <param name="subtype">String</param>
        /// <param name="exception">Exception</param>
        /// <param name="errorMessage">String</param>
        public Void LogActivity(ActivityType activityType, ErrorCode errorCode, String subtype, Exception exception, String errorMessage);
        #endregion
    }
}

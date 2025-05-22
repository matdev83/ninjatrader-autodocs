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
        /// <returns>bool</returns>
        public bool IsActivityTypeEnabled(ActivityType activityType)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// LogActivity method.
        /// </summary>
        /// <param name="activityType">ActivityType</param>
        /// <param name="errorCode">ErrorCode</param>
        /// <param name="subtype">string</param>
        /// <param name="exception">System.Exception</param>
        /// <param name="errorMessage">string</param>
        public void LogActivity(ActivityType activityType, ErrorCode errorCode, string subtype, System.Exception exception, string errorMessage)
        {
            // Method implementation goes here
        }
        #endregion
    }
}

[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class AtmStrategy : NinjaTrader.NinjaScript.StrategyBase, NinjaTrader.NinjaScript.IAtmStrategy, NinjaTrader.NinjaScript.IDisplayNameProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AtmSelector.
        /// </summary>
        [DataMember]
        public string AtmSelector { get; set; }
        /// <summary>
        /// Gets or sets the ModifyInnerBracket.
        /// </summary>
        [DataMember]
        public bool ModifyInnerBracket { get; set; }
        /// <summary>
        /// Gets or sets the ModifyNearestBracket.
        /// </summary>
        [DataMember]
        public bool ModifyNearestBracket { get; set; }
        /// <summary>
        /// Gets or sets the OnBehalfOf.
        /// </summary>
        [DataMember]
        public string OnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the ReverseAtStopStrategyId.
        /// </summary>
        [DataMember]
        public long ReverseAtStopStrategyId { get; set; }
        /// <summary>
        /// Gets or sets the ReverseAtTargetStrategyId.
        /// </summary>
        [DataMember]
        public long ReverseAtTargetStrategyId { get; set; }
        /// <summary>
        /// Gets or sets the ShadowStrategyStrategyId.
        /// </summary>
        [DataMember]
        public long ShadowStrategyStrategyId { get; set; }
        /// <summary>
        /// Gets or sets the ShadowTemplate.
        /// </summary>
        [DataMember]
        public string ShadowTemplate { get; set; }
        /// <summary>
        /// Gets or sets the Brackets.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Bracket[] Brackets { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode.
        /// </summary>
        [DataMember]
        public CalculationMode CalculationMode { get; set; }
        /// <summary>
        /// Gets or sets the ChaseLimit.
        /// </summary>
        [DataMember]
        public double ChaseLimit { get; set; }
        /// <summary>
        /// Gets or sets the DisplayNameExtended.
        /// </summary>
        [DataMember]
        public string DisplayNameExtended { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the EntryQuantity.
        /// </summary>
        [DataMember]
        public int EntryQuantity { get; set; }
        /// <summary>
        /// Gets or sets the InitialEntryOrder.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Order InitialEntryOrder { get; set; }
        /// <summary>
        /// Gets or sets the InitialTickSize.
        /// </summary>
        [DataMember]
        public double InitialTickSize { get; set; }
        /// <summary>
        /// Gets or sets the IsChase.
        /// </summary>
        [DataMember]
        public bool IsChase { get; set; }
        /// <summary>
        /// Gets or sets the IsChaseIfTouched.
        /// </summary>
        [DataMember]
        public bool IsChaseIfTouched { get; set; }
        /// <summary>
        /// Gets or sets the IsTargetChase.
        /// </summary>
        [DataMember]
        public bool IsTargetChase { get; set; }
        /// <summary>
        /// Gets or sets the ReverseAtStop.
        /// </summary>
        [DataMember]
        public bool ReverseAtStop { get; set; }
        /// <summary>
        /// Gets or sets the ReverseAtTarget.
        /// </summary>
        [DataMember]
        public bool ReverseAtTarget { get; set; }
        /// <summary>
        /// Gets or sets the UseMitForProfit.
        /// </summary>
        [DataMember]
        public bool UseMitForProfit { get; set; }
        /// <summary>
        /// Gets or sets the UseStopLimitForStopLossOrders.
        /// </summary>
        [DataMember]
        public bool UseStopLimitForStopLossOrders { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AddTarget method.
        /// </summary>
        public void AddTarget()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CloseStrategy method.
        /// </summary>
        /// <param name="signalName">string</param>
        public void CloseStrategy(string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetStopOrders method.
        /// </summary>
        /// <param name="idx">int</param>
        /// <returns>System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order></returns>
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order> GetStopOrders(int idx)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetTargetOrders method.
        /// </summary>
        /// <param name="idx">int</param>
        /// <returns>System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order></returns>
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order> GetTargetOrders(int idx)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="atmStrategy">NinjaTrader.NinjaScript.AtmStrategy</param>
        /// <returns>bool</returns>
        public bool IsEqual(NinjaTrader.NinjaScript.AtmStrategy atmStrategy)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsProfitTarget method.
        /// </summary>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        /// <returns>bool</returns>
        public bool IsProfitTarget(NinjaTrader.Cbi.Order order)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsStopLoss method.
        /// </summary>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        /// <returns>bool</returns>
        public bool IsStopLoss(NinjaTrader.Cbi.Order order)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ProtectPosition method.
        /// </summary>
        /// <param name="template">NinjaTrader.NinjaScript.AtmStrategy</param>
        /// <param name="position">NinjaTrader.Cbi.Position</param>
        public void ProtectPosition(NinjaTrader.NinjaScript.AtmStrategy template, NinjaTrader.Cbi.Position position)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RemoveTarget method.
        /// </summary>
        public void RemoveTarget()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Reverse method.
        /// </summary>
        /// <param name="mode">AtmStrategySelectionMode</param>
        public void Reverse(AtmStrategySelectionMode mode)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetOutstandingEntryQuantity method.
        /// </summary>
        /// <param name="price">double</param>
        /// <param name="quantity">int</param>
        public void SetOutstandingEntryQuantity(double price, int quantity)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetOutstandingExitQuantity method.
        /// </summary>
        /// <param name="price">double</param>
        /// <param name="quantity">int</param>
        public void SetOutstandingExitQuantity(double price, int quantity)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// StartAtmStrategy method.
        /// </summary>
        /// <param name="atmStrategyTemplate">NinjaTrader.NinjaScript.AtmStrategy</param>
        /// <param name="entryOrder">NinjaTrader.Cbi.Order</param>
        /// <returns>NinjaTrader.NinjaScript.AtmStrategy</returns>
        public NinjaTrader.NinjaScript.AtmStrategy StartAtmStrategy(NinjaTrader.NinjaScript.AtmStrategy atmStrategyTemplate, NinjaTrader.Cbi.Order entryOrder)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// StartAtmStrategy method.
        /// </summary>
        /// <param name="atmStrategyTemplateName">string</param>
        /// <param name="entryOrder">NinjaTrader.Cbi.Order</param>
        /// <returns>NinjaTrader.NinjaScript.AtmStrategy</returns>
        public NinjaTrader.NinjaScript.AtmStrategy StartAtmStrategy(string atmStrategyTemplateName, NinjaTrader.Cbi.Order entryOrder)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CanPlaceOrder method.
        /// </summary>
        /// <param name="action">OrderAction</param>
        /// <returns>bool</returns>
        public bool CanPlaceOrder(OrderAction action)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsEntry method.
        /// </summary>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        /// <returns>bool</returns>
        public bool IsEntry(NinjaTrader.Cbi.Order order)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsExit method.
        /// </summary>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        /// <returns>bool</returns>
        public bool IsExit(NinjaTrader.Cbi.Order order)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsSimStop method.
        /// </summary>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        /// <returns>bool</returns>
        public bool IsSimStop(NinjaTrader.Cbi.Order order)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsStop method.
        /// </summary>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        /// <returns>bool</returns>
        public bool IsStop(NinjaTrader.Cbi.Order order)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsTarget method.
        /// </summary>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        /// <returns>bool</returns>
        public bool IsTarget(NinjaTrader.Cbi.Order order)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ManageOrder method.
        /// </summary>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        public void ManageOrder(NinjaTrader.Cbi.Order order)
        {
            // Method implementation goes here
        }
        #endregion
    }
}

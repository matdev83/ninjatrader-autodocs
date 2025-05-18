[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class AtmStrategy : StrategyBase, IAtmStrategy, IDisplayNameProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AtmSelector.
        /// </summary>
        [DataMember]
        public String AtmSelector { get; set; }
        /// <summary>
        /// Gets or sets the ModifyInnerBracket.
        /// </summary>
        [DataMember]
        public Boolean ModifyInnerBracket { get; set; }
        /// <summary>
        /// Gets or sets the ModifyNearestBracket.
        /// </summary>
        [DataMember]
        public Boolean ModifyNearestBracket { get; set; }
        /// <summary>
        /// Gets or sets the OnBehalfOf.
        /// </summary>
        [DataMember]
        public String OnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the ReverseAtStopStrategyId.
        /// </summary>
        [DataMember]
        public Int64 ReverseAtStopStrategyId { get; set; }
        /// <summary>
        /// Gets or sets the ReverseAtTargetStrategyId.
        /// </summary>
        [DataMember]
        public Int64 ReverseAtTargetStrategyId { get; set; }
        /// <summary>
        /// Gets or sets the ShadowStrategyStrategyId.
        /// </summary>
        [DataMember]
        public Int64 ShadowStrategyStrategyId { get; set; }
        /// <summary>
        /// Gets or sets the ShadowTemplate.
        /// </summary>
        [DataMember]
        public String ShadowTemplate { get; set; }
        /// <summary>
        /// Gets or sets the Brackets.
        /// </summary>
        [DataMember]
        public Bracket[] Brackets { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode.
        /// </summary>
        [DataMember]
        public CalculationMode CalculationMode { get; set; }
        /// <summary>
        /// Gets or sets the ChaseLimit.
        /// </summary>
        [DataMember]
        public Double ChaseLimit { get; set; }
        /// <summary>
        /// Gets or sets the DisplayNameExtended.
        /// </summary>
        [DataMember]
        public String DisplayNameExtended { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the EntryQuantity.
        /// </summary>
        [DataMember]
        public Int32 EntryQuantity { get; set; }
        /// <summary>
        /// Gets or sets the InitialEntryOrder.
        /// </summary>
        [DataMember]
        public Order InitialEntryOrder { get; set; }
        /// <summary>
        /// Gets or sets the InitialTickSize.
        /// </summary>
        [DataMember]
        public Double InitialTickSize { get; set; }
        /// <summary>
        /// Gets or sets the IsChase.
        /// </summary>
        [DataMember]
        public Boolean IsChase { get; set; }
        /// <summary>
        /// Gets or sets the IsChaseIfTouched.
        /// </summary>
        [DataMember]
        public Boolean IsChaseIfTouched { get; set; }
        /// <summary>
        /// Gets or sets the IsTargetChase.
        /// </summary>
        [DataMember]
        public Boolean IsTargetChase { get; set; }
        /// <summary>
        /// Gets or sets the ReverseAtStop.
        /// </summary>
        [DataMember]
        public Boolean ReverseAtStop { get; set; }
        /// <summary>
        /// Gets or sets the ReverseAtTarget.
        /// </summary>
        [DataMember]
        public Boolean ReverseAtTarget { get; set; }
        /// <summary>
        /// Gets or sets the UseMitForProfit.
        /// </summary>
        [DataMember]
        public Boolean UseMitForProfit { get; set; }
        /// <summary>
        /// Gets or sets the UseStopLimitForStopLossOrders.
        /// </summary>
        [DataMember]
        public Boolean UseStopLimitForStopLossOrders { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AddTarget method.
        /// </summary>
        public Void AddTarget();
        /// <summary>
        /// CloseStrategy method.
        /// </summary>
        /// <param name="signalName">String</param>
        public Void CloseStrategy(String signalName);
        /// <summary>
        /// GetStopOrders method.
        /// </summary>
        /// <param name="idx">Int32</param>
        /// <returns>Collection`1</returns>
        public Collection<Order> GetStopOrders(Int32 idx);
        /// <summary>
        /// GetTargetOrders method.
        /// </summary>
        /// <param name="idx">Int32</param>
        /// <returns>Collection`1</returns>
        public Collection<Order> GetTargetOrders(Int32 idx);
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="atmStrategy">AtmStrategy</param>
        /// <returns>Boolean</returns>
        public Boolean IsEqual(AtmStrategy atmStrategy);
        /// <summary>
        /// IsProfitTarget method.
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Boolean</returns>
        public Boolean IsProfitTarget(Order order);
        /// <summary>
        /// IsStopLoss method.
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Boolean</returns>
        public Boolean IsStopLoss(Order order);
        /// <summary>
        /// ProtectPosition method.
        /// </summary>
        /// <param name="template">AtmStrategy</param>
        /// <param name="position">Position</param>
        public Void ProtectPosition(AtmStrategy template, Position position);
        /// <summary>
        /// RemoveTarget method.
        /// </summary>
        public Void RemoveTarget();
        /// <summary>
        /// Reverse method.
        /// </summary>
        /// <param name="mode">AtmStrategySelectionMode</param>
        public Void Reverse(AtmStrategySelectionMode mode);
        /// <summary>
        /// SetOutstandingEntryQuantity method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <param name="quantity">Int32</param>
        public Void SetOutstandingEntryQuantity(Double price, Int32 quantity);
        /// <summary>
        /// SetOutstandingExitQuantity method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <param name="quantity">Int32</param>
        public Void SetOutstandingExitQuantity(Double price, Int32 quantity);
        /// <summary>
        /// StartAtmStrategy method.
        /// </summary>
        /// <param name="atmStrategyTemplate">AtmStrategy</param>
        /// <param name="entryOrder">Order</param>
        /// <returns>AtmStrategy</returns>
        public AtmStrategy StartAtmStrategy(AtmStrategy atmStrategyTemplate, Order entryOrder);
        /// <summary>
        /// StartAtmStrategy method.
        /// </summary>
        /// <param name="atmStrategyTemplateName">String</param>
        /// <param name="entryOrder">Order</param>
        /// <returns>AtmStrategy</returns>
        public AtmStrategy StartAtmStrategy(String atmStrategyTemplateName, Order entryOrder);
        /// <summary>
        /// CanPlaceOrder method.
        /// </summary>
        /// <param name="action">OrderAction</param>
        /// <returns>Boolean</returns>
        public Boolean CanPlaceOrder(OrderAction action);
        /// <summary>
        /// IsEntry method.
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Boolean</returns>
        public Boolean IsEntry(Order order);
        /// <summary>
        /// IsExit method.
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Boolean</returns>
        public Boolean IsExit(Order order);
        /// <summary>
        /// IsSimStop method.
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Boolean</returns>
        public Boolean IsSimStop(Order order);
        /// <summary>
        /// IsStop method.
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Boolean</returns>
        public Boolean IsStop(Order order);
        /// <summary>
        /// IsTarget method.
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Boolean</returns>
        public Boolean IsTarget(Order order);
        /// <summary>
        /// ManageOrder method.
        /// </summary>
        /// <param name="order">Order</param>
        public Void ManageOrder(Order order);
        #endregion
    }
}

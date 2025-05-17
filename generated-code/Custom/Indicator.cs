[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class Indicator : IndicatorRenderBase
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// ADL method.
        /// </summary>
        /// <returns>ADL</returns>
        public ADL ADL();
        /// <summary>
        /// ADL method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>ADL</returns>
        public ADL ADL(ISeries<Double> input);
        /// <summary>
        /// ADX method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>ADX</returns>
        public ADX ADX(Int32 period);
        /// <summary>
        /// ADX method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>ADX</returns>
        public ADX ADX(ISeries<Double> input, Int32 period);
        /// <summary>
        /// ADXR method.
        /// </summary>
        /// <param name="interval">Int32</param>
        /// <param name="period">Int32</param>
        /// <returns>ADXR</returns>
        public ADXR ADXR(Int32 interval, Int32 period);
        /// <summary>
        /// ADXR method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="interval">Int32</param>
        /// <param name="period">Int32</param>
        /// <returns>ADXR</returns>
        public ADXR ADXR(ISeries<Double> input, Int32 interval, Int32 period);
        /// <summary>
        /// APZ method.
        /// </summary>
        /// <param name="bandPct">Double</param>
        /// <param name="period">Int32</param>
        /// <returns>APZ</returns>
        public APZ APZ(Double bandPct, Int32 period);
        /// <summary>
        /// APZ method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="bandPct">Double</param>
        /// <param name="period">Int32</param>
        /// <returns>APZ</returns>
        public APZ APZ(ISeries<Double> input, Double bandPct, Int32 period);
        /// <summary>
        /// Aroon method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>Aroon</returns>
        public Aroon Aroon(Int32 period);
        /// <summary>
        /// Aroon method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>Aroon</returns>
        public Aroon Aroon(ISeries<Double> input, Int32 period);
        /// <summary>
        /// AroonOscillator method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>AroonOscillator</returns>
        public AroonOscillator AroonOscillator(Int32 period);
        /// <summary>
        /// AroonOscillator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>AroonOscillator</returns>
        public AroonOscillator AroonOscillator(ISeries<Double> input, Int32 period);
        /// <summary>
        /// ATR method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>ATR</returns>
        public ATR ATR(Int32 period);
        /// <summary>
        /// ATR method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>ATR</returns>
        public ATR ATR(ISeries<Double> input, Int32 period);
        /// <summary>
        /// BarTimer method.
        /// </summary>
        /// <returns>BarTimer</returns>
        public BarTimer BarTimer();
        /// <summary>
        /// BarTimer method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>BarTimer</returns>
        public BarTimer BarTimer(ISeries<Double> input);
        /// <summary>
        /// BlockVolume method.
        /// </summary>
        /// <param name="blockSize">Double</param>
        /// <param name="countType">CountType</param>
        /// <returns>BlockVolume</returns>
        public BlockVolume BlockVolume(Double blockSize, CountType countType);
        /// <summary>
        /// BlockVolume method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="blockSize">Double</param>
        /// <param name="countType">CountType</param>
        /// <returns>BlockVolume</returns>
        public BlockVolume BlockVolume(ISeries<Double> input, Double blockSize, CountType countType);
        /// <summary>
        /// Bollinger method.
        /// </summary>
        /// <param name="numStdDev">Double</param>
        /// <param name="period">Int32</param>
        /// <returns>Bollinger</returns>
        public Bollinger Bollinger(Double numStdDev, Int32 period);
        /// <summary>
        /// Bollinger method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="numStdDev">Double</param>
        /// <param name="period">Int32</param>
        /// <returns>Bollinger</returns>
        public Bollinger Bollinger(ISeries<Double> input, Double numStdDev, Int32 period);
        /// <summary>
        /// BOP method.
        /// </summary>
        /// <param name="smooth">Int32</param>
        /// <returns>BOP</returns>
        public BOP BOP(Int32 smooth);
        /// <summary>
        /// BOP method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="smooth">Int32</param>
        /// <returns>BOP</returns>
        public BOP BOP(ISeries<Double> input, Int32 smooth);
        /// <summary>
        /// BuySellPressure method.
        /// </summary>
        /// <returns>BuySellPressure</returns>
        public BuySellPressure BuySellPressure();
        /// <summary>
        /// BuySellPressure method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>BuySellPressure</returns>
        public BuySellPressure BuySellPressure(ISeries<Double> input);
        /// <summary>
        /// BuySellVolume method.
        /// </summary>
        /// <returns>BuySellVolume</returns>
        public BuySellVolume BuySellVolume();
        /// <summary>
        /// BuySellVolume method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>BuySellVolume</returns>
        public BuySellVolume BuySellVolume(ISeries<Double> input);
        /// <summary>
        /// CamarillaPivots method.
        /// </summary>
        /// <param name="pivotRangeType">PivotRange</param>
        /// <param name="priorDayHlc">HLCCalculationMode</param>
        /// <param name="userDefinedClose">Double</param>
        /// <param name="userDefinedHigh">Double</param>
        /// <param name="userDefinedLow">Double</param>
        /// <param name="width">Int32</param>
        /// <returns>CamarillaPivots</returns>
        public CamarillaPivots CamarillaPivots(PivotRange pivotRangeType, HLCCalculationMode priorDayHlc, Double userDefinedClose, Double userDefinedHigh, Double userDefinedLow, Int32 width);
        /// <summary>
        /// CamarillaPivots method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="pivotRangeType">PivotRange</param>
        /// <param name="priorDayHlc">HLCCalculationMode</param>
        /// <param name="userDefinedClose">Double</param>
        /// <param name="userDefinedHigh">Double</param>
        /// <param name="userDefinedLow">Double</param>
        /// <param name="width">Int32</param>
        /// <returns>CamarillaPivots</returns>
        public CamarillaPivots CamarillaPivots(ISeries<Double> input, PivotRange pivotRangeType, HLCCalculationMode priorDayHlc, Double userDefinedClose, Double userDefinedHigh, Double userDefinedLow, Int32 width);
        /// <summary>
        /// CandlestickPattern method.
        /// </summary>
        /// <param name="pattern">ChartPattern</param>
        /// <param name="trendStrength">Int32</param>
        /// <returns>CandlestickPattern</returns>
        public CandlestickPattern CandlestickPattern(ChartPattern pattern, Int32 trendStrength);
        /// <summary>
        /// CandlestickPattern method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="pattern">ChartPattern</param>
        /// <param name="trendStrength">Int32</param>
        /// <returns>CandlestickPattern</returns>
        public CandlestickPattern CandlestickPattern(ISeries<Double> input, ChartPattern pattern, Int32 trendStrength);
        /// <summary>
        /// CCI method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>CCI</returns>
        public CCI CCI(Int32 period);
        /// <summary>
        /// CCI method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>CCI</returns>
        public CCI CCI(ISeries<Double> input, Int32 period);
        /// <summary>
        /// ChaikinMoneyFlow method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>ChaikinMoneyFlow</returns>
        public ChaikinMoneyFlow ChaikinMoneyFlow(Int32 period);
        /// <summary>
        /// ChaikinMoneyFlow method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>ChaikinMoneyFlow</returns>
        public ChaikinMoneyFlow ChaikinMoneyFlow(ISeries<Double> input, Int32 period);
        /// <summary>
        /// ChaikinOscillator method.
        /// </summary>
        /// <param name="fast">Int32</param>
        /// <param name="slow">Int32</param>
        /// <returns>ChaikinOscillator</returns>
        public ChaikinOscillator ChaikinOscillator(Int32 fast, Int32 slow);
        /// <summary>
        /// ChaikinOscillator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="fast">Int32</param>
        /// <param name="slow">Int32</param>
        /// <returns>ChaikinOscillator</returns>
        public ChaikinOscillator ChaikinOscillator(ISeries<Double> input, Int32 fast, Int32 slow);
        /// <summary>
        /// ChaikinVolatility method.
        /// </summary>
        /// <param name="mAPeriod">Int32</param>
        /// <param name="rOCPeriod">Int32</param>
        /// <returns>ChaikinVolatility</returns>
        public ChaikinVolatility ChaikinVolatility(Int32 mAPeriod, Int32 rOCPeriod);
        /// <summary>
        /// ChaikinVolatility method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="mAPeriod">Int32</param>
        /// <param name="rOCPeriod">Int32</param>
        /// <returns>ChaikinVolatility</returns>
        public ChaikinVolatility ChaikinVolatility(ISeries<Double> input, Int32 mAPeriod, Int32 rOCPeriod);
        /// <summary>
        /// ChoppinessIndex method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>ChoppinessIndex</returns>
        public ChoppinessIndex ChoppinessIndex(Int32 period);
        /// <summary>
        /// ChoppinessIndex method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>ChoppinessIndex</returns>
        public ChoppinessIndex ChoppinessIndex(ISeries<Double> input, Int32 period);
        /// <summary>
        /// CMO method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>CMO</returns>
        public CMO CMO(Int32 period);
        /// <summary>
        /// CMO method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>CMO</returns>
        public CMO CMO(ISeries<Double> input, Int32 period);
        /// <summary>
        /// ConstantLines method.
        /// </summary>
        /// <param name="line1Value">Double</param>
        /// <param name="line2Value">Double</param>
        /// <param name="line3Value">Double</param>
        /// <param name="line4Value">Double</param>
        /// <returns>ConstantLines</returns>
        public ConstantLines ConstantLines(Double line1Value, Double line2Value, Double line3Value, Double line4Value);
        /// <summary>
        /// ConstantLines method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="line1Value">Double</param>
        /// <param name="line2Value">Double</param>
        /// <param name="line3Value">Double</param>
        /// <param name="line4Value">Double</param>
        /// <returns>ConstantLines</returns>
        public ConstantLines ConstantLines(ISeries<Double> input, Double line1Value, Double line2Value, Double line3Value, Double line4Value);
        /// <summary>
        /// Correlation method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <param name="correlationSeries">String</param>
        /// <returns>Correlation</returns>
        public Correlation Correlation(Int32 period, String correlationSeries);
        /// <summary>
        /// Correlation method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <param name="correlationSeries">String</param>
        /// <returns>Correlation</returns>
        public Correlation Correlation(ISeries<Double> input, Int32 period, String correlationSeries);
        /// <summary>
        /// COT method.
        /// </summary>
        /// <param name="number">Int32</param>
        /// <returns>COT</returns>
        public COT COT(Int32 number);
        /// <summary>
        /// COT method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="number">Int32</param>
        /// <returns>COT</returns>
        public COT COT(ISeries<Double> input, Int32 number);
        /// <summary>
        /// CurrentDayOHL method.
        /// </summary>
        /// <returns>CurrentDayOHL</returns>
        public CurrentDayOHL CurrentDayOHL();
        /// <summary>
        /// CurrentDayOHL method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>CurrentDayOHL</returns>
        public CurrentDayOHL CurrentDayOHL(ISeries<Double> input);
        /// <summary>
        /// Darvas method.
        /// </summary>
        /// <returns>Darvas</returns>
        public Darvas Darvas();
        /// <summary>
        /// Darvas method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>Darvas</returns>
        public Darvas Darvas(ISeries<Double> input);
        /// <summary>
        /// DEMA method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>DEMA</returns>
        public DEMA DEMA(Int32 period);
        /// <summary>
        /// DEMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>DEMA</returns>
        public DEMA DEMA(ISeries<Double> input, Int32 period);
        /// <summary>
        /// DisparityIndex method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>DisparityIndex</returns>
        public DisparityIndex DisparityIndex(Int32 period);
        /// <summary>
        /// DisparityIndex method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>DisparityIndex</returns>
        public DisparityIndex DisparityIndex(ISeries<Double> input, Int32 period);
        /// <summary>
        /// DM method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>DM</returns>
        public DM DM(Int32 period);
        /// <summary>
        /// DM method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>DM</returns>
        public DM DM(ISeries<Double> input, Int32 period);
        /// <summary>
        /// DMI method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>DMI</returns>
        public DMI DMI(Int32 period);
        /// <summary>
        /// DMI method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>DMI</returns>
        public DMI DMI(ISeries<Double> input, Int32 period);
        /// <summary>
        /// DMIndex method.
        /// </summary>
        /// <param name="smooth">Int32</param>
        /// <returns>DMIndex</returns>
        public DMIndex DMIndex(Int32 smooth);
        /// <summary>
        /// DMIndex method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="smooth">Int32</param>
        /// <returns>DMIndex</returns>
        public DMIndex DMIndex(ISeries<Double> input, Int32 smooth);
        /// <summary>
        /// DonchianChannel method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>DonchianChannel</returns>
        public DonchianChannel DonchianChannel(Int32 period);
        /// <summary>
        /// DonchianChannel method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>DonchianChannel</returns>
        public DonchianChannel DonchianChannel(ISeries<Double> input, Int32 period);
        /// <summary>
        /// DoubleStochastics method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>DoubleStochastics</returns>
        public DoubleStochastics DoubleStochastics(Int32 period);
        /// <summary>
        /// DoubleStochastics method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>DoubleStochastics</returns>
        public DoubleStochastics DoubleStochastics(ISeries<Double> input, Int32 period);
        /// <summary>
        /// EaseOfMovement method.
        /// </summary>
        /// <param name="smoothing">Int32</param>
        /// <param name="volumeDivisor">Int32</param>
        /// <returns>EaseOfMovement</returns>
        public EaseOfMovement EaseOfMovement(Int32 smoothing, Int32 volumeDivisor);
        /// <summary>
        /// EaseOfMovement method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="smoothing">Int32</param>
        /// <param name="volumeDivisor">Int32</param>
        /// <returns>EaseOfMovement</returns>
        public EaseOfMovement EaseOfMovement(ISeries<Double> input, Int32 smoothing, Int32 volumeDivisor);
        /// <summary>
        /// EMA method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>EMA</returns>
        public EMA EMA(Int32 period);
        /// <summary>
        /// EMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>EMA</returns>
        public EMA EMA(ISeries<Double> input, Int32 period);
        /// <summary>
        /// FibonacciPivots method.
        /// </summary>
        /// <param name="pivotRangeType">PivotRange</param>
        /// <param name="priorDayHlc">HLCCalculationMode</param>
        /// <param name="userDefinedClose">Double</param>
        /// <param name="userDefinedHigh">Double</param>
        /// <param name="userDefinedLow">Double</param>
        /// <param name="width">Int32</param>
        /// <returns>FibonacciPivots</returns>
        public FibonacciPivots FibonacciPivots(PivotRange pivotRangeType, HLCCalculationMode priorDayHlc, Double userDefinedClose, Double userDefinedHigh, Double userDefinedLow, Int32 width);
        /// <summary>
        /// FibonacciPivots method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="pivotRangeType">PivotRange</param>
        /// <param name="priorDayHlc">HLCCalculationMode</param>
        /// <param name="userDefinedClose">Double</param>
        /// <param name="userDefinedHigh">Double</param>
        /// <param name="userDefinedLow">Double</param>
        /// <param name="width">Int32</param>
        /// <returns>FibonacciPivots</returns>
        public FibonacciPivots FibonacciPivots(ISeries<Double> input, PivotRange pivotRangeType, HLCCalculationMode priorDayHlc, Double userDefinedClose, Double userDefinedHigh, Double userDefinedLow, Int32 width);
        /// <summary>
        /// FisherTransform method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>FisherTransform</returns>
        public FisherTransform FisherTransform(Int32 period);
        /// <summary>
        /// FisherTransform method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>FisherTransform</returns>
        public FisherTransform FisherTransform(ISeries<Double> input, Int32 period);
        /// <summary>
        /// FOSC method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>FOSC</returns>
        public FOSC FOSC(Int32 period);
        /// <summary>
        /// FOSC method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>FOSC</returns>
        public FOSC FOSC(ISeries<Double> input, Int32 period);
        /// <summary>
        /// HMA method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>HMA</returns>
        public HMA HMA(Int32 period);
        /// <summary>
        /// HMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>HMA</returns>
        public HMA HMA(ISeries<Double> input, Int32 period);
        /// <summary>
        /// KAMA method.
        /// </summary>
        /// <param name="fast">Int32</param>
        /// <param name="period">Int32</param>
        /// <param name="slow">Int32</param>
        /// <returns>KAMA</returns>
        public KAMA KAMA(Int32 fast, Int32 period, Int32 slow);
        /// <summary>
        /// KAMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="fast">Int32</param>
        /// <param name="period">Int32</param>
        /// <param name="slow">Int32</param>
        /// <returns>KAMA</returns>
        public KAMA KAMA(ISeries<Double> input, Int32 fast, Int32 period, Int32 slow);
        /// <summary>
        /// KeltnerChannel method.
        /// </summary>
        /// <param name="offsetMultiplier">Double</param>
        /// <param name="period">Int32</param>
        /// <returns>KeltnerChannel</returns>
        public KeltnerChannel KeltnerChannel(Double offsetMultiplier, Int32 period);
        /// <summary>
        /// KeltnerChannel method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="offsetMultiplier">Double</param>
        /// <param name="period">Int32</param>
        /// <returns>KeltnerChannel</returns>
        public KeltnerChannel KeltnerChannel(ISeries<Double> input, Double offsetMultiplier, Int32 period);
        /// <summary>
        /// KeyReversalDown method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>KeyReversalDown</returns>
        public KeyReversalDown KeyReversalDown(Int32 period);
        /// <summary>
        /// KeyReversalDown method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>KeyReversalDown</returns>
        public KeyReversalDown KeyReversalDown(ISeries<Double> input, Int32 period);
        /// <summary>
        /// KeyReversalUp method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>KeyReversalUp</returns>
        public KeyReversalUp KeyReversalUp(Int32 period);
        /// <summary>
        /// KeyReversalUp method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>KeyReversalUp</returns>
        public KeyReversalUp KeyReversalUp(ISeries<Double> input, Int32 period);
        /// <summary>
        /// LinReg method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>LinReg</returns>
        public LinReg LinReg(Int32 period);
        /// <summary>
        /// LinReg method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>LinReg</returns>
        public LinReg LinReg(ISeries<Double> input, Int32 period);
        /// <summary>
        /// LinRegIntercept method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>LinRegIntercept</returns>
        public LinRegIntercept LinRegIntercept(Int32 period);
        /// <summary>
        /// LinRegIntercept method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>LinRegIntercept</returns>
        public LinRegIntercept LinRegIntercept(ISeries<Double> input, Int32 period);
        /// <summary>
        /// LinRegSlope method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>LinRegSlope</returns>
        public LinRegSlope LinRegSlope(Int32 period);
        /// <summary>
        /// LinRegSlope method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>LinRegSlope</returns>
        public LinRegSlope LinRegSlope(ISeries<Double> input, Int32 period);
        /// <summary>
        /// MACD method.
        /// </summary>
        /// <param name="fast">Int32</param>
        /// <param name="slow">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>MACD</returns>
        public MACD MACD(Int32 fast, Int32 slow, Int32 smooth);
        /// <summary>
        /// MACD method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="fast">Int32</param>
        /// <param name="slow">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>MACD</returns>
        public MACD MACD(ISeries<Double> input, Int32 fast, Int32 slow, Int32 smooth);
        /// <summary>
        /// MAEnvelopes method.
        /// </summary>
        /// <param name="envelopePercentage">Double</param>
        /// <param name="mAType">Int32</param>
        /// <param name="period">Int32</param>
        /// <returns>MAEnvelopes</returns>
        public MAEnvelopes MAEnvelopes(Double envelopePercentage, Int32 mAType, Int32 period);
        /// <summary>
        /// MAEnvelopes method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="envelopePercentage">Double</param>
        /// <param name="mAType">Int32</param>
        /// <param name="period">Int32</param>
        /// <returns>MAEnvelopes</returns>
        public MAEnvelopes MAEnvelopes(ISeries<Double> input, Double envelopePercentage, Int32 mAType, Int32 period);
        /// <summary>
        /// MAMA method.
        /// </summary>
        /// <param name="fastLimit">Double</param>
        /// <param name="slowLimit">Double</param>
        /// <returns>MAMA</returns>
        public MAMA MAMA(Double fastLimit, Double slowLimit);
        /// <summary>
        /// MAMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="fastLimit">Double</param>
        /// <param name="slowLimit">Double</param>
        /// <returns>MAMA</returns>
        public MAMA MAMA(ISeries<Double> input, Double fastLimit, Double slowLimit);
        /// <summary>
        /// MAX method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>MAX</returns>
        public MAX MAX(Int32 period);
        /// <summary>
        /// MAX method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>MAX</returns>
        public MAX MAX(ISeries<Double> input, Int32 period);
        /// <summary>
        /// McClellanOscillator method.
        /// </summary>
        /// <param name="fastPeriod">Int32</param>
        /// <param name="slowPeriod">Int32</param>
        /// <returns>McClellanOscillator</returns>
        public McClellanOscillator McClellanOscillator(Int32 fastPeriod, Int32 slowPeriod);
        /// <summary>
        /// McClellanOscillator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="fastPeriod">Int32</param>
        /// <param name="slowPeriod">Int32</param>
        /// <returns>McClellanOscillator</returns>
        public McClellanOscillator McClellanOscillator(ISeries<Double> input, Int32 fastPeriod, Int32 slowPeriod);
        /// <summary>
        /// MFI method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>MFI</returns>
        public MFI MFI(Int32 period);
        /// <summary>
        /// MFI method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>MFI</returns>
        public MFI MFI(ISeries<Double> input, Int32 period);
        /// <summary>
        /// MIN method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>MIN</returns>
        public MIN MIN(Int32 period);
        /// <summary>
        /// MIN method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>MIN</returns>
        public MIN MIN(ISeries<Double> input, Int32 period);
        /// <summary>
        /// Momentum method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>Momentum</returns>
        public Momentum Momentum(Int32 period);
        /// <summary>
        /// Momentum method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>Momentum</returns>
        public Momentum Momentum(ISeries<Double> input, Int32 period);
        /// <summary>
        /// MoneyFlowOscillator method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>MoneyFlowOscillator</returns>
        public MoneyFlowOscillator MoneyFlowOscillator(Int32 period);
        /// <summary>
        /// MoneyFlowOscillator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>MoneyFlowOscillator</returns>
        public MoneyFlowOscillator MoneyFlowOscillator(ISeries<Double> input, Int32 period);
        /// <summary>
        /// MovingAverageRibbon method.
        /// </summary>
        /// <param name="movingAverage">RibbonMAType</param>
        /// <param name="basePeriod">Int32</param>
        /// <param name="incrementalPeriod">Int32</param>
        /// <returns>MovingAverageRibbon</returns>
        public MovingAverageRibbon MovingAverageRibbon(RibbonMAType movingAverage, Int32 basePeriod, Int32 incrementalPeriod);
        /// <summary>
        /// MovingAverageRibbon method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="movingAverage">RibbonMAType</param>
        /// <param name="basePeriod">Int32</param>
        /// <param name="incrementalPeriod">Int32</param>
        /// <returns>MovingAverageRibbon</returns>
        public MovingAverageRibbon MovingAverageRibbon(ISeries<Double> input, RibbonMAType movingAverage, Int32 basePeriod, Int32 incrementalPeriod);
        /// <summary>
        /// NBarsDown method.
        /// </summary>
        /// <param name="barCount">Int32</param>
        /// <param name="barDown">Boolean</param>
        /// <param name="lowerHigh">Boolean</param>
        /// <param name="lowerLow">Boolean</param>
        /// <returns>NBarsDown</returns>
        public NBarsDown NBarsDown(Int32 barCount, Boolean barDown, Boolean lowerHigh, Boolean lowerLow);
        /// <summary>
        /// NBarsDown method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="barCount">Int32</param>
        /// <param name="barDown">Boolean</param>
        /// <param name="lowerHigh">Boolean</param>
        /// <param name="lowerLow">Boolean</param>
        /// <returns>NBarsDown</returns>
        public NBarsDown NBarsDown(ISeries<Double> input, Int32 barCount, Boolean barDown, Boolean lowerHigh, Boolean lowerLow);
        /// <summary>
        /// NBarsUp method.
        /// </summary>
        /// <param name="barCount">Int32</param>
        /// <param name="barUp">Boolean</param>
        /// <param name="higherHigh">Boolean</param>
        /// <param name="higherLow">Boolean</param>
        /// <returns>NBarsUp</returns>
        public NBarsUp NBarsUp(Int32 barCount, Boolean barUp, Boolean higherHigh, Boolean higherLow);
        /// <summary>
        /// NBarsUp method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="barCount">Int32</param>
        /// <param name="barUp">Boolean</param>
        /// <param name="higherHigh">Boolean</param>
        /// <param name="higherLow">Boolean</param>
        /// <returns>NBarsUp</returns>
        public NBarsUp NBarsUp(ISeries<Double> input, Int32 barCount, Boolean barUp, Boolean higherHigh, Boolean higherLow);
        /// <summary>
        /// NetChangeDisplay method.
        /// </summary>
        /// <param name="unit">PerformanceUnit</param>
        /// <param name="location">NetChangePosition</param>
        /// <returns>NetChangeDisplay</returns>
        public NetChangeDisplay NetChangeDisplay(PerformanceUnit unit, NetChangePosition location);
        /// <summary>
        /// NetChangeDisplay method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="unit">PerformanceUnit</param>
        /// <param name="location">NetChangePosition</param>
        /// <returns>NetChangeDisplay</returns>
        public NetChangeDisplay NetChangeDisplay(ISeries<Double> input, PerformanceUnit unit, NetChangePosition location);
        /// <summary>
        /// OBV method.
        /// </summary>
        /// <returns>OBV</returns>
        public OBV OBV();
        /// <summary>
        /// OBV method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>OBV</returns>
        public OBV OBV(ISeries<Double> input);
        /// <summary>
        /// ParabolicSAR method.
        /// </summary>
        /// <param name="acceleration">Double</param>
        /// <param name="accelerationMax">Double</param>
        /// <param name="accelerationStep">Double</param>
        /// <returns>ParabolicSAR</returns>
        public ParabolicSAR ParabolicSAR(Double acceleration, Double accelerationMax, Double accelerationStep);
        /// <summary>
        /// ParabolicSAR method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="acceleration">Double</param>
        /// <param name="accelerationMax">Double</param>
        /// <param name="accelerationStep">Double</param>
        /// <returns>ParabolicSAR</returns>
        public ParabolicSAR ParabolicSAR(ISeries<Double> input, Double acceleration, Double accelerationMax, Double accelerationStep);
        /// <summary>
        /// PFE method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>PFE</returns>
        public PFE PFE(Int32 period, Int32 smooth);
        /// <summary>
        /// PFE method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>PFE</returns>
        public PFE PFE(ISeries<Double> input, Int32 period, Int32 smooth);
        /// <summary>
        /// Pivots method.
        /// </summary>
        /// <param name="pivotRangeType">PivotRange</param>
        /// <param name="priorDayHlc">HLCCalculationMode</param>
        /// <param name="userDefinedClose">Double</param>
        /// <param name="userDefinedHigh">Double</param>
        /// <param name="userDefinedLow">Double</param>
        /// <param name="width">Int32</param>
        /// <returns>Pivots</returns>
        public Pivots Pivots(PivotRange pivotRangeType, HLCCalculationMode priorDayHlc, Double userDefinedClose, Double userDefinedHigh, Double userDefinedLow, Int32 width);
        /// <summary>
        /// Pivots method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="pivotRangeType">PivotRange</param>
        /// <param name="priorDayHlc">HLCCalculationMode</param>
        /// <param name="userDefinedClose">Double</param>
        /// <param name="userDefinedHigh">Double</param>
        /// <param name="userDefinedLow">Double</param>
        /// <param name="width">Int32</param>
        /// <returns>Pivots</returns>
        public Pivots Pivots(ISeries<Double> input, PivotRange pivotRangeType, HLCCalculationMode priorDayHlc, Double userDefinedClose, Double userDefinedHigh, Double userDefinedLow, Int32 width);
        /// <summary>
        /// PPO method.
        /// </summary>
        /// <param name="fast">Int32</param>
        /// <param name="slow">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>PPO</returns>
        public PPO PPO(Int32 fast, Int32 slow, Int32 smooth);
        /// <summary>
        /// PPO method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="fast">Int32</param>
        /// <param name="slow">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>PPO</returns>
        public PPO PPO(ISeries<Double> input, Int32 fast, Int32 slow, Int32 smooth);
        /// <summary>
        /// PriceLine method.
        /// </summary>
        /// <param name="showAskLine">Boolean</param>
        /// <param name="showBidLine">Boolean</param>
        /// <param name="showLastLine">Boolean</param>
        /// <param name="askLineLength">Int32</param>
        /// <param name="bidLineLength">Int32</param>
        /// <param name="lastLineLength">Int32</param>
        /// <returns>PriceLine</returns>
        public PriceLine PriceLine(Boolean showAskLine, Boolean showBidLine, Boolean showLastLine, Int32 askLineLength, Int32 bidLineLength, Int32 lastLineLength);
        /// <summary>
        /// PriceLine method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="showAskLine">Boolean</param>
        /// <param name="showBidLine">Boolean</param>
        /// <param name="showLastLine">Boolean</param>
        /// <param name="askLineLength">Int32</param>
        /// <param name="bidLineLength">Int32</param>
        /// <param name="lastLineLength">Int32</param>
        /// <returns>PriceLine</returns>
        public PriceLine PriceLine(ISeries<Double> input, Boolean showAskLine, Boolean showBidLine, Boolean showLastLine, Int32 askLineLength, Int32 bidLineLength, Int32 lastLineLength);
        /// <summary>
        /// PriceOscillator method.
        /// </summary>
        /// <param name="fast">Int32</param>
        /// <param name="slow">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>PriceOscillator</returns>
        public PriceOscillator PriceOscillator(Int32 fast, Int32 slow, Int32 smooth);
        /// <summary>
        /// PriceOscillator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="fast">Int32</param>
        /// <param name="slow">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>PriceOscillator</returns>
        public PriceOscillator PriceOscillator(ISeries<Double> input, Int32 fast, Int32 slow, Int32 smooth);
        /// <summary>
        /// PriorDayOHLC method.
        /// </summary>
        /// <returns>PriorDayOHLC</returns>
        public PriorDayOHLC PriorDayOHLC();
        /// <summary>
        /// PriorDayOHLC method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>PriorDayOHLC</returns>
        public PriorDayOHLC PriorDayOHLC(ISeries<Double> input);
        /// <summary>
        /// PsychologicalLine method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>PsychologicalLine</returns>
        public PsychologicalLine PsychologicalLine(Int32 period);
        /// <summary>
        /// PsychologicalLine method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>PsychologicalLine</returns>
        public PsychologicalLine PsychologicalLine(ISeries<Double> input, Int32 period);
        /// <summary>
        /// Range method.
        /// </summary>
        /// <returns>Range</returns>
        public Range Range();
        /// <summary>
        /// Range method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>Range</returns>
        public Range Range(ISeries<Double> input);
        /// <summary>
        /// RangeCounter method.
        /// </summary>
        /// <param name="countDown">Boolean</param>
        /// <returns>RangeCounter</returns>
        public RangeCounter RangeCounter(Boolean countDown);
        /// <summary>
        /// RangeCounter method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="countDown">Boolean</param>
        /// <returns>RangeCounter</returns>
        public RangeCounter RangeCounter(ISeries<Double> input, Boolean countDown);
        /// <summary>
        /// RegressionChannel method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <param name="width">Double</param>
        /// <returns>RegressionChannel</returns>
        public RegressionChannel RegressionChannel(Int32 period, Double width);
        /// <summary>
        /// RegressionChannel method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <param name="width">Double</param>
        /// <returns>RegressionChannel</returns>
        public RegressionChannel RegressionChannel(ISeries<Double> input, Int32 period, Double width);
        /// <summary>
        /// RelativeVigorIndex method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>RelativeVigorIndex</returns>
        public RelativeVigorIndex RelativeVigorIndex(Int32 period);
        /// <summary>
        /// RelativeVigorIndex method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>RelativeVigorIndex</returns>
        public RelativeVigorIndex RelativeVigorIndex(ISeries<Double> input, Int32 period);
        /// <summary>
        /// RIND method.
        /// </summary>
        /// <param name="periodQ">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>RIND</returns>
        public RIND RIND(Int32 periodQ, Int32 smooth);
        /// <summary>
        /// RIND method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="periodQ">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>RIND</returns>
        public RIND RIND(ISeries<Double> input, Int32 periodQ, Int32 smooth);
        /// <summary>
        /// ROC method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>ROC</returns>
        public ROC ROC(Int32 period);
        /// <summary>
        /// ROC method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>ROC</returns>
        public ROC ROC(ISeries<Double> input, Int32 period);
        /// <summary>
        /// RSI method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>RSI</returns>
        public RSI RSI(Int32 period, Int32 smooth);
        /// <summary>
        /// RSI method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>RSI</returns>
        public RSI RSI(ISeries<Double> input, Int32 period, Int32 smooth);
        /// <summary>
        /// RSquared method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>RSquared</returns>
        public RSquared RSquared(Int32 period);
        /// <summary>
        /// RSquared method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>RSquared</returns>
        public RSquared RSquared(ISeries<Double> input, Int32 period);
        /// <summary>
        /// RSS method.
        /// </summary>
        /// <param name="eMA1">Int32</param>
        /// <param name="eMA2">Int32</param>
        /// <param name="length">Int32</param>
        /// <returns>RSS</returns>
        public RSS RSS(Int32 eMA1, Int32 eMA2, Int32 length);
        /// <summary>
        /// RSS method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="eMA1">Int32</param>
        /// <param name="eMA2">Int32</param>
        /// <param name="length">Int32</param>
        /// <returns>RSS</returns>
        public RSS RSS(ISeries<Double> input, Int32 eMA1, Int32 eMA2, Int32 length);
        /// <summary>
        /// RVI method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>RVI</returns>
        public RVI RVI(Int32 period);
        /// <summary>
        /// RVI method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>RVI</returns>
        public RVI RVI(ISeries<Double> input, Int32 period);
        /// <summary>
        /// SampleCustomRender method.
        /// </summary>
        /// <returns>SampleCustomRender</returns>
        public SampleCustomRender SampleCustomRender();
        /// <summary>
        /// SampleCustomRender method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>SampleCustomRender</returns>
        public SampleCustomRender SampleCustomRender(ISeries<Double> input);
        /// <summary>
        /// SMA method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>SMA</returns>
        public SMA SMA(Int32 period);
        /// <summary>
        /// SMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>SMA</returns>
        public SMA SMA(ISeries<Double> input, Int32 period);
        /// <summary>
        /// StdDev method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>StdDev</returns>
        public StdDev StdDev(Int32 period);
        /// <summary>
        /// StdDev method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>StdDev</returns>
        public StdDev StdDev(ISeries<Double> input, Int32 period);
        /// <summary>
        /// StdError method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>StdError</returns>
        public StdError StdError(Int32 period);
        /// <summary>
        /// StdError method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>StdError</returns>
        public StdError StdError(ISeries<Double> input, Int32 period);
        /// <summary>
        /// Stochastics method.
        /// </summary>
        /// <param name="periodD">Int32</param>
        /// <param name="periodK">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>Stochastics</returns>
        public Stochastics Stochastics(Int32 periodD, Int32 periodK, Int32 smooth);
        /// <summary>
        /// Stochastics method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="periodD">Int32</param>
        /// <param name="periodK">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>Stochastics</returns>
        public Stochastics Stochastics(ISeries<Double> input, Int32 periodD, Int32 periodK, Int32 smooth);
        /// <summary>
        /// StochasticsFast method.
        /// </summary>
        /// <param name="periodD">Int32</param>
        /// <param name="periodK">Int32</param>
        /// <returns>StochasticsFast</returns>
        public StochasticsFast StochasticsFast(Int32 periodD, Int32 periodK);
        /// <summary>
        /// StochasticsFast method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="periodD">Int32</param>
        /// <param name="periodK">Int32</param>
        /// <returns>StochasticsFast</returns>
        public StochasticsFast StochasticsFast(ISeries<Double> input, Int32 periodD, Int32 periodK);
        /// <summary>
        /// StochRSI method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>StochRSI</returns>
        public StochRSI StochRSI(Int32 period);
        /// <summary>
        /// StochRSI method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>StochRSI</returns>
        public StochRSI StochRSI(ISeries<Double> input, Int32 period);
        /// <summary>
        /// SUM method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>SUM</returns>
        public SUM SUM(Int32 period);
        /// <summary>
        /// SUM method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>SUM</returns>
        public SUM SUM(ISeries<Double> input, Int32 period);
        /// <summary>
        /// Swing method.
        /// </summary>
        /// <param name="strength">Int32</param>
        /// <returns>Swing</returns>
        public Swing Swing(Int32 strength);
        /// <summary>
        /// Swing method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="strength">Int32</param>
        /// <returns>Swing</returns>
        public Swing Swing(ISeries<Double> input, Int32 strength);
        /// <summary>
        /// T3 method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <param name="tCount">Int32</param>
        /// <param name="vFactor">Double</param>
        /// <returns>T3</returns>
        public T3 T3(Int32 period, Int32 tCount, Double vFactor);
        /// <summary>
        /// T3 method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <param name="tCount">Int32</param>
        /// <param name="vFactor">Double</param>
        /// <returns>T3</returns>
        public T3 T3(ISeries<Double> input, Int32 period, Int32 tCount, Double vFactor);
        /// <summary>
        /// TEMA method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>TEMA</returns>
        public TEMA TEMA(Int32 period);
        /// <summary>
        /// TEMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>TEMA</returns>
        public TEMA TEMA(ISeries<Double> input, Int32 period);
        /// <summary>
        /// TickCounter method.
        /// </summary>
        /// <param name="countDown">Boolean</param>
        /// <param name="showPercent">Boolean</param>
        /// <returns>TickCounter</returns>
        public TickCounter TickCounter(Boolean countDown, Boolean showPercent);
        /// <summary>
        /// TickCounter method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="countDown">Boolean</param>
        /// <param name="showPercent">Boolean</param>
        /// <returns>TickCounter</returns>
        public TickCounter TickCounter(ISeries<Double> input, Boolean countDown, Boolean showPercent);
        /// <summary>
        /// TMA method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>TMA</returns>
        public TMA TMA(Int32 period);
        /// <summary>
        /// TMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>TMA</returns>
        public TMA TMA(ISeries<Double> input, Int32 period);
        /// <summary>
        /// TrendLines method.
        /// </summary>
        /// <param name="strength">Int32</param>
        /// <param name="numberOfTrendLines">Int32</param>
        /// <param name="oldTrendsOpacity">Int32</param>
        /// <param name="alertOnBreak">Boolean</param>
        /// <returns>TrendLines</returns>
        public TrendLines TrendLines(Int32 strength, Int32 numberOfTrendLines, Int32 oldTrendsOpacity, Boolean alertOnBreak);
        /// <summary>
        /// TrendLines method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="strength">Int32</param>
        /// <param name="numberOfTrendLines">Int32</param>
        /// <param name="oldTrendsOpacity">Int32</param>
        /// <param name="alertOnBreak">Boolean</param>
        /// <returns>TrendLines</returns>
        public TrendLines TrendLines(ISeries<Double> input, Int32 strength, Int32 numberOfTrendLines, Int32 oldTrendsOpacity, Boolean alertOnBreak);
        /// <summary>
        /// TRIX method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <param name="signalPeriod">Int32</param>
        /// <returns>TRIX</returns>
        public TRIX TRIX(Int32 period, Int32 signalPeriod);
        /// <summary>
        /// TRIX method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <param name="signalPeriod">Int32</param>
        /// <returns>TRIX</returns>
        public TRIX TRIX(ISeries<Double> input, Int32 period, Int32 signalPeriod);
        /// <summary>
        /// TSF method.
        /// </summary>
        /// <param name="forecast">Int32</param>
        /// <param name="period">Int32</param>
        /// <returns>TSF</returns>
        public TSF TSF(Int32 forecast, Int32 period);
        /// <summary>
        /// TSF method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="forecast">Int32</param>
        /// <param name="period">Int32</param>
        /// <returns>TSF</returns>
        public TSF TSF(ISeries<Double> input, Int32 forecast, Int32 period);
        /// <summary>
        /// TSI method.
        /// </summary>
        /// <param name="fast">Int32</param>
        /// <param name="slow">Int32</param>
        /// <returns>TSI</returns>
        public TSI TSI(Int32 fast, Int32 slow);
        /// <summary>
        /// TSI method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="fast">Int32</param>
        /// <param name="slow">Int32</param>
        /// <returns>TSI</returns>
        public TSI TSI(ISeries<Double> input, Int32 fast, Int32 slow);
        /// <summary>
        /// UltimateOscillator method.
        /// </summary>
        /// <param name="fast">Int32</param>
        /// <param name="intermediate">Int32</param>
        /// <param name="slow">Int32</param>
        /// <returns>UltimateOscillator</returns>
        public UltimateOscillator UltimateOscillator(Int32 fast, Int32 intermediate, Int32 slow);
        /// <summary>
        /// UltimateOscillator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="fast">Int32</param>
        /// <param name="intermediate">Int32</param>
        /// <param name="slow">Int32</param>
        /// <returns>UltimateOscillator</returns>
        public UltimateOscillator UltimateOscillator(ISeries<Double> input, Int32 fast, Int32 intermediate, Int32 slow);
        /// <summary>
        /// VMA method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <param name="volatilityPeriod">Int32</param>
        /// <returns>VMA</returns>
        public VMA VMA(Int32 period, Int32 volatilityPeriod);
        /// <summary>
        /// VMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <param name="volatilityPeriod">Int32</param>
        /// <returns>VMA</returns>
        public VMA VMA(ISeries<Double> input, Int32 period, Int32 volatilityPeriod);
        /// <summary>
        /// VOL method.
        /// </summary>
        /// <returns>VOL</returns>
        public VOL VOL();
        /// <summary>
        /// VOL method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>VOL</returns>
        public VOL VOL(ISeries<Double> input);
        /// <summary>
        /// VOLMA method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>VOLMA</returns>
        public VOLMA VOLMA(Int32 period);
        /// <summary>
        /// VOLMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>VOLMA</returns>
        public VOLMA VOLMA(ISeries<Double> input, Int32 period);
        /// <summary>
        /// VolumeCounter method.
        /// </summary>
        /// <param name="countDown">Boolean</param>
        /// <param name="showPercent">Boolean</param>
        /// <returns>VolumeCounter</returns>
        public VolumeCounter VolumeCounter(Boolean countDown, Boolean showPercent);
        /// <summary>
        /// VolumeCounter method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="countDown">Boolean</param>
        /// <param name="showPercent">Boolean</param>
        /// <returns>VolumeCounter</returns>
        public VolumeCounter VolumeCounter(ISeries<Double> input, Boolean countDown, Boolean showPercent);
        /// <summary>
        /// VolumeOscillator method.
        /// </summary>
        /// <param name="fast">Int32</param>
        /// <param name="slow">Int32</param>
        /// <returns>VolumeOscillator</returns>
        public VolumeOscillator VolumeOscillator(Int32 fast, Int32 slow);
        /// <summary>
        /// VolumeOscillator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="fast">Int32</param>
        /// <param name="slow">Int32</param>
        /// <returns>VolumeOscillator</returns>
        public VolumeOscillator VolumeOscillator(ISeries<Double> input, Int32 fast, Int32 slow);
        /// <summary>
        /// VolumeProfile method.
        /// </summary>
        /// <returns>VolumeProfile</returns>
        public VolumeProfile VolumeProfile();
        /// <summary>
        /// VolumeProfile method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>VolumeProfile</returns>
        public VolumeProfile VolumeProfile(ISeries<Double> input);
        /// <summary>
        /// VolumeUpDown method.
        /// </summary>
        /// <returns>VolumeUpDown</returns>
        public VolumeUpDown VolumeUpDown();
        /// <summary>
        /// VolumeUpDown method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>VolumeUpDown</returns>
        public VolumeUpDown VolumeUpDown(ISeries<Double> input);
        /// <summary>
        /// VolumeZones method.
        /// </summary>
        /// <returns>VolumeZones</returns>
        public VolumeZones VolumeZones();
        /// <summary>
        /// VolumeZones method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>VolumeZones</returns>
        public VolumeZones VolumeZones(ISeries<Double> input);
        /// <summary>
        /// Vortex method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>Vortex</returns>
        public Vortex Vortex(Int32 period);
        /// <summary>
        /// Vortex method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>Vortex</returns>
        public Vortex Vortex(ISeries<Double> input, Int32 period);
        /// <summary>
        /// VROC method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>VROC</returns>
        public VROC VROC(Int32 period, Int32 smooth);
        /// <summary>
        /// VROC method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <param name="smooth">Int32</param>
        /// <returns>VROC</returns>
        public VROC VROC(ISeries<Double> input, Int32 period, Int32 smooth);
        /// <summary>
        /// VWMA method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>VWMA</returns>
        public VWMA VWMA(Int32 period);
        /// <summary>
        /// VWMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>VWMA</returns>
        public VWMA VWMA(ISeries<Double> input, Int32 period);
        /// <summary>
        /// WilliamsR method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>WilliamsR</returns>
        public WilliamsR WilliamsR(Int32 period);
        /// <summary>
        /// WilliamsR method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>WilliamsR</returns>
        public WilliamsR WilliamsR(ISeries<Double> input, Int32 period);
        /// <summary>
        /// WMA method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>WMA</returns>
        public WMA WMA(Int32 period);
        /// <summary>
        /// WMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>WMA</returns>
        public WMA WMA(ISeries<Double> input, Int32 period);
        /// <summary>
        /// ZigZag method.
        /// </summary>
        /// <param name="deviationType">DeviationType</param>
        /// <param name="deviationValue">Double</param>
        /// <param name="useHighLow">Boolean</param>
        /// <returns>ZigZag</returns>
        public ZigZag ZigZag(DeviationType deviationType, Double deviationValue, Boolean useHighLow);
        /// <summary>
        /// ZigZag method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="deviationType">DeviationType</param>
        /// <param name="deviationValue">Double</param>
        /// <param name="useHighLow">Boolean</param>
        /// <returns>ZigZag</returns>
        public ZigZag ZigZag(ISeries<Double> input, DeviationType deviationType, Double deviationValue, Boolean useHighLow);
        /// <summary>
        /// ZLEMA method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>ZLEMA</returns>
        public ZLEMA ZLEMA(Int32 period);
        /// <summary>
        /// ZLEMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>ZLEMA</returns>
        public ZLEMA ZLEMA(ISeries<Double> input, Int32 period);
        /// <summary>
        /// amaCurrentDayVWAP method.
        /// </summary>
        /// <param name="sessionType">amaSessionTypeVWAPD</param>
        /// <param name="bandType">amaBandTypeVWAPD</param>
        /// <param name="customTZSelector">amaTimeZonesVWAPD</param>
        /// <param name="s_CustomSessionStart">String</param>
        /// <param name="s_CustomSessionEnd">String</param>
        /// <param name="multiplierSD1">Double</param>
        /// <param name="multiplierSD2">Double</param>
        /// <param name="multiplierSD3">Double</param>
        /// <param name="multiplierQR1">Double</param>
        /// <param name="multiplierQR2">Double</param>
        /// <param name="multiplierQR3">Double</param>
        /// <returns>amaCurrentDayVWAP</returns>
        public amaCurrentDayVWAP amaCurrentDayVWAP(amaSessionTypeVWAPD sessionType, amaBandTypeVWAPD bandType, amaTimeZonesVWAPD customTZSelector, String s_CustomSessionStart, String s_CustomSessionEnd, Double multiplierSD1, Double multiplierSD2, Double multiplierSD3, Double multiplierQR1, Double multiplierQR2, Double multiplierQR3);
        /// <summary>
        /// amaCurrentDayVWAP method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="sessionType">amaSessionTypeVWAPD</param>
        /// <param name="bandType">amaBandTypeVWAPD</param>
        /// <param name="customTZSelector">amaTimeZonesVWAPD</param>
        /// <param name="s_CustomSessionStart">String</param>
        /// <param name="s_CustomSessionEnd">String</param>
        /// <param name="multiplierSD1">Double</param>
        /// <param name="multiplierSD2">Double</param>
        /// <param name="multiplierSD3">Double</param>
        /// <param name="multiplierQR1">Double</param>
        /// <param name="multiplierQR2">Double</param>
        /// <param name="multiplierQR3">Double</param>
        /// <returns>amaCurrentDayVWAP</returns>
        public amaCurrentDayVWAP amaCurrentDayVWAP(ISeries<Double> input, amaSessionTypeVWAPD sessionType, amaBandTypeVWAPD bandType, amaTimeZonesVWAPD customTZSelector, String s_CustomSessionStart, String s_CustomSessionEnd, Double multiplierSD1, Double multiplierSD2, Double multiplierSD3, Double multiplierQR1, Double multiplierQR2, Double multiplierQR3);
        /// <summary>
        /// amaCurrentMonthVWAP method.
        /// </summary>
        /// <param name="sessionType">amaSessionTypeVWAPM</param>
        /// <param name="bandType">amaBandTypeVWAPM</param>
        /// <param name="customTZSelector">amaTimeZonesVWAPM</param>
        /// <param name="s_CustomSessionStart">String</param>
        /// <param name="s_CustomSessionEnd">String</param>
        /// <param name="multiplierSD1">Double</param>
        /// <param name="multiplierSD2">Double</param>
        /// <param name="multiplierSD3">Double</param>
        /// <param name="multiplierQR1">Double</param>
        /// <param name="multiplierQR2">Double</param>
        /// <param name="multiplierQR3">Double</param>
        /// <returns>amaCurrentMonthVWAP</returns>
        public amaCurrentMonthVWAP amaCurrentMonthVWAP(amaSessionTypeVWAPM sessionType, amaBandTypeVWAPM bandType, amaTimeZonesVWAPM customTZSelector, String s_CustomSessionStart, String s_CustomSessionEnd, Double multiplierSD1, Double multiplierSD2, Double multiplierSD3, Double multiplierQR1, Double multiplierQR2, Double multiplierQR3);
        /// <summary>
        /// amaCurrentMonthVWAP method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="sessionType">amaSessionTypeVWAPM</param>
        /// <param name="bandType">amaBandTypeVWAPM</param>
        /// <param name="customTZSelector">amaTimeZonesVWAPM</param>
        /// <param name="s_CustomSessionStart">String</param>
        /// <param name="s_CustomSessionEnd">String</param>
        /// <param name="multiplierSD1">Double</param>
        /// <param name="multiplierSD2">Double</param>
        /// <param name="multiplierSD3">Double</param>
        /// <param name="multiplierQR1">Double</param>
        /// <param name="multiplierQR2">Double</param>
        /// <param name="multiplierQR3">Double</param>
        /// <returns>amaCurrentMonthVWAP</returns>
        public amaCurrentMonthVWAP amaCurrentMonthVWAP(ISeries<Double> input, amaSessionTypeVWAPM sessionType, amaBandTypeVWAPM bandType, amaTimeZonesVWAPM customTZSelector, String s_CustomSessionStart, String s_CustomSessionEnd, Double multiplierSD1, Double multiplierSD2, Double multiplierSD3, Double multiplierQR1, Double multiplierQR2, Double multiplierQR3);
        /// <summary>
        /// amaCurrentWeekVWAP method.
        /// </summary>
        /// <param name="sessionType">amaSessionTypeVWAPW</param>
        /// <param name="bandType">amaBandTypeVWAPW</param>
        /// <param name="customTZSelector">amaTimeZonesVWAPW</param>
        /// <param name="s_CustomSessionStart">String</param>
        /// <param name="s_CustomSessionEnd">String</param>
        /// <param name="multiplierSD1">Double</param>
        /// <param name="multiplierSD2">Double</param>
        /// <param name="multiplierSD3">Double</param>
        /// <param name="multiplierQR1">Double</param>
        /// <param name="multiplierQR2">Double</param>
        /// <param name="multiplierQR3">Double</param>
        /// <returns>amaCurrentWeekVWAP</returns>
        public amaCurrentWeekVWAP amaCurrentWeekVWAP(amaSessionTypeVWAPW sessionType, amaBandTypeVWAPW bandType, amaTimeZonesVWAPW customTZSelector, String s_CustomSessionStart, String s_CustomSessionEnd, Double multiplierSD1, Double multiplierSD2, Double multiplierSD3, Double multiplierQR1, Double multiplierQR2, Double multiplierQR3);
        /// <summary>
        /// amaCurrentWeekVWAP method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="sessionType">amaSessionTypeVWAPW</param>
        /// <param name="bandType">amaBandTypeVWAPW</param>
        /// <param name="customTZSelector">amaTimeZonesVWAPW</param>
        /// <param name="s_CustomSessionStart">String</param>
        /// <param name="s_CustomSessionEnd">String</param>
        /// <param name="multiplierSD1">Double</param>
        /// <param name="multiplierSD2">Double</param>
        /// <param name="multiplierSD3">Double</param>
        /// <param name="multiplierQR1">Double</param>
        /// <param name="multiplierQR2">Double</param>
        /// <param name="multiplierQR3">Double</param>
        /// <returns>amaCurrentWeekVWAP</returns>
        public amaCurrentWeekVWAP amaCurrentWeekVWAP(ISeries<Double> input, amaSessionTypeVWAPW sessionType, amaBandTypeVWAPW bandType, amaTimeZonesVWAPW customTZSelector, String s_CustomSessionStart, String s_CustomSessionEnd, Double multiplierSD1, Double multiplierSD2, Double multiplierSD3, Double multiplierQR1, Double multiplierQR2, Double multiplierQR3);
        /// <summary>
        /// amaNMonthlyVWAP method.
        /// </summary>
        /// <param name="resetPeriod">amaResetPeriodVWAPN</param>
        /// <param name="sessionType">amaSessionTypeVWAPN</param>
        /// <param name="bandType">amaBandTypeVWAPN</param>
        /// <param name="customTZSelector">amaTimeZonesVWAPN</param>
        /// <param name="s_CustomSessionStart">String</param>
        /// <param name="s_CustomSessionEnd">String</param>
        /// <param name="multiplierSD1">Double</param>
        /// <param name="multiplierSD2">Double</param>
        /// <param name="multiplierSD3">Double</param>
        /// <param name="multiplierQR1">Double</param>
        /// <param name="multiplierQR2">Double</param>
        /// <param name="multiplierQR3">Double</param>
        /// <returns>amaNMonthlyVWAP</returns>
        public amaNMonthlyVWAP amaNMonthlyVWAP(amaResetPeriodVWAPN resetPeriod, amaSessionTypeVWAPN sessionType, amaBandTypeVWAPN bandType, amaTimeZonesVWAPN customTZSelector, String s_CustomSessionStart, String s_CustomSessionEnd, Double multiplierSD1, Double multiplierSD2, Double multiplierSD3, Double multiplierQR1, Double multiplierQR2, Double multiplierQR3);
        /// <summary>
        /// amaNMonthlyVWAP method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="resetPeriod">amaResetPeriodVWAPN</param>
        /// <param name="sessionType">amaSessionTypeVWAPN</param>
        /// <param name="bandType">amaBandTypeVWAPN</param>
        /// <param name="customTZSelector">amaTimeZonesVWAPN</param>
        /// <param name="s_CustomSessionStart">String</param>
        /// <param name="s_CustomSessionEnd">String</param>
        /// <param name="multiplierSD1">Double</param>
        /// <param name="multiplierSD2">Double</param>
        /// <param name="multiplierSD3">Double</param>
        /// <param name="multiplierQR1">Double</param>
        /// <param name="multiplierQR2">Double</param>
        /// <param name="multiplierQR3">Double</param>
        /// <returns>amaNMonthlyVWAP</returns>
        public amaNMonthlyVWAP amaNMonthlyVWAP(ISeries<Double> input, amaResetPeriodVWAPN resetPeriod, amaSessionTypeVWAPN sessionType, amaBandTypeVWAPN bandType, amaTimeZonesVWAPN customTZSelector, String s_CustomSessionStart, String s_CustomSessionEnd, Double multiplierSD1, Double multiplierSD2, Double multiplierSD3, Double multiplierQR1, Double multiplierQR2, Double multiplierQR3);
        /// <summary>
        /// AnalogBasedPriceProjection method.
        /// </summary>
        /// <param name="numMatches">Int32</param>
        /// <param name="projectionWindow">Int32</param>
        /// <param name="useDayOfWeekStats">Boolean</param>
        /// <param name="matchVolatilityRegime">Boolean</param>
        /// <param name="cumReturnWeight">Double</param>
        /// <param name="debugOutput">Boolean</param>
        /// <param name="minUpsideProbabilityAlertBullishThreshold">Double</param>
        /// <param name="maxUpsideProbabilityAlertBearishThreshold">Double</param>
        /// <param name="minimumMatchedHistoricalBars">Int32</param>
        /// <param name="minBarsBetweenVoiceAlerts">Int32</param>
        /// <param name="minimumProjectionPriceChangePts">Double</param>
        /// <param name="maxSimilarAnalogsWeightMultiplier">Double</param>
        /// <returns>AnalogBasedPriceProjection</returns>
        public AnalogBasedPriceProjection AnalogBasedPriceProjection(Int32 numMatches, Int32 projectionWindow, Boolean useDayOfWeekStats, Boolean matchVolatilityRegime, Double cumReturnWeight, Boolean debugOutput, Double minUpsideProbabilityAlertBullishThreshold, Double maxUpsideProbabilityAlertBearishThreshold, Int32 minimumMatchedHistoricalBars, Int32 minBarsBetweenVoiceAlerts, Double minimumProjectionPriceChangePts, Double maxSimilarAnalogsWeightMultiplier);
        /// <summary>
        /// AnalogBasedPriceProjection method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="numMatches">Int32</param>
        /// <param name="projectionWindow">Int32</param>
        /// <param name="useDayOfWeekStats">Boolean</param>
        /// <param name="matchVolatilityRegime">Boolean</param>
        /// <param name="cumReturnWeight">Double</param>
        /// <param name="debugOutput">Boolean</param>
        /// <param name="minUpsideProbabilityAlertBullishThreshold">Double</param>
        /// <param name="maxUpsideProbabilityAlertBearishThreshold">Double</param>
        /// <param name="minimumMatchedHistoricalBars">Int32</param>
        /// <param name="minBarsBetweenVoiceAlerts">Int32</param>
        /// <param name="minimumProjectionPriceChangePts">Double</param>
        /// <param name="maxSimilarAnalogsWeightMultiplier">Double</param>
        /// <returns>AnalogBasedPriceProjection</returns>
        public AnalogBasedPriceProjection AnalogBasedPriceProjection(ISeries<Double> input, Int32 numMatches, Int32 projectionWindow, Boolean useDayOfWeekStats, Boolean matchVolatilityRegime, Double cumReturnWeight, Boolean debugOutput, Double minUpsideProbabilityAlertBullishThreshold, Double maxUpsideProbabilityAlertBearishThreshold, Int32 minimumMatchedHistoricalBars, Int32 minBarsBetweenVoiceAlerts, Double minimumProjectionPriceChangePts, Double maxSimilarAnalogsWeightMultiplier);
        /// <summary>
        /// AnchoredVWAP method.
        /// </summary>
        /// <param name="anchorDate">DateTime</param>
        /// <param name="anchorTimeOfDay">TimeSpan</param>
        /// <param name="lineColor">Brush</param>
        /// <param name="lineStyle">DashStyleHelper</param>
        /// <param name="lineWidth">Int32</param>
        /// <returns>AnchoredVWAP</returns>
        public AnchoredVWAP AnchoredVWAP(DateTime anchorDate, TimeSpan anchorTimeOfDay, Brush lineColor, DashStyleHelper lineStyle, Int32 lineWidth);
        /// <summary>
        /// AnchoredVWAP method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="anchorDate">DateTime</param>
        /// <param name="anchorTimeOfDay">TimeSpan</param>
        /// <param name="lineColor">Brush</param>
        /// <param name="lineStyle">DashStyleHelper</param>
        /// <param name="lineWidth">Int32</param>
        /// <returns>AnchoredVWAP</returns>
        public AnchoredVWAP AnchoredVWAP(ISeries<Double> input, DateTime anchorDate, TimeSpan anchorTimeOfDay, Brush lineColor, DashStyleHelper lineStyle, Int32 lineWidth);
        /// <summary>
        /// EngulfingSignalIndicator method.
        /// </summary>
        /// <param name="signalFileName">String</param>
        /// <param name="bullishAlertText">String</param>
        /// <param name="bearishAlertText">String</param>
        /// <returns>EngulfingSignalIndicator</returns>
        public EngulfingSignalIndicator EngulfingSignalIndicator(String signalFileName, String bullishAlertText, String bearishAlertText);
        /// <summary>
        /// EngulfingSignalIndicator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="signalFileName">String</param>
        /// <param name="bullishAlertText">String</param>
        /// <param name="bearishAlertText">String</param>
        /// <returns>EngulfingSignalIndicator</returns>
        public EngulfingSignalIndicator EngulfingSignalIndicator(ISeries<Double> input, String signalFileName, String bullishAlertText, String bearishAlertText);
        /// <summary>
        /// ExampleDebugIndicator method.
        /// </summary>
        /// <returns>ExampleDebugIndicator</returns>
        public ExampleDebugIndicator ExampleDebugIndicator();
        /// <summary>
        /// ExampleDebugIndicator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>ExampleDebugIndicator</returns>
        public ExampleDebugIndicator ExampleDebugIndicator(ISeries<Double> input);
        /// <summary>
        /// FullChartDateRange method.
        /// </summary>
        /// <returns>FullChartDateRange</returns>
        public FullChartDateRange FullChartDateRange();
        /// <summary>
        /// FullChartDateRange method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>FullChartDateRange</returns>
        public FullChartDateRange FullChartDateRange(ISeries<Double> input);
        /// <summary>
        /// HighlightBarRatioAnomaliesShifted method.
        /// </summary>
        /// <param name="secondaryBarsPeriodType">BarsPeriodType</param>
        /// <param name="secondaryPeriodValue">Int32</param>
        /// <param name="futureBarsToPlot">Int32</param>
        /// <param name="minPercentToHighlightBullish">Double</param>
        /// <param name="maxPercentToHighlightBearish">Double</param>
        /// <param name="useTrendFilter">Boolean</param>
        /// <param name="vwmaLength">Int32</param>
        /// <param name="minSamplesAfterTrendFilter">Int32</param>
        /// <param name="showSessionDiagnostics">Boolean</param>
        /// <param name="sessionDiagnosticColor">Brush</param>
        /// <returns>HighlightBarRatioAnomaliesShifted</returns>
        public HighlightBarRatioAnomaliesShifted HighlightBarRatioAnomaliesShifted(BarsPeriodType secondaryBarsPeriodType, Int32 secondaryPeriodValue, Int32 futureBarsToPlot, Double minPercentToHighlightBullish, Double maxPercentToHighlightBearish, Boolean useTrendFilter, Int32 vwmaLength, Int32 minSamplesAfterTrendFilter, Boolean showSessionDiagnostics, Brush sessionDiagnosticColor);
        /// <summary>
        /// HighlightBarRatioAnomaliesShifted method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="secondaryBarsPeriodType">BarsPeriodType</param>
        /// <param name="secondaryPeriodValue">Int32</param>
        /// <param name="futureBarsToPlot">Int32</param>
        /// <param name="minPercentToHighlightBullish">Double</param>
        /// <param name="maxPercentToHighlightBearish">Double</param>
        /// <param name="useTrendFilter">Boolean</param>
        /// <param name="vwmaLength">Int32</param>
        /// <param name="minSamplesAfterTrendFilter">Int32</param>
        /// <param name="showSessionDiagnostics">Boolean</param>
        /// <param name="sessionDiagnosticColor">Brush</param>
        /// <returns>HighlightBarRatioAnomaliesShifted</returns>
        public HighlightBarRatioAnomaliesShifted HighlightBarRatioAnomaliesShifted(ISeries<Double> input, BarsPeriodType secondaryBarsPeriodType, Int32 secondaryPeriodValue, Int32 futureBarsToPlot, Double minPercentToHighlightBullish, Double maxPercentToHighlightBearish, Boolean useTrendFilter, Int32 vwmaLength, Int32 minSamplesAfterTrendFilter, Boolean showSessionDiagnostics, Brush sessionDiagnosticColor);
        /// <summary>
        /// HighlightBarRatioAnomaliesShifted_ORG method.
        /// </summary>
        /// <param name="secondaryBarsPeriodType">BarsPeriodType</param>
        /// <param name="secondaryPeriodValue">Int32</param>
        /// <param name="futureBarsToPlot">Int32</param>
        /// <param name="minPercentToHighlightBullish">Double</param>
        /// <param name="maxPercentToHighlightBearish">Double</param>
        /// <param name="useTrendFilter">Boolean</param>
        /// <param name="vwmaLength">Int32</param>
        /// <param name="minSamplesAfterTrendFilter">Int32</param>
        /// <returns>HighlightBarRatioAnomaliesShifted_ORG</returns>
        public HighlightBarRatioAnomaliesShifted_ORG HighlightBarRatioAnomaliesShifted_ORG(BarsPeriodType secondaryBarsPeriodType, Int32 secondaryPeriodValue, Int32 futureBarsToPlot, Double minPercentToHighlightBullish, Double maxPercentToHighlightBearish, Boolean useTrendFilter, Int32 vwmaLength, Int32 minSamplesAfterTrendFilter);
        /// <summary>
        /// HighlightBarRatioAnomaliesShifted_ORG method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="secondaryBarsPeriodType">BarsPeriodType</param>
        /// <param name="secondaryPeriodValue">Int32</param>
        /// <param name="futureBarsToPlot">Int32</param>
        /// <param name="minPercentToHighlightBullish">Double</param>
        /// <param name="maxPercentToHighlightBearish">Double</param>
        /// <param name="useTrendFilter">Boolean</param>
        /// <param name="vwmaLength">Int32</param>
        /// <param name="minSamplesAfterTrendFilter">Int32</param>
        /// <returns>HighlightBarRatioAnomaliesShifted_ORG</returns>
        public HighlightBarRatioAnomaliesShifted_ORG HighlightBarRatioAnomaliesShifted_ORG(ISeries<Double> input, BarsPeriodType secondaryBarsPeriodType, Int32 secondaryPeriodValue, Int32 futureBarsToPlot, Double minPercentToHighlightBullish, Double maxPercentToHighlightBearish, Boolean useTrendFilter, Int32 vwmaLength, Int32 minSamplesAfterTrendFilter);
        /// <summary>
        /// HurstExponentIndicator method.
        /// </summary>
        /// <param name="length">Int32</param>
        /// <param name="baseScale">Int32</param>
        /// <param name="maxScale">Int32</param>
        /// <returns>HurstExponentIndicator</returns>
        public HurstExponentIndicator HurstExponentIndicator(Int32 length, Int32 baseScale, Int32 maxScale);
        /// <summary>
        /// HurstExponentIndicator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="length">Int32</param>
        /// <param name="baseScale">Int32</param>
        /// <param name="maxScale">Int32</param>
        /// <returns>HurstExponentIndicator</returns>
        public HurstExponentIndicator HurstExponentIndicator(ISeries<Double> input, Int32 length, Int32 baseScale, Int32 maxScale);
        /// <summary>
        /// MatLevelsExporter method.
        /// </summary>
        /// <param name="saveDirectory">String</param>
        /// <param name="maxVpocCalculationDaysBack">Int32</param>
        /// <param name="verboseDebugging">Boolean</param>
        /// <param name="euOpenHour">Int32</param>
        /// <param name="euOpenMinute">Int32</param>
        /// <param name="displayEuORDuringUsSession">Boolean</param>
        /// <param name="londonOpenHour">Int32</param>
        /// <param name="londonOpenMinute">Int32</param>
        /// <param name="usOpenHour">Int32</param>
        /// <param name="usOpenMinute">Int32</param>
        /// <param name="newSessionHour">Int32</param>
        /// <param name="settleHour">Int32</param>
        /// <param name="settleMinute">Int32</param>
        /// <param name="cmeCurrencyEuOpenHour">Int32</param>
        /// <param name="cmeCurrencyEuOpenMinute">Int32</param>
        /// <param name="cmeCurrencyLondonOpenHour">Int32</param>
        /// <param name="cmeCurrencyLondonOpenMinute">Int32</param>
        /// <param name="cmeCurrencyUsOpenHour">Int32</param>
        /// <param name="cmeCurrencyUsOpenMinute">Int32</param>
        /// <param name="cmeCurrencyNewSessionHour">Int32</param>
        /// <param name="cmeCurrencySettleHour">Int32</param>
        /// <param name="cmeCurrencySettleMinute">Int32</param>
        /// <param name="cbotBondEuOpenHour">Int32</param>
        /// <param name="cbotBondEuOpenMinute">Int32</param>
        /// <param name="cbotBondLondonOpenHour">Int32</param>
        /// <param name="cbotBondLondonOpenMinute">Int32</param>
        /// <param name="cbotBondUsOpenHour">Int32</param>
        /// <param name="cbotBondUsOpenMinute">Int32</param>
        /// <param name="cbotBondNewSessionHour">Int32</param>
        /// <param name="cbotBondSettleHour">Int32</param>
        /// <param name="cbotBondSettleMinute">Int32</param>
        /// <param name="eurexIndexEuOpenHour">Int32</param>
        /// <param name="eurexIndexEuOpenMinute">Int32</param>
        /// <param name="eurexIndexLondonOpenHour">Int32</param>
        /// <param name="eurexIndexLondonOpenMinute">Int32</param>
        /// <param name="eurexIndexUsOpenHour">Int32</param>
        /// <param name="eurexIndexUsOpenMinute">Int32</param>
        /// <param name="eurexIndexNewSessionHour">Int32</param>
        /// <param name="eurexIndexSettleHour">Int32</param>
        /// <param name="eurexIndexSettleMinute">Int32</param>
        /// <param name="eurexBondEuOpenHour">Int32</param>
        /// <param name="eurexBondEuOpenMinute">Int32</param>
        /// <param name="eurexBondLondonOpenHour">Int32</param>
        /// <param name="eurexBondLondonOpenMinute">Int32</param>
        /// <param name="eurexBondUsOpenHour">Int32</param>
        /// <param name="eurexBondUsOpenMinute">Int32</param>
        /// <param name="eurexBondNewSessionHour">Int32</param>
        /// <param name="eurexBondSettleHour">Int32</param>
        /// <param name="eurexBondSettleMinute">Int32</param>
        /// <param name="displayAsianSessionHL">Boolean</param>
        /// <param name="displayUsSessionAverageRange15">Boolean</param>
        /// <param name="displayUsSessionAverageRange60">Boolean</param>
        /// <param name="displayUsSessionTargets">Boolean</param>
        /// <param name="target1">Double</param>
        /// <param name="target2">Double</param>
        /// <param name="target3">Double</param>
        /// <param name="target4">Double</param>
        /// <param name="target5">Double</param>
        /// <param name="target6">Double</param>
        /// <param name="displayEuSessionTargets">Boolean</param>
        /// <param name="euTarget1">Double</param>
        /// <param name="euTarget2">Double</param>
        /// <param name="euTarget3">Double</param>
        /// <param name="euTarget4">Double</param>
        /// <param name="euTarget5">Double</param>
        /// <param name="euTarget6">Double</param>
        /// <returns>MatLevelsExporter</returns>
        public MatLevelsExporter MatLevelsExporter(String saveDirectory, Int32 maxVpocCalculationDaysBack, Boolean verboseDebugging, Int32 euOpenHour, Int32 euOpenMinute, Boolean displayEuORDuringUsSession, Int32 londonOpenHour, Int32 londonOpenMinute, Int32 usOpenHour, Int32 usOpenMinute, Int32 newSessionHour, Int32 settleHour, Int32 settleMinute, Int32 cmeCurrencyEuOpenHour, Int32 cmeCurrencyEuOpenMinute, Int32 cmeCurrencyLondonOpenHour, Int32 cmeCurrencyLondonOpenMinute, Int32 cmeCurrencyUsOpenHour, Int32 cmeCurrencyUsOpenMinute, Int32 cmeCurrencyNewSessionHour, Int32 cmeCurrencySettleHour, Int32 cmeCurrencySettleMinute, Int32 cbotBondEuOpenHour, Int32 cbotBondEuOpenMinute, Int32 cbotBondLondonOpenHour, Int32 cbotBondLondonOpenMinute, Int32 cbotBondUsOpenHour, Int32 cbotBondUsOpenMinute, Int32 cbotBondNewSessionHour, Int32 cbotBondSettleHour, Int32 cbotBondSettleMinute, Int32 eurexIndexEuOpenHour, Int32 eurexIndexEuOpenMinute, Int32 eurexIndexLondonOpenHour, Int32 eurexIndexLondonOpenMinute, Int32 eurexIndexUsOpenHour, Int32 eurexIndexUsOpenMinute, Int32 eurexIndexNewSessionHour, Int32 eurexIndexSettleHour, Int32 eurexIndexSettleMinute, Int32 eurexBondEuOpenHour, Int32 eurexBondEuOpenMinute, Int32 eurexBondLondonOpenHour, Int32 eurexBondLondonOpenMinute, Int32 eurexBondUsOpenHour, Int32 eurexBondUsOpenMinute, Int32 eurexBondNewSessionHour, Int32 eurexBondSettleHour, Int32 eurexBondSettleMinute, Boolean displayAsianSessionHL, Boolean displayUsSessionAverageRange15, Boolean displayUsSessionAverageRange60, Boolean displayUsSessionTargets, Double target1, Double target2, Double target3, Double target4, Double target5, Double target6, Boolean displayEuSessionTargets, Double euTarget1, Double euTarget2, Double euTarget3, Double euTarget4, Double euTarget5, Double euTarget6);
        /// <summary>
        /// MatLevelsExporter method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="saveDirectory">String</param>
        /// <param name="maxVpocCalculationDaysBack">Int32</param>
        /// <param name="verboseDebugging">Boolean</param>
        /// <param name="euOpenHour">Int32</param>
        /// <param name="euOpenMinute">Int32</param>
        /// <param name="displayEuORDuringUsSession">Boolean</param>
        /// <param name="londonOpenHour">Int32</param>
        /// <param name="londonOpenMinute">Int32</param>
        /// <param name="usOpenHour">Int32</param>
        /// <param name="usOpenMinute">Int32</param>
        /// <param name="newSessionHour">Int32</param>
        /// <param name="settleHour">Int32</param>
        /// <param name="settleMinute">Int32</param>
        /// <param name="cmeCurrencyEuOpenHour">Int32</param>
        /// <param name="cmeCurrencyEuOpenMinute">Int32</param>
        /// <param name="cmeCurrencyLondonOpenHour">Int32</param>
        /// <param name="cmeCurrencyLondonOpenMinute">Int32</param>
        /// <param name="cmeCurrencyUsOpenHour">Int32</param>
        /// <param name="cmeCurrencyUsOpenMinute">Int32</param>
        /// <param name="cmeCurrencyNewSessionHour">Int32</param>
        /// <param name="cmeCurrencySettleHour">Int32</param>
        /// <param name="cmeCurrencySettleMinute">Int32</param>
        /// <param name="cbotBondEuOpenHour">Int32</param>
        /// <param name="cbotBondEuOpenMinute">Int32</param>
        /// <param name="cbotBondLondonOpenHour">Int32</param>
        /// <param name="cbotBondLondonOpenMinute">Int32</param>
        /// <param name="cbotBondUsOpenHour">Int32</param>
        /// <param name="cbotBondUsOpenMinute">Int32</param>
        /// <param name="cbotBondNewSessionHour">Int32</param>
        /// <param name="cbotBondSettleHour">Int32</param>
        /// <param name="cbotBondSettleMinute">Int32</param>
        /// <param name="eurexIndexEuOpenHour">Int32</param>
        /// <param name="eurexIndexEuOpenMinute">Int32</param>
        /// <param name="eurexIndexLondonOpenHour">Int32</param>
        /// <param name="eurexIndexLondonOpenMinute">Int32</param>
        /// <param name="eurexIndexUsOpenHour">Int32</param>
        /// <param name="eurexIndexUsOpenMinute">Int32</param>
        /// <param name="eurexIndexNewSessionHour">Int32</param>
        /// <param name="eurexIndexSettleHour">Int32</param>
        /// <param name="eurexIndexSettleMinute">Int32</param>
        /// <param name="eurexBondEuOpenHour">Int32</param>
        /// <param name="eurexBondEuOpenMinute">Int32</param>
        /// <param name="eurexBondLondonOpenHour">Int32</param>
        /// <param name="eurexBondLondonOpenMinute">Int32</param>
        /// <param name="eurexBondUsOpenHour">Int32</param>
        /// <param name="eurexBondUsOpenMinute">Int32</param>
        /// <param name="eurexBondNewSessionHour">Int32</param>
        /// <param name="eurexBondSettleHour">Int32</param>
        /// <param name="eurexBondSettleMinute">Int32</param>
        /// <param name="displayAsianSessionHL">Boolean</param>
        /// <param name="displayUsSessionAverageRange15">Boolean</param>
        /// <param name="displayUsSessionAverageRange60">Boolean</param>
        /// <param name="displayUsSessionTargets">Boolean</param>
        /// <param name="target1">Double</param>
        /// <param name="target2">Double</param>
        /// <param name="target3">Double</param>
        /// <param name="target4">Double</param>
        /// <param name="target5">Double</param>
        /// <param name="target6">Double</param>
        /// <param name="displayEuSessionTargets">Boolean</param>
        /// <param name="euTarget1">Double</param>
        /// <param name="euTarget2">Double</param>
        /// <param name="euTarget3">Double</param>
        /// <param name="euTarget4">Double</param>
        /// <param name="euTarget5">Double</param>
        /// <param name="euTarget6">Double</param>
        /// <returns>MatLevelsExporter</returns>
        public MatLevelsExporter MatLevelsExporter(ISeries<Double> input, String saveDirectory, Int32 maxVpocCalculationDaysBack, Boolean verboseDebugging, Int32 euOpenHour, Int32 euOpenMinute, Boolean displayEuORDuringUsSession, Int32 londonOpenHour, Int32 londonOpenMinute, Int32 usOpenHour, Int32 usOpenMinute, Int32 newSessionHour, Int32 settleHour, Int32 settleMinute, Int32 cmeCurrencyEuOpenHour, Int32 cmeCurrencyEuOpenMinute, Int32 cmeCurrencyLondonOpenHour, Int32 cmeCurrencyLondonOpenMinute, Int32 cmeCurrencyUsOpenHour, Int32 cmeCurrencyUsOpenMinute, Int32 cmeCurrencyNewSessionHour, Int32 cmeCurrencySettleHour, Int32 cmeCurrencySettleMinute, Int32 cbotBondEuOpenHour, Int32 cbotBondEuOpenMinute, Int32 cbotBondLondonOpenHour, Int32 cbotBondLondonOpenMinute, Int32 cbotBondUsOpenHour, Int32 cbotBondUsOpenMinute, Int32 cbotBondNewSessionHour, Int32 cbotBondSettleHour, Int32 cbotBondSettleMinute, Int32 eurexIndexEuOpenHour, Int32 eurexIndexEuOpenMinute, Int32 eurexIndexLondonOpenHour, Int32 eurexIndexLondonOpenMinute, Int32 eurexIndexUsOpenHour, Int32 eurexIndexUsOpenMinute, Int32 eurexIndexNewSessionHour, Int32 eurexIndexSettleHour, Int32 eurexIndexSettleMinute, Int32 eurexBondEuOpenHour, Int32 eurexBondEuOpenMinute, Int32 eurexBondLondonOpenHour, Int32 eurexBondLondonOpenMinute, Int32 eurexBondUsOpenHour, Int32 eurexBondUsOpenMinute, Int32 eurexBondNewSessionHour, Int32 eurexBondSettleHour, Int32 eurexBondSettleMinute, Boolean displayAsianSessionHL, Boolean displayUsSessionAverageRange15, Boolean displayUsSessionAverageRange60, Boolean displayUsSessionTargets, Double target1, Double target2, Double target3, Double target4, Double target5, Double target6, Boolean displayEuSessionTargets, Double euTarget1, Double euTarget2, Double euTarget3, Double euTarget4, Double euTarget5, Double euTarget6);
        /// <summary>
        /// MatTest method.
        /// </summary>
        /// <returns>MatTest</returns>
        public MatTest MatTest();
        /// <summary>
        /// MatTest method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>MatTest</returns>
        public MatTest MatTest(ISeries<Double> input);
        /// <summary>
        /// NadarayaWatsonEnvelope method.
        /// </summary>
        /// <returns>NadarayaWatsonEnvelope</returns>
        public NadarayaWatsonEnvelope NadarayaWatsonEnvelope();
        /// <summary>
        /// NadarayaWatsonEnvelope method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>NadarayaWatsonEnvelope</returns>
        public NadarayaWatsonEnvelope NadarayaWatsonEnvelope(ISeries<Double> input);
        /// <summary>
        /// OpeningRange method.
        /// </summary>
        /// <returns>OpeningRange</returns>
        public OpeningRange OpeningRange();
        /// <summary>
        /// OpeningRange method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>OpeningRange</returns>
        public OpeningRange OpeningRange(ISeries<Double> input);
        /// <summary>
        /// SineWaveMultiFit method.
        /// </summary>
        /// <param name="zigZagDeviation">Double</param>
        /// <param name="maxPivots">Int32</param>
        /// <param name="numWaves">Int32</param>
        /// <param name="minPeriod">Int32</param>
        /// <param name="maxPeriod">Int32</param>
        /// <param name="projectionFactor">Int32</param>
        /// <returns>SineWaveMultiFit</returns>
        public SineWaveMultiFit SineWaveMultiFit(Double zigZagDeviation, Int32 maxPivots, Int32 numWaves, Int32 minPeriod, Int32 maxPeriod, Int32 projectionFactor);
        /// <summary>
        /// SineWaveMultiFit method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="zigZagDeviation">Double</param>
        /// <param name="maxPivots">Int32</param>
        /// <param name="numWaves">Int32</param>
        /// <param name="minPeriod">Int32</param>
        /// <param name="maxPeriod">Int32</param>
        /// <param name="projectionFactor">Int32</param>
        /// <returns>SineWaveMultiFit</returns>
        public SineWaveMultiFit SineWaveMultiFit(ISeries<Double> input, Double zigZagDeviation, Int32 maxPivots, Int32 numWaves, Int32 minPeriod, Int32 maxPeriod, Int32 projectionFactor);
        /// <summary>
        /// SuperTrend method.
        /// </summary>
        /// <param name="aTRMultiplier">Double</param>
        /// <param name="aTRPeriod">Int32</param>
        /// <returns>SuperTrend</returns>
        public SuperTrend SuperTrend(Double aTRMultiplier, Int32 aTRPeriod);
        /// <summary>
        /// SuperTrend method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="aTRMultiplier">Double</param>
        /// <param name="aTRPeriod">Int32</param>
        /// <returns>SuperTrend</returns>
        public SuperTrend SuperTrend(ISeries<Double> input, Double aTRMultiplier, Int32 aTRPeriod);
        /// <summary>
        /// VWMACenteredATRBands method.
        /// </summary>
        /// <param name="vWMAPeriod">Int32</param>
        /// <param name="aTRPeriod">Int32</param>
        /// <param name="multiplier">Double</param>
        /// <returns>VWMACenteredATRBands</returns>
        public VWMACenteredATRBands VWMACenteredATRBands(Int32 vWMAPeriod, Int32 aTRPeriod, Double multiplier);
        /// <summary>
        /// VWMACenteredATRBands method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="vWMAPeriod">Int32</param>
        /// <param name="aTRPeriod">Int32</param>
        /// <param name="multiplier">Double</param>
        /// <returns>VWMACenteredATRBands</returns>
        public VWMACenteredATRBands VWMACenteredATRBands(ISeries<Double> input, Int32 vWMAPeriod, Int32 aTRPeriod, Double multiplier);
        /// <summary>
        /// ZigZagAnchoredVWAP method.
        /// </summary>
        /// <param name="zigZagPercent">Double</param>
        /// <param name="zigZagLookBack">Int32</param>
        /// <param name="useHighLow">Boolean</param>
        /// <param name="anchorBarsBack">Int32</param>
        /// <param name="minAvwapDistancePct">Double</param>
        /// <returns>ZigZagAnchoredVWAP</returns>
        public ZigZagAnchoredVWAP ZigZagAnchoredVWAP(Double zigZagPercent, Int32 zigZagLookBack, Boolean useHighLow, Int32 anchorBarsBack, Double minAvwapDistancePct);
        /// <summary>
        /// ZigZagAnchoredVWAP method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="zigZagPercent">Double</param>
        /// <param name="zigZagLookBack">Int32</param>
        /// <param name="useHighLow">Boolean</param>
        /// <param name="anchorBarsBack">Int32</param>
        /// <param name="minAvwapDistancePct">Double</param>
        /// <returns>ZigZagAnchoredVWAP</returns>
        public ZigZagAnchoredVWAP ZigZagAnchoredVWAP(ISeries<Double> input, Double zigZagPercent, Int32 zigZagLookBack, Boolean useHighLow, Int32 anchorBarsBack, Double minAvwapDistancePct);
        /// <summary>
        /// WoodiesCCI method.
        /// </summary>
        /// <param name="chopIndicatorWidth">Int32</param>
        /// <param name="neutralBars">Int32</param>
        /// <param name="period">Int32</param>
        /// <param name="periodEma">Int32</param>
        /// <param name="periodLinReg">Int32</param>
        /// <param name="periodTurbo">Int32</param>
        /// <param name="sideWinderLimit0">Int32</param>
        /// <param name="sideWinderLimit1">Int32</param>
        /// <param name="sideWinderWidth">Int32</param>
        /// <returns>WoodiesCCI</returns>
        public WoodiesCCI WoodiesCCI(Int32 chopIndicatorWidth, Int32 neutralBars, Int32 period, Int32 periodEma, Int32 periodLinReg, Int32 periodTurbo, Int32 sideWinderLimit0, Int32 sideWinderLimit1, Int32 sideWinderWidth);
        /// <summary>
        /// WoodiesCCI method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="chopIndicatorWidth">Int32</param>
        /// <param name="neutralBars">Int32</param>
        /// <param name="period">Int32</param>
        /// <param name="periodEma">Int32</param>
        /// <param name="periodLinReg">Int32</param>
        /// <param name="periodTurbo">Int32</param>
        /// <param name="sideWinderLimit0">Int32</param>
        /// <param name="sideWinderLimit1">Int32</param>
        /// <param name="sideWinderWidth">Int32</param>
        /// <returns>WoodiesCCI</returns>
        public WoodiesCCI WoodiesCCI(ISeries<Double> input, Int32 chopIndicatorWidth, Int32 neutralBars, Int32 period, Int32 periodEma, Int32 periodLinReg, Int32 periodTurbo, Int32 sideWinderLimit0, Int32 sideWinderLimit1, Int32 sideWinderWidth);
        /// <summary>
        /// WoodiesPivots method.
        /// </summary>
        /// <param name="priorDayHlc">HLCCalculationModeWoodie</param>
        /// <param name="width">Int32</param>
        /// <returns>WoodiesPivots</returns>
        public WoodiesPivots WoodiesPivots(HLCCalculationModeWoodie priorDayHlc, Int32 width);
        /// <summary>
        /// WoodiesPivots method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="priorDayHlc">HLCCalculationModeWoodie</param>
        /// <param name="width">Int32</param>
        /// <returns>WoodiesPivots</returns>
        public WoodiesPivots WoodiesPivots(ISeries<Double> input, HLCCalculationModeWoodie priorDayHlc, Int32 width);
        /// <summary>
        /// WisemanAlligator method.
        /// </summary>
        /// <param name="jawPeriod">Int32</param>
        /// <param name="teethPeriod">Int32</param>
        /// <param name="lipsPeriod">Int32</param>
        /// <param name="jawOffset">Int32</param>
        /// <param name="teethOffset">Int32</param>
        /// <param name="lipsOffset">Int32</param>
        /// <returns>WisemanAlligator</returns>
        public WisemanAlligator WisemanAlligator(Int32 jawPeriod, Int32 teethPeriod, Int32 lipsPeriod, Int32 jawOffset, Int32 teethOffset, Int32 lipsOffset);
        /// <summary>
        /// WisemanAlligator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="jawPeriod">Int32</param>
        /// <param name="teethPeriod">Int32</param>
        /// <param name="lipsPeriod">Int32</param>
        /// <param name="jawOffset">Int32</param>
        /// <param name="teethOffset">Int32</param>
        /// <param name="lipsOffset">Int32</param>
        /// <returns>WisemanAlligator</returns>
        public WisemanAlligator WisemanAlligator(ISeries<Double> input, Int32 jawPeriod, Int32 teethPeriod, Int32 lipsPeriod, Int32 jawOffset, Int32 teethOffset, Int32 lipsOffset);
        /// <summary>
        /// WisemanAwesomeOscillator method.
        /// </summary>
        /// <returns>WisemanAwesomeOscillator</returns>
        public WisemanAwesomeOscillator WisemanAwesomeOscillator();
        /// <summary>
        /// WisemanAwesomeOscillator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>WisemanAwesomeOscillator</returns>
        public WisemanAwesomeOscillator WisemanAwesomeOscillator(ISeries<Double> input);
        /// <summary>
        /// WisemanFractal method.
        /// </summary>
        /// <param name="strength">Int32</param>
        /// <param name="triangleOffset">Int32</param>
        /// <returns>WisemanFractal</returns>
        public WisemanFractal WisemanFractal(Int32 strength, Int32 triangleOffset);
        /// <summary>
        /// WisemanFractal method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="strength">Int32</param>
        /// <param name="triangleOffset">Int32</param>
        /// <returns>WisemanFractal</returns>
        public WisemanFractal WisemanFractal(ISeries<Double> input, Int32 strength, Int32 triangleOffset);
        /// <summary>
        /// OrderFlowCumulativeDelta method.
        /// </summary>
        /// <param name="deltaType">CumulativeDeltaType</param>
        /// <param name="period">CumulativeDeltaPeriod</param>
        /// <param name="sizeFilter">Int32</param>
        /// <returns>OrderFlowCumulativeDelta</returns>
        public OrderFlowCumulativeDelta OrderFlowCumulativeDelta(CumulativeDeltaType deltaType, CumulativeDeltaPeriod period, Int32 sizeFilter);
        /// <summary>
        /// OrderFlowCumulativeDelta method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="deltaType">CumulativeDeltaType</param>
        /// <param name="period">CumulativeDeltaPeriod</param>
        /// <param name="sizeFilter">Int32</param>
        /// <returns>OrderFlowCumulativeDelta</returns>
        public OrderFlowCumulativeDelta OrderFlowCumulativeDelta(ISeries<Double> input, CumulativeDeltaType deltaType, CumulativeDeltaPeriod period, Int32 sizeFilter);
        /// <summary>
        /// OrderFlowMarketDepthMap method.
        /// </summary>
        /// <param name="baseRange">BaseVolumeRange</param>
        /// <param name="maxRange">Int32</param>
        /// <param name="minRange">Int32</param>
        /// <param name="opacityDistribution">OpacityDistribution</param>
        /// <param name="depthMargin">Int32</param>
        /// <param name="extendLastKnown">Boolean</param>
        /// <param name="showBidAskLine">Boolean</param>
        /// <returns>OrderFlowMarketDepthMap</returns>
        public OrderFlowMarketDepthMap OrderFlowMarketDepthMap(BaseVolumeRange baseRange, Int32 maxRange, Int32 minRange, OpacityDistribution opacityDistribution, Int32 depthMargin, Boolean extendLastKnown, Boolean showBidAskLine);
        /// <summary>
        /// OrderFlowMarketDepthMap method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="baseRange">BaseVolumeRange</param>
        /// <param name="maxRange">Int32</param>
        /// <param name="minRange">Int32</param>
        /// <param name="opacityDistribution">OpacityDistribution</param>
        /// <param name="depthMargin">Int32</param>
        /// <param name="extendLastKnown">Boolean</param>
        /// <param name="showBidAskLine">Boolean</param>
        /// <returns>OrderFlowMarketDepthMap</returns>
        public OrderFlowMarketDepthMap OrderFlowMarketDepthMap(ISeries<Double> input, BaseVolumeRange baseRange, Int32 maxRange, Int32 minRange, OpacityDistribution opacityDistribution, Int32 depthMargin, Boolean extendLastKnown, Boolean showBidAskLine);
        /// <summary>
        /// OrderFlowVWAP method.
        /// </summary>
        /// <param name="resolution">VWAPResolution</param>
        /// <param name="tradingHoursInstance">TradingHours</param>
        /// <param name="numStandardDeviations">VWAPStandardDeviations</param>
        /// <param name="sD1Multiplier">Double</param>
        /// <param name="sD2Multiplier">Double</param>
        /// <param name="sD3Multiplier">Double</param>
        /// <returns>OrderFlowVWAP</returns>
        public OrderFlowVWAP OrderFlowVWAP(VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, Double sD1Multiplier, Double sD2Multiplier, Double sD3Multiplier);
        /// <summary>
        /// OrderFlowVWAP method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="resolution">VWAPResolution</param>
        /// <param name="tradingHoursInstance">TradingHours</param>
        /// <param name="numStandardDeviations">VWAPStandardDeviations</param>
        /// <param name="sD1Multiplier">Double</param>
        /// <param name="sD2Multiplier">Double</param>
        /// <param name="sD3Multiplier">Double</param>
        /// <returns>OrderFlowVWAP</returns>
        public OrderFlowVWAP OrderFlowVWAP(ISeries<Double> input, VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, Double sD1Multiplier, Double sD2Multiplier, Double sD3Multiplier);
        /// <summary>
        /// OrderFlowTradeDetector method.
        /// </summary>
        /// <param name="baseLargeVolumeOn">TradeDetectorBaseLargeVolumeOn</param>
        /// <param name="minimumVolumeForMarker">Int32</param>
        /// <param name="maximumMarkerSize">Int32</param>
        /// <param name="baseMarkerSizeOn">TradeDetectorSizeBase</param>
        /// <param name="hoverValues">Boolean</param>
        /// <returns>OrderFlowTradeDetector</returns>
        public OrderFlowTradeDetector OrderFlowTradeDetector(TradeDetectorBaseLargeVolumeOn baseLargeVolumeOn, Int32 minimumVolumeForMarker, Int32 maximumMarkerSize, TradeDetectorSizeBase baseMarkerSizeOn, Boolean hoverValues);
        /// <summary>
        /// OrderFlowTradeDetector method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="baseLargeVolumeOn">TradeDetectorBaseLargeVolumeOn</param>
        /// <param name="minimumVolumeForMarker">Int32</param>
        /// <param name="maximumMarkerSize">Int32</param>
        /// <param name="baseMarkerSizeOn">TradeDetectorSizeBase</param>
        /// <param name="hoverValues">Boolean</param>
        /// <returns>OrderFlowTradeDetector</returns>
        public OrderFlowTradeDetector OrderFlowTradeDetector(ISeries<Double> input, TradeDetectorBaseLargeVolumeOn baseLargeVolumeOn, Int32 minimumVolumeForMarker, Int32 maximumMarkerSize, TradeDetectorSizeBase baseMarkerSizeOn, Boolean hoverValues);
        #endregion
    }
}

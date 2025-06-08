# Optimizer

Namespace: `NinjaTrader.NinjaScript.Optimizers`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `NumberOfIterations` (long)
- `SupportsMultiObjectiveOptimization` (bool)
- `IsStrategyGenerator` (bool)
- `KeepBestResults` (int)
- `LogTypeName` (string)
- `MultiObjectiveOptimizationFitnesses` (NinjaTrader.NinjaScript.OptimizationFitnesses.OptimizationFitness[])
- `MultiObjectiveValues` (System.Collections.Generic.List<NinjaTrader.NinjaScript.MultiObjectiveValues>)
- `OptimizationGraphValues` (System.Collections.Generic.List<NinjaTrader.NinjaScript.OptimizationGraphValues>)
- `PreviousKeepBestResults` (int)
- `Progress` (NinjaTrader.Core.IProgress)
- `Results` (NinjaTrader.Cbi.SystemPerformance[])
- `Strategies` (System.Collections.ObjectModel.Collection<NinjaTrader.NinjaScript.StrategyBase>)

## Methods
- `GetParametersCombinationsCount(NinjaTrader.NinjaScript.StrategyBase strategyBase)` : long
- `Reset(int startWith)` : void
- `RunIteration(void)` : void
- `SetState(State state)` : void
- `WaitForIterationsCompleted(void)` : void

# HdsMaintenance

Namespace: `NinjaTrader.Server`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `BackupCallback` (System.Action<string>)
- `BackupClearCallback` (System.Action)
- `BackupCompleteCallback` (System.Action)
- `BackupFileDoneCallback` (System.Action<string>)
- `BackupStartedCallback` (System.Action)
- `MaintenanceCallback` (System.Action<string>)
- `MaintenanceClearCallback` (System.Action)
- `MaintenanceCompleteCallback` (System.Action)
- `MaintenanceStartedCallback` (System.Action)
- `BackupDirectory` (string)
- `BackupPassword` (string)
- `BackupServer` (string)
- `BackupUser` (string)
- `DailyDataUnzipped` (double)
- `DailyDataZipped` (double)
- `IsInBackup` (bool)
- `IsInMaintenance` (bool)
- `LastTimeBackup` (System.DateTime)
- `LastTimeMaintenance` (System.DateTime)
- `MigrationDirectory` (string)
- `MinuteDataUnzipped` (double)
- `MinuteDataZipped` (double)
- `ReplayDataUnzipped` (double)
- `ReplayDataZipped` (double)
- `TickDataUnzipped` (double)
- `TickDataZipped` (double)
- `DataServers` (System.Collections.ObjectModel.Collection<string>)

## Methods
- `RestoreFromXml(void)` : void
- `RunBackup(System.Action callback)` : void
- `RunMaintenance(System.Action callback)` : void
- `Start(void)` : void
- `Stop(void)` : void

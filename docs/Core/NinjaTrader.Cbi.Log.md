# Log

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Methods
- `AddLicenseManagementLog(NinjaTrader.Cbi.User affected, string by, string subject, string body, bool isBodyHtml, System.DateTime? utcNow)` : void
- `Assert(bool condition, bool showAssertDialog)` : bool
- `Assert(bool condition, string message, bool showAssertDialog)` : bool
- `Assert(bool condition, string message, string detailedMessage, bool showAssertDialog)` : bool
- `CloseWriter(void)` : void
- `Process(System.Type resourceType, string name, System.Object[] args, LogLevel logLevel, LogCategories logCategory)` : void
- `Process(System.Type resourceType, string name, System.Object[] args, LogLevel logLevel, LogCategories logCategory, NinjaTrader.Cbi.User user)` : void
- `Process(System.Type resourceType, string name, System.Object[] args, LogLevel logLevel, LogCategories logCategory, NinjaTrader.Cbi.Account account)` : void
- `ProcessAsync(System.Func<object, NinjaTrader.Cbi.LogEventArgs> func, object args)` : void
- `Shutdown(void)` : void

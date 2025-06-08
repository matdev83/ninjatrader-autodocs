# ShareService

Namespace: `NinjaTrader.NinjaScript.ShareServices`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `CharacterLimit` (int)
- `CharactersReservedPerMedia` (int)
- `IsConfigured` (bool)
- `IsDefault` (bool)
- `IsImageAttachmentSupported` (bool)
- `LogTypeName` (string)
- `Icon` (object)
- `Name` (string)
- `DisplayName` (string)
- `Signature` (string)
- `UseOAuth` (bool)

## Methods
- `CopyTo(NinjaTrader.NinjaScript.NinjaScript ninjaScript)` : void
- `OnAuthorizeAccount(void)` : System.Threading.Tasks.Task
- `OnShare(string text, string imageFilePath)` : System.Threading.Tasks.Task
- `OnShare(string text, string imageFilePath, System.Object[] args)` : System.Threading.Tasks.Task
- `SetState(State state)` : void

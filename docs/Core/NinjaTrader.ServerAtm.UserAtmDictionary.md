# UserAtmDictionary

Namespace: `NinjaTrader.ServerAtm`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `Count` (int)
- `Instance` (NinjaTrader.ServerAtm.UserAtmDictionary)
- `Keys` (System.Collections.Generic.ICollection<string>)
- `LastUpdated` (System.DateTime)
- `Item` (System.Collections.Generic.List<NinjaTrader.ServerAtm.ServerAtmStrategy>)
- `UpdatedAt` (long)
- `Values` (System.Collections.Generic.ICollection<System.Collections.Generic.List<NinjaTrader.ServerAtm.ServerAtmStrategy>>)

## Methods
- `Add(string key, System.Collections.Generic.List<NinjaTrader.ServerAtm.ServerAtmStrategy> value)` : void
- `Clear(void)` : void
- `ContainsKey(string key)` : bool
- `FromJson(string jsonString)` : void
- `RaiseUpdateEvent(object sender, string templateName)` : void
- `Remove(string key)` : bool
- `RetrieveUserAtmTemplates(string accessToken, long userId, string user)` : System.Threading.Tasks.Task
- `ToJson(string key)` : System.Text.Json.Nodes.JsonObject
- `ToJson(void)` : System.Text.Json.Nodes.JsonObject
- `TryGetValue(string key, System.Collections.Generic.List`1<NinjaTrader.ServerAtm.ServerAtmStrategy>& value)` : bool
- `ToString(void)` : string

# AssemblyRegistry

Namespace: `NinjaTrader.Core`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `Count` (int)
- `Keys` (System.String[])
- `Item` (System.Reflection.Assembly)

## Methods
- `Add(string assemblyName, System.Reflection.Assembly assembly)` : void
- `Clear(void)` : void
- `GetDerivedTypes(System.Type superClass)` : System.Type[]
- `GetDerivedTypes(System.Type superClass, bool evalBrowsable)` : System.Type[]
- `GetType(string name)` : System.Type
- `IsNinjaTraderCustomAssembly(System.Type type)` : bool
- `Remove(string key)` : bool
- `TryGetValue(string key, System.Reflection.Assembly& value)` : bool

# LoadDLL
Load Managed DLL Files in Memory


## How to use

Without Parameters
```
LoadDLL(IO.File.ReadAllBytes("Plugin.dll"), "Class1", "Run")
```

With Parameters
```
LoadDLL(IO.File.ReadAllBytes("Plugin.dll"), "Class1", "Run", True, New Dictionary(Of Object, Object)() From {
         {"var1", "hello"},
         {"var2", "world"}
})
```

## Copyright

MIT

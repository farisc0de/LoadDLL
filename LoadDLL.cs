public object LoadDLL(byte[] PluginBytes, string typeName, string methodName, bool hasParamters = false, Dictionary<object, object> paramters = null)
{
    var p = System.Reflection.Assembly.Load(PluginBytes);

    Type[] rootTypes = p.GetTypes();

    var ci = p.CreateInstance(Strings.Split(rootTypes[0].Namespace, ".")(0) + "." + typeName);

    if (hasParamters == true)
    {
        foreach (var paramter in paramters)
            Interaction.CallByName(ci, paramter.Key, CallType.Set, paramter.Value);
    }

    object obj = Interaction.CallByName(ci, methodName, CallType.Method);

    return obj;
}

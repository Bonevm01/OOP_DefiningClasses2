using System;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum
    | AttributeTargets.Method)]
public class VersionAttribute : System.Attribute
{
    public string currentVersion { get; private set; }

    public VersionAttribute(string vers)
    {
        this.currentVersion = vers;
    }
}
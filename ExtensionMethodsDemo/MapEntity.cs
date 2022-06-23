using Newtonsoft.Json;

namespace ExtensionMethodsDemo;

public class MapEntity
{
    public int X;
    public int Y;
    public string? EntityName;

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}



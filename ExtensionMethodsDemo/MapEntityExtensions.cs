
namespace ExtensionMethodsDemo;

public static class MapEntityExtensions
{
    public static void MoveDegree(this MapEntity mapEntity, int degree)
    {
        mapEntity.X += degree;
        mapEntity.Y += degree; 
    }

}

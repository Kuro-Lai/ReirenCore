namespace Reiren.Core.Enums
{
    [System.Flags]
    public enum Facing2D
    {
        Nothing = 0,
        North = 1,
        West = 2,
        South = 4,
        East = 8,
        Everything = 0b1111
    }
}


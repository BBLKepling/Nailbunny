using RimWorld;
using Verse;

[DefOf]
public static class InternalDefOf
{
    public static ThingDef BBLK_Nailbunny;

    static InternalDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(InternalDefOf));
    }
}

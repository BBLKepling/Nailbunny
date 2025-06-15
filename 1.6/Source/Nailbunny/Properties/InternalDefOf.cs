using RimWorld;
using Verse;

namespace Nailbunny
{
    [DefOf]
    public static class InternalDefOf
    {
        static InternalDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(InternalDefOf));
        }

        public static ThingDef BBLK_Nailbunny;
    }
}

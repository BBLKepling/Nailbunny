using RimWorld;
using System.Collections.Generic;
using Verse;

namespace Nailbunny
{
    public class ThoughtWorker_Nailbunny_Soothe : ThoughtWorker
    {
        private const float Radius = 5f;

        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            if (!p.Spawned)
            {
                return false;
            }
            List<Thing> list = p.Map.listerThings.ThingsOfDef(InternalDefOf.BBLK_Nailbunny);
            for (int i = 0; i < list.Count; i++)
            {
                if (p.Position.InHorDistOf(list[i].Position, Radius))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

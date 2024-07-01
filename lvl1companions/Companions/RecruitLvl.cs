using BlueprintCore.Blueprints.Configurators;
using BlueprintCore.Blueprints.Configurators.Facts;
using BlueprintCore.Blueprints.References;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvl1companions.Companions
{
    internal class RecruitLvl
    {
        public static void Configure()
        {
            BlueprintCore.Utils.Blueprint<BlueprintReference<BlueprintUnit>>[] companionlist = { UnitRefs.Ember_Companion, UnitRefs.SosielVaenic_Companion, UnitRefs.Arueshalae_Companion,
                UnitRefs.Arueshalae_Companion_thirdchapter, UnitRefs.EvilArueshalae_Companion, UnitRefs.DLC1_Arueshalae_Companion, UnitRefs.DLC1_EvilArueshalae_Companion, 
                UnitRefs.DLC1_SosielVaenic_Companion, UnitRefs.DLC1_Ember_Companion, UnitRefs.Ulbrig_Companion, UnitRefs.DLC1_Ulbrig_Companion, UnitRefs.Woljif_Companion,
                UnitRefs.DLC1_Woljif_Companion, UnitRefs.Daeran_Companion, UnitRefs.DLC1_Daeran_Companion, UnitRefs.Regill_Companion, UnitRefs.DLC1_Regill_Companion,
                UnitRefs.Nenio_Companion, UnitRefs.DLC1_Nenio_Companion, UnitRefs.Staunton_Companion, UnitRefs.DLC1_Staunton_Companion, UnitRefs.Ciar_Companion, UnitRefs.DLC1_Ciar_Companion,
                UnitRefs.Delamere_Companion, UnitRefs.DLC1_Delamere_Companion, UnitRefs.Kestoglyr_Companion, UnitRefs.DLC1_Kestoglyr_Companion, UnitRefs.Galfrey_Companion,
                UnitRefs.DLC1_Galfrey_Companion, UnitRefs.DLC1_LichGalfrey_Companion, UnitRefs.LichGalfrey_Companion, UnitRefs.DLC5_Rekarth_companion, UnitRefs.Sendri_companion,
                UnitRefs.DLC5_Sendri_companion, UnitRefs.Penta_companion, UnitRefs.Greybor_Companion, UnitRefs.DLC1_Greybor_Companion};
            foreach (var i in companionlist)
            {
                UnitConfigurator.For(i.Reference.Get())
                    .EditComponent<ClassLevelLimit>(c => c.LevelLimit=1)
                    .Configure();
            }
        }
    }
}

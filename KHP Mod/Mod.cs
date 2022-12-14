using DuckGame;

namespace DuckGame.KerflufflesHatPack
{
    public class KerflufflesHatPack : Mod
    {
      protected override void OnPostInitialize()
      {
        Teams.core.teams.Add(new Team("Boxer", Mod.GetPath<KerflufflesHatPack>("box"), false, false, new Vec2()));
        Teams.core.teams.Add(new Team("BUZZ BUZZ", Mod.GetPath<KerflufflesHatPack>("buzzbuzz"), false, false, new Vec2()));
        Teams.core.teams.Add(new Team("Cyborg", Mod.GetPath<KerflufflesHatPack>("cyborg"), false, false, new Vec2()));
        Teams.core.teams.Add(new Team("Facts", Mod.GetPath<KerflufflesHatPack>("facts"), false, false, new Vec2()));
        Teams.core.teams.Add(new Team("Gary", Mod.GetPath<KerflufflesHatPack>("gary"), false, false, new Vec2()));
        Teams.core.teams.Add(new Team("HIM", Mod.GetPath<KerflufflesHatPack>("him"), false, false, new Vec2()));
        Teams.core.teams.Add(new Team("QUAK", Mod.GetPath<KerflufflesHatPack>("quak"), false, false, new Vec2()));
        Teams.core.teams.Add(new Team("Rem Lezar", Mod.GetPath<KerflufflesHatPack>("rem"), false, false, new Vec2()));
        Teams.core.teams.Add(new Team("UMU", Mod.GetPath<KerflufflesHatPack>("umu"), false, false, new Vec2()));

        base.OnPostInitialize();
      }
    }
  }

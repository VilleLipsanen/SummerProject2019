using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHero : BaseClass
{

    public CharacterStat Str;

    public CharacterStat Dex;

    public CharacterStat Agi;

    public CharacterStat Vit;

    public CharacterStat Int;

    public void SetAtk()
    {
        Atk.RemoveAllModifiersFromSource(this.gameObject);
        StatModifier sm = new StatModifier((Str.Value * 0.107f) + (Dex.Value * 0.025f), StatModType.PercentAdd, this.gameObject);
        Atk.AddModifier(sm);
    }

    public void SetCrit()
    {
        Crit.RemoveAllModifiersFromSource(this.gameObject);
        StatModifier sm = new StatModifier((Dex.Value), StatModType.Flat, this.gameObject);
        Crit.AddModifier(sm);
    }

    public void SetSpeed()
    {
        Speed.RemoveAllModifiersFromSource(this.gameObject);
        StatModifier sm = new StatModifier(Agi.Value * 1.05f, StatModType.Flat, this.gameObject);
        Speed.AddModifier(sm);
    }

    public void SetHP()
    {
        MaxHP.RemoveAllModifiersFromSource(this.gameObject);
        StatModifier sm = new StatModifier(Vit.Value * 10, StatModType.Flat, this.gameObject);
        MaxHP.AddModifier(sm);
    }

    public void SetMana()
    {
        MaxMana.RemoveAllModifiersFromSource(this.gameObject);
        StatModifier sm = new StatModifier(Int.Value * 10, StatModType.Flat, this.gameObject);
        MaxMana.AddModifier(sm);
    }

}

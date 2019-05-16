using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour
{

    public CharacterStat MaxHP;
    public CharacterStat curHP;

    public CharacterStat MaxStamina;
    public CharacterStat CurStamina;

    public CharacterStat MaxMana;
    public CharacterStat CurMana;

    public CharacterStat Atk;

    public CharacterStat Def;

    public CharacterStat Crit;

    public CharacterStat Speed;

    public int Level;
    public int Exp;

    List<BaseAttack> attacks;
    List<BaseMagic> magics;

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour
{

    public CharacterStat HP;

    public CharacterStat Stamina;

    public CharacterStat Mana;

    public CharacterStat Atk;

    public CharacterStat Def;

    public CharacterStat Crit;

    public CharacterStat Speed;

    public int Level;
    public int Exp;

    List<BaseAttack> attacks;
    List<BaseMagic> magics;

}

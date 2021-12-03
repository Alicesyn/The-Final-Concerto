using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using UnityEngine;

public class ManaBoostPack : PickableItem
{
    public int ManaToGive;
    public Mana mana;
    public ManaBar manaBar;

    /// <summary>
    /// What happens when the object gets picked
    /// </summary>
    protected override void Pick()
    {
        if (mana != null) {
            mana.Increment(ManaToGive);
            if (manaBar != null) {
                manaBar.SetMana(mana.CurrentMana);
            }
        }
    }
}

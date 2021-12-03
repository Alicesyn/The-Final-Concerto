using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mana : MonoBehaviour {
    public int InitialMana = 10;
    public int CurrentMana = -1;
    public int MaximumMana = 10;
    
    // Start is called before the first frame update
    void Start() {
        if (CurrentMana == -1) {
            SetMana(InitialMana);
        }
    }

    public void SetMana(int amount) {
        CurrentMana = amount;
    }

    public void Decrement(int amount) {
        CurrentMana -= amount;
        if (CurrentMana < 0) {
            CurrentMana = 0;
        }
    }

    public void Increment(int amount) {
        CurrentMana += amount;
        if (CurrentMana > MaximumMana) {
            CurrentMana = MaximumMana;
        }
    }
}

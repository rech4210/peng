using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public struct Golds
{
    public int bingneral;
    public int energy;
    public int emperorCoin;
    public Golds(int bingneral, int energy, int emperorCoin)
    {
        this.bingneral = bingneral;
        this.energy = energy;
        this.emperorCoin = emperorCoin;
    }
};

public class GameManager : MonoBehaviour
{
    Golds golds;
    public static GameManager instance;
    public int bingneral {  get {return golds.bingneral ; } set { golds.bingneral += value; } }
    public int energy { get { return golds.energy; } set { golds.energy += value; } }
    public int emperorCoin { get { return golds.emperorCoin; } set { golds.emperorCoin += value; } }

    void Start()
    {
        instance = this;
        golds = new Golds(0, 0, 0);
    }
}

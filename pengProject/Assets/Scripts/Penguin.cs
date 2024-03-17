using UnityEngine;

public enum PenguinState
{
    Pacing,
    Working,
    Sleeping,
    Resting,
    Eating
};

public class Penguin : MonoBehaviour
{
    int speed;
    int bingneralCount = 5;
    int consumeEnergyPoint = -1;

    bool isMove = true;

    Vector3 targetPos;

    private void Update()
    {
        //Pacing();
        Working();
    }
    
    void Do()
    {
        // 해당 부분이 각 아래 행동들을 교체하면서 하도록 제어
    }

    void Pacing()
    {
        if(isMove)
        {
            Vector3 targetPos = new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), 0f);
            transform.Translate(targetPos);
        }
    }
    void Working()
    {
        if(GameManager.instance.energy > 0f)
        {
            //do animation
            GameManager.instance.bingneral = bingneralCount;
            GameManager.instance.energy = consumeEnergyPoint;
        }
        else
        {
            // need more energy
        }
    }
    void DozeOff()
    {
        //do animation
        //when in mine... wake up
    }
    void Resting(int bingneral,int energyPoint)
    {
        //do sleep animation
        // get energy
        GameManager.instance.bingneral -= bingneral;
        GameManager.instance.energy += energyPoint;
    }
    void Eating(int bingneral, int energyPoint)
    {
        GameManager.instance.bingneral -= bingneral;
        GameManager.instance.energy += energyPoint;
    }
}

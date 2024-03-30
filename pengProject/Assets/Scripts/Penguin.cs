using UnityEngine;
using KMS.Enum;
using KMS.Singleton;
using KMS.Struct;


namespace KMS.Penguin
{
    public class Penguin : MonoBehaviour
    {
        PenguinState state;

        // 이 부분은 스크립터블 오브젝트로 관리하는게 맞을듯?
        private Resource penguinResource = new();
        public Resource PenguinResource { get { return penguinResource = GameManager.instance.GetPenguinResource(); }}

        float speed = 1f;
        int bingneralCount = 5;
        int consumeEnergyPoint = -1;

        bool isMove = true;

        Vector3 targetPos;

        private void Update()
        {
        }

        private void FixedUpdate()
        {
            PenguinState(state);
        }

        public void PenguinState(PenguinState penguinState)
        {
            switch (penguinState)
            {
                case Enum.PenguinState.Pacing:
                    Pacing();
                    break;
                case Enum.PenguinState.Working:
                    Working();
                    break;
                case Enum.PenguinState.DozeOff:
                    DozeOff();
                    break;
                case Enum.PenguinState.Resting:
                    Resting();
                    break;
                case Enum.PenguinState.Eating:
                    Eating();
                    break;
            }
        }

        void Pacing()
        {
            if (isMove)
            {
                Vector3 targetPos = new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), 0f);
                transform.Translate(targetPos);
            }
        }
        void Working()
        {
            //if(GameManager.instance.energy > 0f)
            //{
            //do animation
            GameManager.instance.bingneral = bingneralCount;
            GameManager.instance.energy = consumeEnergyPoint;
            //}
            //else
            //{
            //    // need more energy
            //}
        }
        void DozeOff()
        {
            //do animation
            //when in mine... wake up
        }


        // 펭귄이 아닌 전체 로직으로
        //GameManager.instance.bingneral -= bingneral;
        //GameManager.instance.energy += energyPoint;
        void Resting()
        {
            // do sleep animation
            // get energy
        }
        void Eating()
        {
            // do sleep animation
            // get bingneral
        }
    }

}


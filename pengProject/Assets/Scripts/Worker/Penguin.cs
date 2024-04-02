using UnityEngine;
using KMS.Enum;
using KMS.Singleton;
using System.Collections;

namespace KMS.Worker
{
    public class Penguin : Workers
    {
        // 이 부분은 스크립터블 오브젝트로 관리하는게 맞을듯?

        //float speed = 1f;
        int bingneralCount = 5;
        //int consumeEnergyPoint = -1;

        bool isMove = true;
        Vector3 targetPos;


        #region 펭귄 애니메이션 =====================
        public Animator animator;
        PenguinState currentState;
        PenguinState laterState;

        public void ChangePenguinState(PenguinState state)
        {
            switch (state)
            {
                case Enum.PenguinState.Pacing:
                    currentState = Enum.PenguinState.Pacing;
                    break;
                case Enum.PenguinState.Working:
                    currentState = Enum.PenguinState.Working;
                    break;
                case Enum.PenguinState.DozeOff:
                    currentState = Enum.PenguinState.DozeOff;
                    break;
                case Enum.PenguinState.Resting:
                    currentState = Enum.PenguinState.Resting;
                    break;
                case Enum.PenguinState.Eating:
                    currentState = Enum.PenguinState.Eating;
                    break;
            }
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

        #endregion

        private void FixedUpdate()
        {
            if (currentState == laterState)
            {
                return;
            }
            PenguinState(currentState);
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
            animator.SetBool("working", true);

            // 이부분 함수 제어 어떻게 할것인지
            StartCoroutine(WorkingCorutine(workerSpec.miningDuration));
        }

        IEnumerator WorkingCorutine(float waitTime)
        {
            GameManager.instance.SetPenguinResource(bingneralCount,0);
            //GameManager.instance.Energy += consumeEnergyPoint;
            yield return new WaitForSeconds(waitTime);
        }
        void DozeOff()
        {
            animator.SetBool("dozeoff", true);
            //do animation
            //when in mine... wake up
        }

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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BNG{
    public class BuildSystem : MonoBehaviour
    {
        private int buildPossibleInt;
        public bool buildPossibleBool = true;
        private bool firedBool = false;
        Rigidbody buildRigidBody;
        Grabbable buildGrabbable;

        void Start()
        {
            buildRigidBody = GetComponent<Rigidbody>();
            buildGrabbable = GetComponent<Grabbable>();
        }

        // 건축이 가능한 상태를 만들어주는 함수
        public void CanBuild()
        {
            if(buildPossibleBool == false)
            {
                buildPossibleBool = true;
            }
        }

        // 건축이 불가능한 상태를 만들어주는 함수
        public void CantBuild()
        {
            if(buildPossibleBool == true)
            {
                buildPossibleBool = false;
            }
        }

        // 해머로 보내줄 현재 건축이 가능한 상태인지를 확인하는 변수를 리턴하는 함수
        public (bool, int) NowBuildPossible()
        {
            return (buildPossibleBool, buildPossibleInt);
        }

        // 불에 타면 건축 불가능
        public void FiredBuild()
        {
            firedBool = true;
        }

        void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.tag == "SurviveItem" || other.gameObject.tag == "Floor" || other.gameObject.tag == "Build")
            {
                buildPossibleInt += 1;
            }
        }

        void OnCollisionExit(Collision other)
        {
            if(other.gameObject.tag == "SurviveItem" || other.gameObject.tag == "Floor" || other.gameObject.tag == "Build")
            {
                buildPossibleInt -= 1;

                // 공중에 건축이 되어진 상태로 남겨지는걸 방지하기위한 코드
                // 건축화 해제시 공중에 떠있는 오브젝트가 없도록 방지
                if(buildPossibleInt <= 0 && firedBool == false)
                {
                    buildRigidBody.constraints = RigidbodyConstraints.None;
                    buildGrabbable.enabled = true;
                }
            }
        }
    }
}

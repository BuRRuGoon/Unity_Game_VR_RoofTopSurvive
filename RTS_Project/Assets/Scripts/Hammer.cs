using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BNG{
    public class Hammer : MonoBehaviour
    {
        private Rigidbody otherRigidbody;
        private Grabbable grabbable;
        private BuildSystem buildSystem;

        // 건축 가능한 오브젝트 상태 확인 변수
        private int buildInt;
        private bool buildBool;

        // 현재 건축모드인지 해체모드인지 확인 변수
        private bool buildMode = true;
        
        public void BuildModeRelease()
        {
            buildMode = false;
        }

        public void BuildModeBuilding()
        {
            buildMode = true;
        }

        void OnCollisionEnter(Collision other)
        {
            // 건축 모드
            if(buildMode == true)
            {
                // 건축 가능한 아이템 분류
                if(other.gameObject.tag == "SurviveItem" || other.gameObject.tag == "Build")
                {
                    buildSystem = other.gameObject.GetComponent<BuildSystem>();
                    if(buildSystem != null){
                        (buildBool, buildInt) = buildSystem.NowBuildPossible();
                        if(buildInt >= 1 && buildBool == true) {
                            otherRigidbody = other.gameObject.GetComponent<Rigidbody>();
                            grabbable = other.gameObject.GetComponent<Grabbable>();
                            otherRigidbody.constraints = RigidbodyConstraints.FreezeAll;
                            if(grabbable.enabled == true)
                            {
                                grabbable.enabled = false;
                            }
                        }
                    }
                    
                }
            }
            else // 해체 모드
            {
                if(other.gameObject.tag == "SurviveItem" || other.gameObject.tag == "Build")
                {
                    otherRigidbody = other.gameObject.GetComponent<Rigidbody>();
                    grabbable = other.gameObject.GetComponent<Grabbable>();
                    otherRigidbody.constraints = RigidbodyConstraints.None;
                    if(grabbable.enabled == false)
                    {
                            grabbable.enabled = true;
                    }
                }
            }
        }
    }
}

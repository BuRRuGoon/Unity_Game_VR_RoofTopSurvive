using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StylizedWater2
{
    public class ItemWaveMove : MonoBehaviour
    {
        public float speed;
        Vector3 destination;
        private ItemWaveMove itemWaveMove;

        public bool grabBool = false;
        private bool objectOnWaterBool = false;
        private bool crashWaveDestroyBool = false;
        private int crashOtherObjectInt = 0;
        private int endPoint = -520;
       
        private FloatingTransform floatingTransform;
        private Rigidbody surviveRigidbody;

        void Start() {
            itemWaveMove = gameObject.GetComponent<ItemWaveMove>();
            floatingTransform = gameObject.GetComponent<FloatingTransform>();
            surviveRigidbody = gameObject.GetComponent<Rigidbody>();
            
        }

        void Update()
        {   
            OnMoveWater();
        }

        void OnMoveWater()
        {
            // 오브젝트가 파도에 있을 경우 움직이게
            if(objectOnWaterBool == true && crashOtherObjectInt == 0 && crashWaveDestroyBool == false)
            {
                //물건이 회전하면 Vector방향에 상관없이 EndPoint를 향해서 이동
                destination = new Vector3(transform.position.x, transform.position.y, endPoint);
                transform.position = Vector3.MoveTowards(transform.position, destination, speed);
            }
        }

        public void IsGrab()
        {
            grabBool = true;
            floatingTransform.enabled = false;
            surviveRigidbody.isKinematic = false;
            crashWaveDestroyBool = false;
        }

        public void ReleaseGrab()
        {
            grabBool = false;
        }

        void OnTriggerEnter(Collider other)
        {   
            // 웨이브에 맞닿았을때
            if(other.gameObject.CompareTag("Wave") && grabBool == false)
            {
                objectOnWaterBool = true;
                floatingTransform.enabled = true;
                surviveRigidbody.isKinematic = true;
            }

            if(other.gameObject.CompareTag("SurviveItem"))
            {
                crashOtherObjectInt += 1;
            }

            // 물건이 맞닿아있거나 건물 벽에 맞닿아 있는 경우 
            if(other.gameObject.CompareTag("WaveDestroy"))
            {
                crashWaveDestroyBool = true;
            }
        }

        void OnTriggerStay(Collider other)
        {
            if(other.gameObject.CompareTag("WaveDestroy"))
            {
                crashWaveDestroyBool = true;
            }
        }

        void OnTriggerExit(Collider other)
        {
            // 파도에서 벗어났을때 움직이지 않도록 설정
            if(other.gameObject.CompareTag("Wave"))
            {
                objectOnWaterBool = false;
            }

            if(other.gameObject.CompareTag("SurviveItem"))
            {
                crashOtherObjectInt -= 1;
            }
        }
    }
}

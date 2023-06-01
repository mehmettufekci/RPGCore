using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class Zoom : MonoBehaviour
    {
        [SerializeField] CinemachineVirtualCamera followCamera;

        void Update()
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            {
                followCamera.GetCinemachineComponent<CinemachineFramingTransposer>().m_CameraDistance -= Input.GetAxis("Mouse ScrollWheel") * 2;
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                followCamera.GetCinemachineComponent<CinemachineFramingTransposer>().m_CameraDistance -= Input.GetAxis("Mouse ScrollWheel") * 2;
            }
        }
    }
}

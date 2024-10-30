using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class GhostCamera : MonoBehaviour
{
    float counter = 0;
    public float fps = 0;
    private RenderTexture renderTexture;
    private Camera cam;
    public LayerMask layerMask;
    void Start()
    {
        renderTexture = new RenderTexture(Screen.width/2, Screen.height/2, 32);
        Shader.SetGlobalTexture("_GhostTexture", renderTexture);
        cam = GetComponent<Camera>();
    }


    void Update()
    {
            counter += Time.deltaTime;
        if (counter > 1f/fps)
        {
            int prevMask = cam.cullingMask;
            RenderTexture prevTarget = cam.targetTexture;

            cam.cullingMask = layerMask.value;
            cam.targetTexture = renderTexture;
            cam.Render();

            cam.cullingMask = prevMask;
            cam.targetTexture = prevTarget;
            counter = 0;
           }
        }
    }

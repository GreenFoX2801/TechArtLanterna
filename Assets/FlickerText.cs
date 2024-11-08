using System.Collections;
using UnityEngine;

public class FlickerText : MonoBehaviour
{
    public GameObject GameObject;
    public float time;
    void Start()
    {
        StartCoroutine(Tempo());
    }
    IEnumerator Tempo()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            GameObject.SetActive(!GameObject.activeSelf); 
        }
    }
}

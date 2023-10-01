using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class SpaceSheep2d : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"); 
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _0218 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        go.name = "0218";go.tag = "0218";
        //GameObject.Destroy(gameObject, 5);
        GameObject.DontDestroyOnLoad(gameObject);

        Debug.Log(GameObject.FindWithTag("0218").name);

        GameObject.Instantiate(go, go.transform);

        Invoke("test",5);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void test()
    { SceneManager.LoadScene(0); }
}

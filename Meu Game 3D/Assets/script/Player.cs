using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;
public class Player : MonoBehaviour
{
 public int velocidade = 10;
 public int forcaPulo = 7;
 private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message:"START");
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message:"UPDATE");
        float h = Input.GetAxis("Horizontal"); 
        float v = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime,ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
        }
        
        
        
        if (transform.position.y <= -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscenescript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))   //kanske göra så att spelaren kan spawna in andra sidan av maze om går åt vänster sida?
        {
            SceneManager.LoadScene(1);
        }
    }
}

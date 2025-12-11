using UnityEngine;
using UnityEngine.SceneManagement;

public class collectscript : MonoBehaviour
{
    public GameObject scoremanager; 
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
        if (collision.gameObject.CompareTag("Player"))
        {
            scoremanager.GetComponent<ScoreManager>().UpdateScore(1);
            Destroy(gameObject); 
        }
    }
}

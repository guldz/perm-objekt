using UnityEngine;

public class spawn : MonoBehaviour 
{
    public GameObject Player; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        Player.transform.position = transform.position;
    }
}

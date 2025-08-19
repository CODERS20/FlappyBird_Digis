using UnityEngine;

public class PointDetector : MonoBehaviour
{

    public Points logic;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Points>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.IncrementScore();
    }
}

using UnityEngine;

public class PipesMove : MonoBehaviour
{
    public float pipeSpeed = 3.8f;
    private float screenEnd;

    private void Start()
    {
        screenEnd = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 2f;
    }
    private void Update()
    {
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;

        if(transform.position.x <= screenEnd)
        {
            Destroy(gameObject);
        }
    }
}


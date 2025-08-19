using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject preFab;
    public float pipeSpawner = 1f;
    public float depth = -2f;
    public float height = 2f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), pipeSpawner,pipeSpawner);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(preFab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(depth, height);
    }
}

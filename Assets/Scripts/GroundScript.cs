using UnityEngine;

public class GroundScript : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float grSpeed = 1f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(grSpeed * Time.deltaTime, 0);
    }
}

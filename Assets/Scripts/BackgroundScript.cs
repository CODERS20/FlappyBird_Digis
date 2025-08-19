using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float bgSpeed = 0.4f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0);
    }
}

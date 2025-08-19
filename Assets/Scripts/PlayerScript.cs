using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class PlayerScript : MonoBehaviour
{
    private Vector3 direction;

    private SpriteRenderer spriteRenderer;

    public Sprite[] sprites;
    private int spIndex;

    public float gravity = -8f;
    public float birdStrength = 3f;

    public Points logic;

    private void Awake()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Points>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    private void Start()
    {

        
        InvokeRepeating(nameof(spriteAnimation), 0.3f, 0.3f);

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * birdStrength;
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    private void spriteAnimation()
    {
        spIndex++;

            if (spIndex >= sprites.Length){
            spIndex = 0;
        }

        spriteRenderer.sprite = sprites[spIndex];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
    }


}

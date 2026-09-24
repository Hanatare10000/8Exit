using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    public float speed = 5f;
    public Sprite[] walk;
    public Sprite[] idle;
    public float animationSpeed = 0.1f;
    SpriteRenderer spriteRenderer;
    private float timer;
    private int frameIndex;
    private bool isMoving;
    private bool wasMoving;

    void Start()
    {
        Application.targetFrameRate = 60;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        UpdateAnimation();

    }
    void MovePlayer()
    {
        isMoving = false;
        if (Keyboard.current.aKey.isPressed)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            spriteRenderer.flipX = true;
            isMoving = true;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            spriteRenderer.flipX = false;
            isMoving = true;
        }
    }
    void UpdateAnimation()
    {
        if (isMoving != wasMoving)
        {
            frameIndex = 0;
            timer = 0;
            wasMoving = isMoving;
            if (isMoving && walk.Length > 0)
                spriteRenderer.sprite = walk[0];
            else if (idle.Length > 0)
                spriteRenderer.sprite = idle[0];
        }
        timer += Time.deltaTime;

        if (timer < animationSpeed)
            return;
        timer = 0;
        Sprite[] currentSpretes = isMoving ? walk : idle;

        if (currentSpretes.Length == 0)
            return;
        frameIndex++;

        if (frameIndex >= currentSpretes.Length)
            frameIndex = 0;

        spriteRenderer.sprite = currentSpretes[frameIndex];
    }
}

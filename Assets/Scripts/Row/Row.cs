using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{
    public const float ROW_HEIGHT = 0.48f;
    public const int PIECE_COUNT_PER_ROW = 13;
    public const float PIECE_LENGTH = 0.93f;
    public const int TOTAL_ROWS = 10;

    public GameObject brickPrefab;

    [SerializeField]
    private Sprite blueColor;
    [SerializeField]
    private Sprite redColor;
    [SerializeField]
    private Sprite greenColor;
    [SerializeField]
    private Sprite purpleColor;
    [SerializeField]
    private Sprite goldColor;
    [SerializeField]
    private Sprite greyColor;
    [SerializeField]
    private Sprite brownColor;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    float colorPicker;

    void Start()
    {
        ResetLevel();
    }

    public void ResetLevel()
    {
        for (int x = 0; x < PIECE_COUNT_PER_ROW; x++)
        {
            Debug.Log(x);
            for (int y = 0; y < TOTAL_ROWS; y++)
            {
                Vector2 spawnPos = (Vector2)transform.position + new Vector2(x * (PIECE_LENGTH) - 3.25f, -y * (ROW_HEIGHT) + 3.75f);
                GameObject brick = Instantiate(brickPrefab, spawnPos, Quaternion.identity);

                colorPicker = Random.Range(0.0f, 6.9f);
                if (colorPicker >= 0.0f && colorPicker <= 0.9f)
                {
                    spriteRenderer.sprite = blueColor;
                }
                else if (colorPicker >= 1.0f && colorPicker <= 1.9f)
                {
                    spriteRenderer.sprite = redColor;
                }
                else if (colorPicker >= 2.0f && colorPicker <= 2.9f)
                {
                    spriteRenderer.sprite = greenColor;
                }
                else if (colorPicker >= 3.0f && colorPicker <= 3.9f)
                {
                    spriteRenderer.sprite = purpleColor;
                }
                else if (colorPicker >= 4.0f && colorPicker <= 4.9f)
                {
                    spriteRenderer.sprite = goldColor;
                }
                else if (colorPicker >= 5.0f && colorPicker <= 5.9f)
                {
                    spriteRenderer.sprite = greyColor;
                }
                else if (colorPicker >= 6.0f && colorPicker <= 6.9f)
                {
                    spriteRenderer.sprite = brownColor;
                }

            }
        }
    }
}
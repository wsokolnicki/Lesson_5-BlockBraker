using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] Ball ball;
    bool cheat = false;

    void Update()
    {
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(IsCheatOn(), minX, maxX);
        transform.position = paddlePos;
        CheatOnOff();
    }

    private void CheatOnOff()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            cheat = true;
        }
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            cheat = false;
        }
    }

    private float IsCheatOn()
    {
        if(!cheat)
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }
        else
        {
            return ball.transform.position.x;
        }
    }
}

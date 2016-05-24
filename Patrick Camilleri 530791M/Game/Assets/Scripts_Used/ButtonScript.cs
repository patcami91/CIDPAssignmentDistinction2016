using UnityEngine;
using System.Collections;

public enum Direction
{
    Up, Down, Left, Right
}

public class ButtonScript : MonoBehaviour {

	public void ButtonPressed (int dirNum)
    {
        Direction dir = (Direction)dirNum;
        PlayerController pc = GameObject.FindObjectOfType<PlayerController>();

        switch (dir)
        {
            case Direction.Up:
                pc.vertical = -1f;
                break;

            case Direction.Down:
                pc.vertical = 1f;
                break;

            case Direction.Left:
                pc.horizontal = -1f;
                break;

            case Direction.Right:
                pc.horizontal = 1f;
                break;
        }
    }

    public void ButtonRelease(int dirNum)
    {
        Direction dir = (Direction)dirNum;
        PlayerController pc = GameObject.FindObjectOfType<PlayerController>();

        switch (dir)
        {
            case Direction.Up:
            case Direction.Down:
                pc.vertical = 0f;
                break;

            case Direction.Left:
            case Direction.Right:
                pc.horizontal = 0f;
                break;
        }
    }
}

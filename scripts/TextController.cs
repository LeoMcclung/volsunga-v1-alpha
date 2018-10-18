using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {start, move, look, sprint, jump, draw, map, end};
    private States myState;

    void Start()
    {
        myState = States.start;
    }

    void Update()
    {
       if(myState == States.start)
        {
            Start_text();
        }
        else if (myState == States.move)
        {
            Move_text();
        } else if (myState == States.look)
        {
            Look_text();
        } else if (myState == States.sprint)
        {
            Sprint_text();
        } else if (myState == States.jump)
        {
            Jump_text();
        } else if (myState == States.draw)
        {
            Draw_text();
        } else if (myState == States.map)
        {
            Map_text();
        }
        else if (myState == States.end)
        {
            End_text();
        }
    }

    void Start_text()
    {
        text.text = "Welcome to the Völsung tutorial Press the C Key to continue through the instructions";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.move;
        }
    }

    void Move_text()
    {
        text.text = "Move your character with the W A S and D Keys";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.look;
        }
    }

    void Look_text()
    {
        text.text = "Look around by moving your mouse";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.sprint;
        }
    }

    void Sprint_text()
    {
        text.text = "Hold down the Shift key to sprint";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.jump;
        }
    }

    void Jump_text()
    {
        text.text = "Press the Spacebar to jump";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.draw;
        }
    }

    void Draw_text()
    {
        text.text = "Press the E key to draw your weapons";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.map;
        }
    }

    void Map_text()
    {
        text.text = "Press the M key to open and close your map";
        if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.end;
        }
    }

    void End_text()
    {
        text.text = "Press R to reshow the controls";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.move;
        }
    }

}

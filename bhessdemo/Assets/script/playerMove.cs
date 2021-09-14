using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : baseMove
{

    public gameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        init();
       
    }

    void Update()
    {
       
        if (selected&&moveable)
        {
           
            moveNode();
          
        }
       
     
    }
    private void moveNode()
    {
        if (!moving)
        {
            
            findSelectable();
            clickMouse();
        }
        else
        {
            move();


    }
}

    private void clickMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tile t = null;
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            
            if (hit.collider.tag == "tile")
            {
                
                t = hit.collider.GetComponent<tile>();
                
                if (t.selectable)
                {
                  
                    moveTo(t);
                }
            }
            else
            {
              //  gm.reset();
            }

        }else if (Input.GetMouseButtonDown(1)&&!moving)
        {
            removeSelectedTile();

            moving = false;
            selected = false;
            moveable = false;
        }

    }
   
    

       }



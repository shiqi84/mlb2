using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour

{
    public GameObject moveBoard;
    gameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("gameManager").GetComponent<gameManager>();
        closeMoveBoard();
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public   void showMoveBoard(Vector2 pos)
    {
                moveBoard.SetActive(true);
            moveBoard.transform.position = pos;
    }


    public void closeMoveBoard()
    {
            moveBoard.SetActive(false);
       
    }
    public void moveButtonOnClick()
    {
       
        closeMoveBoard();
        gameManager.currentNode.moveable = true;
        gameManager.currentNode.selected = true;
       

    }
    public void actionButtonOnClick()
    {
        closeMoveBoard();
       
        gameManager.currentNode.GetComponent<characterStats>().TakeDamage(10);


    }
    public void Reset()
    {
        closeMoveBoard();

    }
}

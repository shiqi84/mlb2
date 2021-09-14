using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class gameManager : MonoBehaviour
{
    GameObject[] playerCharacters;
    public playerMove currentNode;
    UIManager ui;
    public static gameManager instance;
    // Start is called before the first frame update
    public GameObject[] tiles;
    void Start()
    {
        playerCharacters = GameObject.FindGameObjectsWithTag("player");
        ui=GameObject.Find("gameManager").GetComponent<UIManager>();
        instance = this;
        tiles = GameObject.FindGameObjectsWithTag("tile");
    }

    // Update is called once per frame
    void Update()
    {
        clickMouse();

    }

    private void clickMouse()
    {
        if (Input.GetMouseButtonUp(0))
        {
            tile t = null;
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider.tag == "Player")
            {
                currentNode = hit.collider.GetComponent<playerMove>();
                ui.showMoveBoard(new Vector2(currentNode.transform.position.x+3, currentNode.transform.position.y));
                
            }


        }
         else if (Input.GetMouseButtonUp(1) && !currentNode.moving)
        {
            Reset();
        }

    }
    public void useItem(item item)
    {
        characterStats stats= currentNode.GetComponent<characterStats>();
        
    }

    public void Reset()
    {
        currentNode.selected = false;
        currentNode.moveable = false;
        currentNode = null;
        ui.Reset();
    }
}

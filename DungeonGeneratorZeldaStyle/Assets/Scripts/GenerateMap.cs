using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour
{

    [SerializeField] private int width = 5;
    [SerializeField] private int height = 5;
    [SerializeField] GameObject Room;
    [SerializeField] private int totalRooms = 1;
    private GameObject[,] grid;
    private List<Vector2> rooms;


    // Start is called before the first frame update
    void Start()
    {

        // int[,] gridArray = new int[5, 5];
        grid = new GameObject[width, height];
        rooms = new List<Vector2>();
        grid[2, 2] = Room;
        CheckAround(2,2);
        for (int i = 1; i < totalRooms; i++)
        {

        }
    }

    private void CheckAround(int x, int y)
    {
        
        rooms.Add(new Vector2(x - 1, y));
        rooms.Add(new Vector2(x - 1, y));
        rooms.Add(new Vector2(x - 1, y));
        rooms.Add(new Vector2(x , y+1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

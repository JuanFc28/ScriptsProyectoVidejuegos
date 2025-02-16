using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelGenerator8 : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase groundTile;
    private int[,] levelData = new int[,]
        {
        {0,0,0,0,0},
        {0,0,0,0,0},
        {0,0,0,0,0},
        {1,1,1,1,0},
        {1,1,1,1,0}
        };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateLevel();
    }
    void GenerateLevel()
    {
        int offsetX = 5; // Desplazamiento en X
        int offsetY = -8;  // Desplazamiento en Y

        for (int x = 0; x < levelData.GetLength(0); x++)
        {
            for (int y = 0; y < levelData.GetLength(1); y++)
            {
                if (levelData[x, y] == 1)
                {
                    // Sumar el desplazamiento a las coordenadas
                    tilemap.SetTile(new Vector3Int(x + offsetX, y + offsetY, 0), groundTile);
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}

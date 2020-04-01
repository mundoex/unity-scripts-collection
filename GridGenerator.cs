using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public GameObject tilePrefab;
    public float spacing;
    public int rows;
    public int columns;

    void Start()
    {
        GameObject gridObject = new GameObject("Grid");
        for (int i = 0; i < rows; i++)
        {
            GameObject rowObject = new GameObject("Row-" + i);
            
            for (int j=0; j < columns; j++)
            {
                GameObject tile = Instantiate(tilePrefab, new Vector3(i * spacing, 0, j * spacing), Quaternion.identity);
                tile.name = $"Cell-({i},{j})";
                tile.transform.SetParent(rowObject.transform);
            }
            rowObject.transform.SetParent(gridObject.transform);
        }
    }
}

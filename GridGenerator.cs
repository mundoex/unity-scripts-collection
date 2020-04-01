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
        for (int i = 0; i < columns; i++)
        {
            GameObject rowObject = new GameObject("Row-" + i);

            for (int j = 0; j < rows; j++)
            {
                GameObject tile = Instantiate(tilePrefab, new Vector3(j * spacing, 0, -i * spacing), Quaternion.identity);
                tile.name = $"Cell-({i},{j})";
                tile.transform.SetParent(rowObject.transform);
            }
            rowObject.transform.SetParent(gridObject.transform);
        }
    }
}

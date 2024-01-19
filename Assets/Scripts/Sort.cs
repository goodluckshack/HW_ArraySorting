using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort : MonoBehaviour
{
    public GameObject[] objectsToSort;


    // Start is called before the first frame update
    void Start()
    {

    }



    public void StartBubbleSorting()
    {
        BubbleSort();

        VisualizeSortedArray();
    }

    void BubbleSort()
    {
        int n = objectsToSort.Length;
        bool swapped;

        do
        {
            swapped = false;

            for (int i = 1; i < n; i++)
            {
                Color color1 = objectsToSort[i - 1].GetComponent<Renderer>().material.color;
                Color color2 = objectsToSort[i].GetComponent<Renderer>().material.color;

                if (color1.r > color2.r)
                {
                    GameObject temp = objectsToSort[i - 1];
                    objectsToSort[i - 1] = objectsToSort[i];
                    objectsToSort[i] = temp;

                    swapped = true;
                }
            }

        } while (swapped);
    }


    void VisualizeSortedArray()
    {
        for (int i = 0; i < objectsToSort.Length; i++)
        {
            Vector3 newPosition = new Vector3(i * 2, objectsToSort[i].transform.position.y, objectsToSort[i].transform.position.z);
            objectsToSort[i].transform.position = newPosition;
        }
    }
}

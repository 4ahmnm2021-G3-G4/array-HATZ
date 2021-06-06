using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrays : MonoBehaviour
{
    string[] array1 = new string[4] { "array1", "array2", "array3", "array4" };
    float[] array2 = new float[] { 21f, 22f, 23f, 24f };
    int[] array3 = { 31, 32, 33, 34, 35, 36, 37 };
    GameObject[] array4 = new GameObject[4];

    /* Aufgaben:
    1) Durchlaufen ausgeben der Werte
    2) Länge des Arrays ausgeben als Debug
    3) 2 Werte direkt ändern
    4) GameObjects Images anlegen, Tag vergeben, zuweisen und Farbe ändern.
    */

    // Start is called before the first frame update
    void Start()
    {
        //Array Werte ausgeben
        foreach (string array1 in array1)
        {
            Debug.Log("Array1:" + array1);
        }
        foreach (float array2f in array2)
        {
            Debug.Log("Array2:" + array2f);
        }
        foreach (int array3 in array3)
        {
            Debug.Log("Array3:" + array3);
        }

        //Array Länge ausgeben
        Debug.Log("Array1 Length: " + array1.Length);
        Debug.Log("Array2 Length: " + array2.Length);
        Debug.Log("Array3 Length: " + array3.Length);

        //Array direkt modifizieren
        array1[2] = "arrayGeändert";
        array2[0] = 99f;

        //Array Farbe ändern
        array4 = GameObject.FindGameObjectsWithTag("RedImage");
        array4[2].GetComponent<Image>().color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

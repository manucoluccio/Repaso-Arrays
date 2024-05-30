using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] Vehiculos;
    public int randomizer;

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            randomizer = Random.Range(0, Vehiculos.Length);
            desactivartodo();
            Vehiculos[randomizer].SetActive(true);

        }
    }

    void ResetearVehiculos()
    {
        desactivartodo();
        Vehiculos[0].SetActive(true);
    }

    void desactivartodo()
    {
        for (int i = 0; i < Vehiculos.Length; i++)
        {
            Vehiculos[i].SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private float velocidad = 5;
    private float velocidaGiro = 100;
    private float entradaHorizontal;
    private float entradaFrente;


    Rigidbody rbCientificoBrocoli;
    public float fuerzaSalto;
    public float modificarGravedad;

    

    public bool estaEnTierra = true;


    private void Start()
    {
        rbCientificoBrocoli = GetComponent<Rigidbody>();
        Physics.gravity *= modificarGravedad;

    }
    void Update()

    {
        entradaHorizontal = Input.GetAxis("Horizontal");
        entradaFrente = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * velocidad * entradaFrente);
        transform.Rotate(Vector3.up * Time.deltaTime * velocidaGiro * entradaHorizontal);

        if(Input.GetKeyDown(KeyCode.Space) && estaEnTierra)
        {
            rbCientificoBrocoli.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            estaEnTierra = false;
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        estaEnTierra = true;
    }


}

using UnityEngine;

public class fundamentosPRogramacion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private int myNumber = 12; // int - numero entero 
    public float myFloatNumber = 25.20f;//-numeros con decimales
    public string nyString = "put your message here";//-palabras
    public int health;
    void Start()
    {
        int localHealth = 50; //variables locales
        Debug.Log("Hola, estoy en la funcion start");
        Debug.Log("My bumber is: " + myNumber);
        Debug.Log("message is: " + nyString);
        health = 100;
        int newHealth = health + localHealth;//sumar el valor de una variable local y global
        Debug.Log("health: " + health);
        Debug.Log("newHealth:" + newHealth);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hl2 tiene la mejor intro de la historia");
    }
}

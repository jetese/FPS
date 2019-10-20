using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyGranade : MonoBehaviour
{
    /// <summary>
    /// Delay para la destrucción del objeto
    /// </summary>
    public float m_Delay = 3;
    public GameObject m_Explosion;

    /// <summary>
    /// En el start, simplemente hacemos una llamada a la función que destruye el objeto con un delay determinado 
    /// </summary> 
    void Start()
    {
        // ## TO-DO 1 - Llamada a la función Destroy, pasandole un puntero a mi mismo (gameObject) y un delay ##
        
        Destroy(gameObject, m_Delay);
    }
    public void OnDestroy()
    {
        Instantiate(m_Explosion, transform.position, m_Explosion.transform.rotation);

    }
}

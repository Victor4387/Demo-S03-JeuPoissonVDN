using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JeuPoisson : MonoBehaviour
{
    public float poidsSaumon = 10.5f;
    [SerializeField] private float _poidsSardine = 100f;

    [SerializeReference] private GameObject _sardine;
    [SerializeReference] private GameObject _saumon;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(poidsSaumon);
        //_sardine.transform.position += new Vector3(1f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        temps += Time.deltaTime;
        Debug.Log(temps);
        //Debug.Log(poidsSaumon);
        Vector3 deplacement = new Vector3(1f, 0f, 0f);
        _sardine.transform.position += deplacement * 4f * Time.deltaTime;
    }

    public void Redemarrer()
    {
        SceneManager.LoadScene();
    }

    public void ComparerPoissons()
    {
        if (poidsSaumon > _poidsSardine)
        {
            Debug.Log("Bon appetit!");
            _sardine.SetActive(false);
            //Destroy(_sardine);
        }
        else
        {
            Debug.Log("Non!");
        }
    }

}

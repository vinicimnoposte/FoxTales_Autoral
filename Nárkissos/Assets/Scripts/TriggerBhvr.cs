using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBhvr : MonoBehaviour
{
    public GameObject manequins;
    public GameObject porta;
    public GameObject mago;
    public Animator anim;
    public GameObject trigger;
    public AudioSource slamDoor;




    // Start is called before the first frame update
    void Start()
    {
        manequins.SetActive(false);

      //  porta.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(portaAbre());
        //porta.SetActive(false);
        slamDoor.Play();
        mago.SetActive(false);
    }
    IEnumerator portaAbre()
    {
        anim.SetBool("Fechando", true);
        yield return new WaitForSeconds(1f);
        anim.SetBool("Fechando", false);

        manequins.SetActive(true);
        trigger.SetActive(false);
    }
}

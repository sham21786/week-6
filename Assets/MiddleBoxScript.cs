using UnityEngine;
using System.Collections;

public class MiddleBoxScript : MonoBehaviour {

    public Transform myTarget;

	void Start () 
    {
        StartCoroutine(myThang());
	}

    IEnumerator myThang () 
    {
        for (int i = 0; i < 50; i++)
        {
            transform.Translate(transform.up * Time.deltaTime * 4);
            yield return null;
        }

        yield return new WaitForSeconds(1);

        for (int i = 0; i < 49 ; i++)
        {
            transform.Translate(transform.right * Time.deltaTime * 4);
            yield return null;
        }

        yield return new WaitForSeconds (1);

        for (int i = 0; i < 43; i++)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 4);
            yield return null;
        }
        
        yield return new WaitForSeconds (1);

        myTarget.SendMessage("DoMahThang");
    }
}

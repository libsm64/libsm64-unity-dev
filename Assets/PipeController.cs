using UnityEngine;
using System.Collections;

public class PipeController : MonoBehaviour
{
    public GameObject marioPrefab;
    public GameObject camObj;

    IEnumerator Start()
    {
        while( true )
        {
            yield return new WaitForSeconds(1);
            spawnMario();
        }
    }

    void Update()
    {
        var r = 10;
        var t = Time.time;

        transform.position = new Vector3(
            r * Mathf.Sin( t ),
            transform.position.y,
            r * Mathf.Cos( t )
        );
    }

    void spawnMario()
    {
        var mario = Instantiate( marioPrefab, transform.position, Quaternion.identity );
        mario.GetComponent<ExampleInputProvider>().cameraObject = camObj;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControllerLevel3 : MonoBehaviour
{
    private float time = 0.0f;
    public float interpolationPeriod = 5.0f;
    public Text text;
    // Start is called before the first frame update
    void Awake()
    {
        this.setText("Al fin llegue al almacen, aqui deben estar los suministros que vine a buscar. Es probable que encuentar botiquines de primeros auxilios aqui para usar.");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= interpolationPeriod)
        {
            time = 0;
            this.gameObject.active = false;
        }
    }

    public void setText(string text)
    {
        time = 0;
        gameObject.active = true;
        this.text.text = text;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectorLevel3Script : MonoBehaviour
{
    public int requiered = 1;
    public int count = 0;
    public Text obectives;
    public Text rewards;
    public bool finished = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.obectives.text = "Suministros " + this.count  + "/" + this.requiered;
        if (this.count >= this.requiered)
        {
            this.rewards.text = "Ahora ve a ¿Casa?";
        } else
        {
            this.rewards.text = "Desbloquear camino a casa.";
        }
    }
}

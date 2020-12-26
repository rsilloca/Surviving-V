using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public static float musicVolume = 0.5f;
    public static float effectsVolume = 0.8f;

    public Slider musicSlider;
    public Slider effectsSlider;
    public AudioSource musicAudio;
    // Start is called before the first frame update
    void Start()
    {
        this.musicSlider.value = musicVolume;
        this.effectsSlider.value = effectsVolume;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.musicAudio != null)
        {
            musicVolume = this.musicSlider.value;
            this.musicAudio.volume = musicSlider.value;
        }
        effectsVolume = this.effectsSlider.value;
    }
}

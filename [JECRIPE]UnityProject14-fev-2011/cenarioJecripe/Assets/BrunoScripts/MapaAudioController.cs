using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

[System.Serializable]
public partial class MapaAudioController : MonoBehaviour
{
    public float TimeToPlayAgain;
    public float auxCount;
    private bool canPlay;
    private GameObject gc;
    public bool just_entered;
    public virtual void Start()
    {
        this.gc = GameObject.Find("GameController");
        this.StartCoroutine(this.FirstCheck());
        just_entered = true;
    }

    public virtual void ResetTimer()
    {
        this.auxCount = this.TimeToPlayAgain;
    }

    public Transform cam;
    public Transform finalPosition;
    public virtual IEnumerator FirstCheck()
    {
        while ((this.cam.position - this.finalPosition.position).sqrMagnitude > 0.3f)
        {
            yield return new WaitForSeconds(0.2f);
        }
        this.canPlay = true;
    }

    public virtual void Update()
    {
        if (this.canPlay)
        {
            if (this.auxCount <= 0)
            {
                this.auxCount = this.TimeToPlayAgain;
                StartCoroutine(this.PlaySounds());
            }
            else
            {
                this.auxCount = this.auxCount - Time.deltaTime;
            }
        }
    }

    public List<AudioClip> menu_audios;
    public List<AudioClip> exit_audios;
    public AudioClip narrationAudio2;
    public AudioSource mapAudio;
    public int concluded;
    public virtual IEnumerator PlaySounds()
    {

        if (gc)
        {
            concluded = Convert.ToInt32(gc.GetComponent<GameController>().CasaBolhasCompleta) +
                Convert.ToInt32(gc.GetComponent<GameController>().CasaMusicaCompleta) +
                Convert.ToInt32(gc.GetComponent<GameController>().CrecheVovoCompleta);
            if(just_entered && gc.GetComponent<GameController>().PreviousScene != "Menu")
            {
                switch (concluded)
                {
                    case 0:
                        this.mapAudio.clip = this.exit_audios[0];
                        this.mapAudio.Play();
                        yield return new WaitWhile(() => this.mapAudio.isPlaying);
                        break;
                    case 1:
                        this.mapAudio.clip = this.exit_audios[1];
                        this.mapAudio.Play();
                        yield return new WaitWhile(() => this.mapAudio.isPlaying);
                        this.mapAudio.clip = this.exit_audios[2];
                        this.mapAudio.Play();
                        yield return new WaitWhile(() => this.mapAudio.isPlaying);
                        break;
                    // ... more case statements
                    case 2:
                        this.mapAudio.clip = this.exit_audios[3];
                        this.mapAudio.Play();
                        yield return new WaitWhile(() => this.mapAudio.isPlaying);
                        this.mapAudio.clip = this.exit_audios[4];
                        this.mapAudio.Play();
                        yield return new WaitWhile(() => this.mapAudio.isPlaying);
                        break;
                    case 3:
                        this.mapAudio.clip = this.exit_audios[5];
                        this.mapAudio.Play();
                        yield return new WaitWhile(() => this.mapAudio.isPlaying);
                        this.mapAudio.clip = this.exit_audios[6];
                        this.mapAudio.Play();
                        yield return new WaitWhile(() => this.mapAudio.isPlaying);
                        this.mapAudio.clip = this.exit_audios[7];
                        this.mapAudio.Play();
                        yield return new WaitWhile(() => this.mapAudio.isPlaying);
                        break;

                }
                just_entered = false;
            }
            this.mapAudio.clip = this.menu_audios[concluded*2];
            this.mapAudio.Play();
            yield return new WaitWhile(() => this.mapAudio.isPlaying);
            this.mapAudio.clip = this.menu_audios[concluded*2+1];
            this.mapAudio.Play();
            yield return new WaitWhile(() => this.mapAudio.isPlaying);

        }
        this.mapAudio.clip = this.narrationAudio2;
        this.mapAudio.Play();
        yield return new WaitWhile(() => this.mapAudio.isPlaying);

    }

    public MapaAudioController()
    {
        this.TimeToPlayAgain = 30;
    }

}
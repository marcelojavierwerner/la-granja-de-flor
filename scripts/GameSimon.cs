using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSimon : MonoBehaviour {

    public SpriteRenderer[] animales;
    public AudioSource[] buttonSounds;
    public GameObject menu;
    public GameObject perder;

    private int animalSelect;

    public float stayLit;
    private float stayLitCounter;

    public float waitBetweenLights;
    private float waitBetweenCounter;

    private bool shouldBeLit;
    private bool shouldBeDark;

    public List<int> activeSequence;
    private int positionInSequence;

    private bool gameActive;
    private bool onMusic;
    private int inpuInSequence;

    public AudioSource correct;
    public AudioSource incorrect;
    public AudioSource Music;

    public Text scoreText;

    void Start () {

        //PlayerPrefs.DeleteAll(); //Borraria todos los cambios
        if (!PlayerPrefs.HasKey("HiScore"))
        {
            PlayerPrefs.SetInt("HiScore", 0);
        }

        onMusic = true;
        scoreText.text = "Score: 0 - Hi Score: " + PlayerPrefs.GetInt("HiScore");
	}
	
	void Update () {
		if(shouldBeLit)
        {
            stayLitCounter -= Time.deltaTime;
        
            if(stayLitCounter < 0)
            {
                animales[activeSequence[positionInSequence]].color = new Color(animales[activeSequence[positionInSequence]].color.r,
                    animales[activeSequence[positionInSequence]].color.g, animales[activeSequence[positionInSequence]].color.b, 0.1f); //Cambiar para mejorar color
                buttonSounds[activeSequence[positionInSequence]].Stop();
                shouldBeLit = false;

                shouldBeDark = true;
                waitBetweenCounter = waitBetweenLights;

                positionInSequence++;
            }
        }

        if (shouldBeDark)
        {
            waitBetweenCounter -= Time.deltaTime;

            if(positionInSequence >= activeSequence.Count)
            {
                shouldBeDark = false;
                gameActive = true;
            }
            else
            {
                if(waitBetweenCounter < 0)
                {
                    

                    animales[activeSequence[positionInSequence]].color = new Color(animales[activeSequence[positionInSequence]].color.r,
                        animales[activeSequence[positionInSequence]].color.g, animales[activeSequence[positionInSequence]].color.b, 1f);
                    buttonSounds[activeSequence[positionInSequence]].Play();

                    stayLitCounter = stayLit;
                    shouldBeLit = true;
                    shouldBeDark = false;
                }
            }
        }
	}

    public void StartGame()
    {
        activeSequence.Clear();
        
        positionInSequence = 0;
        inpuInSequence = 0;

        animalSelect = Random.Range(0, animales.Length);

        activeSequence.Add(animalSelect);

        animales[activeSequence[positionInSequence]].color = new Color(animales[activeSequence[positionInSequence]].color.r,
            animales[activeSequence[positionInSequence]].color.g, animales[activeSequence[positionInSequence]].color.b, 1f);
        buttonSounds[activeSequence[positionInSequence]].Play();

        stayLitCounter = stayLit;
        shouldBeLit = true;

        scoreText.text = "Score: 0 - Hi Score: " + PlayerPrefs.GetInt("HiScore");
    }

    public void ColourPressed(int whichButton)
    {
        if (gameActive)
        {

            if (activeSequence[inpuInSequence] == whichButton)
            {

                inpuInSequence++;

                if (inpuInSequence >= activeSequence.Count)
                {
                    if (activeSequence.Count > PlayerPrefs.GetInt("HiScore"))
                    {
                        PlayerPrefs.SetInt("HiScore", activeSequence.Count);
                    }

                    scoreText.text = "Score: " + activeSequence.Count + " Hi Score: " + PlayerPrefs.GetInt("HiScore");

                    StartCoroutine(WaitBetweenSequences());
                }

            }
            else
            {
                //Debug.Log("WRONG!");
                incorrect.Play();
                gameActive = false;
                perder.SetActive(true);
            }
        }
    }

    public void BtnEmpezar()
    {
        perder.SetActive(false);
        menu.SetActive(false);
        StartCoroutine(Second());
    }

    public void BtnMusic()
    {
        if (onMusic)
        {
            Music.Stop();
            onMusic = false;
        }
        else
        {
            Music.Play();
            onMusic = true;
        }
    }

    public void AbriMenu()
    {
        menu.SetActive(true);
    }

    public void CerrarMenu()
    {
        menu.SetActive(false);
    }

    IEnumerator WaitBetweenSequences()
    {
        yield return new WaitForSeconds(waitBetweenLights);

        positionInSequence = 0;
        inpuInSequence = 0;

        animalSelect = Random.Range(0, animales.Length);

        activeSequence.Add(animalSelect);

        animales[activeSequence[positionInSequence]].color = new Color(animales[activeSequence[positionInSequence]].color.r, animales[activeSequence[positionInSequence]].color.g, animales[activeSequence[positionInSequence]].color.b, 1f);
        buttonSounds[activeSequence[positionInSequence]].Play();

        stayLitCounter = stayLit;
        shouldBeLit = true;

        gameActive = false;

        //Debug.Log("GOOD!");
        correct.Play();
    }

    IEnumerator Second()
    {
        yield return new WaitForSeconds(waitBetweenLights);

        StartGame();
    }
}

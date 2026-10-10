using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;
using System;

public class InterfazUsuario : MonoBehaviour {
	public GameObject menu;
	public GameObject menuGanador;
	public Text textoMenuGanador;
	public Slider sliderDif;
	public Text textoDificultad;

	public bool menuMostrado;
	public bool menuMostradoGanador;
	public int dificultad;

	public int SegundosCronometro;
	public Text cronometro;
	private TimeSpan tiempo;

	void Start(){
		CambiarDificultad ();
	}

	public void MostrarMenu(){
        AudioManagerG.amg.Botton.Play();
        menu.SetActive (true);
		menuMostrado = true;
	}

	public void EsconderMenu(){
        AudioManagerG.amg.Botton.Play();
        menu.SetActive (false);
		menuMostrado = false;
	}

	public void MostrarMenuGanador(){
		menuGanador.SetActive (true);
		menuMostradoGanador = true;
		textoMenuGanador.text = "HAS GANADO!" + '\n' + "Has encontrado todas las parejas en " + '\n' + tiempo;
	}

	public void EsconderMenuGanador(){
        AudioManagerG.amg.Botton.Play();
        menuGanador.SetActive (false);
		menuMostradoGanador = false;
	}


	public void CambiarDificultad(){
		dificultad = (int) sliderDif.value*2;
        if(dificultad == 4)
        {
            textoDificultad.text = "Dificultad: Facil";
        }else if(dificultad == 6)
        {
            textoDificultad.text = "Dificultad: Intermedia";
        }else if(dificultad == 8)
        {
            textoDificultad.text = "Dificultad: Dificil";
        }
		//textoDificultad.text  = "Dificultad: " + dificultad ;
	}


	public void ActivarCronometro(){
		ActualizarCronometro ();
	}

	public void ReiniciarCronometro(){
		SegundosCronometro = 0;
		CancelInvoke ("ActualizarCronometro");

	}

	public void PausarCronometro(){

	}

	public void ActualizarCronometro(){
		SegundosCronometro++;
		tiempo = new TimeSpan(0,0,  SegundosCronometro);
		cronometro.text = tiempo.ToString();
		Invoke ("ActualizarCronometro", 1.0f);
	}


}

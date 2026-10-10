using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager gm;

    public GameObject CaraGato;
    public GameObject CaraPerro;
    public GameObject CaraVaca;
    public GameObject CaraCaballo;
    public GameObject CaraObeja;
    public GameObject CaraGallina;
    public GameObject CaraConejo;
    public GameObject CaraChancho;
    public GameObject CaraAmarillo;
    public GameObject CaraRojo;
    public GameObject CaraNaranja;
    public GameObject CaraAzul;
    public GameObject CaraCeleste;
    public GameObject CaraVerde;
    public GameObject CaraSol;
    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A5;
    public GameObject A6;
    public GameObject A7;
    public GameObject A8;
    public GameObject A9;
    public GameObject Gato;
    public GameObject Perro;
    public GameObject Vaca;
    public GameObject Caballo;
    public GameObject Obeja;
    public GameObject Gallina1;
    public GameObject Gallina2;
    public GameObject Conejo;
    public GameObject Chancho;


    private void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
        else if (gm != this)
        {
            Destroy(gameObject);
        }
    }

    public void CaraGatus()
    {
        StartCoroutine(CaraGatos());
    }

    public IEnumerator CaraGatos()
    {
        CaraGato.SetActive(false); CaraPerro.SetActive(false); CaraVaca.SetActive(false); CaraCaballo.SetActive(false);
        CaraObeja.SetActive(false); CaraGallina.SetActive(false); CaraChancho.SetActive(false); CaraConejo.SetActive(false);
        CaraSol.SetActive(false);
        CaraGato.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraGato.SetActive(false);
    }

    public void CaraPerrus()
    {
        StartCoroutine(CaraPerros());
    }

    public IEnumerator CaraPerros()
    {
        CaraGato.SetActive(false); CaraPerro.SetActive(false); CaraVaca.SetActive(false); CaraCaballo.SetActive(false);
        CaraObeja.SetActive(false); CaraGallina.SetActive(false); CaraChancho.SetActive(false); CaraConejo.SetActive(false);
        CaraSol.SetActive(false);
        CaraPerro.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraPerro.SetActive(false);
    }

    public void CaraVacus()
    {
        StartCoroutine(CaraVacas());
    }

    public IEnumerator CaraVacas()
    {
        CaraGato.SetActive(false); CaraPerro.SetActive(false); CaraVaca.SetActive(false); CaraCaballo.SetActive(false);
        CaraObeja.SetActive(false); CaraGallina.SetActive(false); CaraChancho.SetActive(false); CaraConejo.SetActive(false);
        CaraSol.SetActive(false);
        CaraVaca.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraVaca.SetActive(false);
    }

    public void CaraCaballus()
    {
        StartCoroutine(CaraCaballos());
    }

    public IEnumerator CaraCaballos()
    {
        CaraGato.SetActive(false); CaraPerro.SetActive(false); CaraVaca.SetActive(false); CaraCaballo.SetActive(false);
        CaraObeja.SetActive(false); CaraGallina.SetActive(false); CaraChancho.SetActive(false); CaraConejo.SetActive(false);
        CaraSol.SetActive(false);
        CaraCaballo.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraCaballo.SetActive(false);
    }

    public void CaraObejus()
    {
        StartCoroutine(CaraObejas());
    }

    public IEnumerator CaraObejas()
    {
        CaraGato.SetActive(false); CaraPerro.SetActive(false); CaraVaca.SetActive(false); CaraCaballo.SetActive(false);
        CaraObeja.SetActive(false); CaraGallina.SetActive(false); CaraChancho.SetActive(false); CaraConejo.SetActive(false);
        CaraSol.SetActive(false);
        CaraObeja.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraObeja.SetActive(false);
    }

    public void CaraGallinus()
    {
        StartCoroutine(CaraGallinas());
    }

    public IEnumerator CaraGallinas()
    {
        CaraGato.SetActive(false); CaraPerro.SetActive(false); CaraVaca.SetActive(false); CaraCaballo.SetActive(false);
        CaraObeja.SetActive(false); CaraGallina.SetActive(false); CaraChancho.SetActive(false); CaraConejo.SetActive(false);
        CaraSol.SetActive(false);
        CaraGallina.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraGallina.SetActive(false);
    }

    public void CaraChanchus()
    {
        StartCoroutine(CaraChanchos());
    }

    public IEnumerator CaraChanchos()
    {
        CaraGato.SetActive(false); CaraPerro.SetActive(false); CaraVaca.SetActive(false); CaraCaballo.SetActive(false);
        CaraObeja.SetActive(false); CaraGallina.SetActive(false); CaraChancho.SetActive(false); CaraConejo.SetActive(false);
        CaraSol.SetActive(false);
        CaraChancho.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraChancho.SetActive(false);
    }

    public void CaraConejus()
    {
        StartCoroutine(CaraConejos());
    }

    public IEnumerator CaraConejos()
    {
        CaraGato.SetActive(false); CaraPerro.SetActive(false); CaraVaca.SetActive(false); CaraCaballo.SetActive(false);
        CaraObeja.SetActive(false); CaraGallina.SetActive(false); CaraChancho.SetActive(false); CaraConejo.SetActive(false);
        CaraSol.SetActive(false);
        CaraConejo.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraConejo.SetActive(false);
    }

    public void CaraRojos()
    {
        StartCoroutine(CaraRojose());
    }

    public IEnumerator CaraRojose()
    {
        CaraRojo.SetActive(false); CaraNaranja.SetActive(false); CaraAmarillo.SetActive(false); CaraVerde.SetActive(false);
        CaraCeleste.SetActive(false); CaraAzul.SetActive(false); CaraAmarillo.SetActive(false);
        CaraRojo.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraRojo.SetActive(false);
    }

    public void CaraNaranjas()
    {
        StartCoroutine(CaraNaranjase());
    }

    public IEnumerator CaraNaranjase()
    {
        CaraRojo.SetActive(false); CaraNaranja.SetActive(false); CaraAmarillo.SetActive(false); CaraVerde.SetActive(false);
        CaraCeleste.SetActive(false); CaraAzul.SetActive(false); CaraAmarillo.SetActive(false);
        CaraNaranja.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraNaranja.SetActive(false);
    }

    public void CaraAmarillos()
    {
        StartCoroutine(CaraAmarillose());
    }

    public IEnumerator CaraAmarillose()
    {
        CaraRojo.SetActive(false); CaraNaranja.SetActive(false); CaraAmarillo.SetActive(false); CaraVerde.SetActive(false);
        CaraCeleste.SetActive(false); CaraAzul.SetActive(false); CaraAmarillo.SetActive(false);
        CaraAmarillo.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraAmarillo.SetActive(false);
    }

    public void CaraVerdes()
    {
        StartCoroutine(CaraVerdese());
    }

    public IEnumerator CaraVerdese()
    {
        CaraRojo.SetActive(false); CaraNaranja.SetActive(false); CaraAmarillo.SetActive(false); CaraVerde.SetActive(false);
        CaraCeleste.SetActive(false); CaraAzul.SetActive(false); CaraAmarillo.SetActive(false);
        CaraVerde.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraVerde.SetActive(false);
    }

    public void CaraCelestes()
    {
        StartCoroutine(CaraCelestese());
    }

    public IEnumerator CaraCelestese()
    {
        CaraRojo.SetActive(false); CaraNaranja.SetActive(false); CaraAmarillo.SetActive(false); CaraVerde.SetActive(false);
        CaraCeleste.SetActive(false); CaraAzul.SetActive(false); CaraAmarillo.SetActive(false);
        CaraCeleste.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraCeleste.SetActive(false);
    }

    public void CaraAzuls()
    {
        StartCoroutine(CaraAzulse());
    }

    public IEnumerator CaraAzulse()
    {
        CaraRojo.SetActive(false); CaraNaranja.SetActive(false); CaraAmarillo.SetActive(false); CaraVerde.SetActive(false);
        CaraCeleste.SetActive(false); CaraAzul.SetActive(false); CaraAmarillo.SetActive(false);
        CaraAzul.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraAzul.SetActive(false);
    }

    public void CaraSols()
    {
        StartCoroutine(CaraSolse());
    }

    public IEnumerator CaraSolse()
    {
        CaraSol.SetActive(true);

        yield return new WaitForSeconds(3);

        CaraSol.SetActive(false);
    }

    public void Unos()
    {
        StartCoroutine(Unose());
    }

    public IEnumerator Unose()
    {
        A1.SetActive(false); A2.SetActive(false); A3.SetActive(false); A4.SetActive(false); A5.SetActive(false);
        A6.SetActive(false); A7.SetActive(false); A8.SetActive(false); A9.SetActive(false);
        A1.SetActive(true);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
        Caballo.SetActive(false);
        Perro.SetActive(false);
        Gato.SetActive(false);
        Vaca.SetActive(false);
        Gallina1.SetActive(true);

        yield return new WaitForSeconds(3);

        A1.SetActive(false);
        Gallina1.SetActive(false);
    }

    public void Doss()
    {
        StartCoroutine(Dosse());
    }

    public IEnumerator Dosse()
    {
        A1.SetActive(false); A2.SetActive(false); A3.SetActive(false); A4.SetActive(false); A5.SetActive(false);
        A6.SetActive(false); A7.SetActive(false); A8.SetActive(false); A9.SetActive(false);
        A2.SetActive(true);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
        Caballo.SetActive(false);
        Perro.SetActive(false);
        Gato.SetActive(false);
        Vaca.SetActive(false);
        Gallina1.SetActive(true);
        Gallina2.SetActive(true);

        yield return new WaitForSeconds(3);

        A2.SetActive(false);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
    }

    public void Tress()
    {
        StartCoroutine(Tresse());
    }

    public IEnumerator Tresse()
    {
        A1.SetActive(false); A2.SetActive(false); A3.SetActive(false); A4.SetActive(false); A5.SetActive(false);
        A6.SetActive(false); A7.SetActive(false); A8.SetActive(false); A9.SetActive(false);
        A3.SetActive(true);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
        Caballo.SetActive(false);
        Perro.SetActive(false);
        Gato.SetActive(false);
        Vaca.SetActive(false);
        Gallina1.SetActive(true);
        Gallina2.SetActive(true);
        Chancho.SetActive(true);

        yield return new WaitForSeconds(3);

        A3.SetActive(false);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
    }

    public void Cuatros()
    {
        StartCoroutine(Cuatrose());
    }

    public IEnumerator Cuatrose()
    {
        A1.SetActive(false); A2.SetActive(false); A3.SetActive(false); A4.SetActive(false); A5.SetActive(false);
        A6.SetActive(false); A7.SetActive(false); A8.SetActive(false); A9.SetActive(false);
        A4.SetActive(true);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
        Caballo.SetActive(false);
        Perro.SetActive(false);
        Gato.SetActive(false);
        Vaca.SetActive(false);
        Gallina1.SetActive(true);
        Gallina2.SetActive(true);
        Chancho.SetActive(true);
        Conejo.SetActive(true);

        yield return new WaitForSeconds(3);

        A4.SetActive(false);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
    }

    public void Cincos()
    {
        StartCoroutine(Cincose());
    }

    public IEnumerator Cincose()
    {
        A1.SetActive(false); A2.SetActive(false); A3.SetActive(false); A4.SetActive(false); A5.SetActive(false);
        A6.SetActive(false); A7.SetActive(false); A8.SetActive(false); A9.SetActive(false);
        A5.SetActive(true);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
        Caballo.SetActive(false);
        Perro.SetActive(false);
        Gato.SetActive(false);
        Vaca.SetActive(false);
        Gallina1.SetActive(true);
        Gallina2.SetActive(true);
        Chancho.SetActive(true);
        Conejo.SetActive(true);
        Obeja.SetActive(true);

        yield return new WaitForSeconds(3);

        A5.SetActive(false);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
    }

    public void Seiss()
    {
        StartCoroutine(Seisse());
    }

    public IEnumerator Seisse()
    {
        A1.SetActive(false); A2.SetActive(false); A3.SetActive(false); A4.SetActive(false); A5.SetActive(false);
        A6.SetActive(false); A7.SetActive(false); A8.SetActive(false); A9.SetActive(false);
        A6.SetActive(true);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
        Caballo.SetActive(false);
        Perro.SetActive(false);
        Gato.SetActive(false);
        Vaca.SetActive(false);
        Gallina1.SetActive(true);
        Gallina2.SetActive(true);
        Chancho.SetActive(true);
        Conejo.SetActive(true);
        Obeja.SetActive(true);
        Caballo.SetActive(true);

        yield return new WaitForSeconds(3);

        A6.SetActive(false);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
        Caballo.SetActive(false);
    }

    public void Sietes()
    {
        StartCoroutine(Sietese());
    }

    public IEnumerator Sietese()
    {
        A1.SetActive(false); A2.SetActive(false); A3.SetActive(false); A4.SetActive(false); A5.SetActive(false);
        A6.SetActive(false); A7.SetActive(false); A8.SetActive(false); A9.SetActive(false);
        A7.SetActive(true);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
        Caballo.SetActive(false);
        Perro.SetActive(false);
        Gato.SetActive(false);
        Vaca.SetActive(false);
        Gallina1.SetActive(true);
        Gallina2.SetActive(true);
        Chancho.SetActive(true);
        Conejo.SetActive(true);
        Obeja.SetActive(true);
        Caballo.SetActive(true);
        Perro.SetActive(true);

        yield return new WaitForSeconds(3);

        A7.SetActive(false);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
        Caballo.SetActive(false);
        Perro.SetActive(false);
    }

    public void Ochos()
    {
        StartCoroutine(Ochose());
    }

    public IEnumerator Ochose()
    {
        A1.SetActive(false); A2.SetActive(false); A3.SetActive(false); A4.SetActive(false); A5.SetActive(false);
        A6.SetActive(false); A7.SetActive(false); A8.SetActive(false); A9.SetActive(false);
        A8.SetActive(true);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
        Caballo.SetActive(false);
        Perro.SetActive(false);
        Gato.SetActive(false);
        Vaca.SetActive(false);
        Gallina1.SetActive(true);
        Gallina2.SetActive(true);
        Chancho.SetActive(true);
        Conejo.SetActive(true);
        Obeja.SetActive(true);
        Caballo.SetActive(true);
        Perro.SetActive(true);
        Gato.SetActive(true);

        yield return new WaitForSeconds(3);

        A8.SetActive(false);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
        Caballo.SetActive(false);
        Perro.SetActive(false);
        Gato.SetActive(false);
    }

    public void Nueves()
    {
        StartCoroutine(Nuevese());
    }

    public IEnumerator Nuevese()
    {
        A1.SetActive(false); A2.SetActive(false); A3.SetActive(false); A4.SetActive(false); A5.SetActive(false);
        A6.SetActive(false); A7.SetActive(false); A8.SetActive(false); A9.SetActive(false);
        A9.SetActive(true);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
        Caballo.SetActive(false);
        Perro.SetActive(false);
        Gato.SetActive(false);
        Vaca.SetActive(false);
        Gallina1.SetActive(true);
        Gallina2.SetActive(true);
        Chancho.SetActive(true);
        Conejo.SetActive(true);
        Obeja.SetActive(true);
        Caballo.SetActive(true);
        Perro.SetActive(true);
        Gato.SetActive(true);
        Vaca.SetActive(true);

        yield return new WaitForSeconds(3);

        A9.SetActive(false);
        Gallina1.SetActive(false);
        Gallina2.SetActive(false);
        Chancho.SetActive(false);
        Conejo.SetActive(false);
        Obeja.SetActive(false);
        Caballo.SetActive(false);
        Perro.SetActive(false);
        Gato.SetActive(false);
        Vaca.SetActive(false);
    }
}

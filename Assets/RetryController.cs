﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryController : MonoBehaviour {

	public void CargarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class GameManager : MonoBehaviour
{

	private string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpYXQiOjE2MjE5ODg5MDYsInN1YiI6IjBmMDQzZTNhLTMxMmQtNDlkNi1hYTgwLTM0ODRhMDVmOTE1YiJ9.Byt1MJWuUBK0vp_gvEicjhsn70BfnrAhOtJcuhY9IkQ";
    public static Micelio micelio;

    void Start()
    {
        //Debug.Log(Application.persistentDataPath);
        micelio = new Micelio(token, "dev");
        
        Session session = new Session("pt-BR","1");
        session.SetName("game start");
        micelio.StartSession(session);

        Soldado player = new Soldado(10,25,"soldier",150,130);
        Arma gun = new Arma(5.5f,1.5);

        player.Fire(gun,"wave 1");

        micelio.CloseSession();        
    }

    void Update()
    {

    }
}

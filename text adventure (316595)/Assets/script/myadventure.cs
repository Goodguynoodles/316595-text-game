using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class myadventure : MonoBehaviour
{
    //dit zijn de states voor de game
    private enum States
    {
        start,
        intro,
        take1,
        gameover,
        take2,
        plane,
        airport,
        shipyard,
        stealboat,
        hallway,
        kidnapped,
        gun,
        fault,
    }

    private States currentState = States.start;

    // dit laat de start
    void Start()
    {
        ShowMainMenu();
    }
    //dit zijn de opties die je kijg in de game
    void OnUserInput(string input)
    {
        // dit laat je terug naar het main menu gaan
        if (input == "menu")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        switch (currentState)
        {
            case States.gameover:
                if (input == "gameover")
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                }
                else
                {
                    Terminal.WriteLine("type gameover");
                }

                break;
            case States.start:
                if (input == "start")
                {
                    StartIntro();
                }
                //dit zijn de credits voor de game
                else if (input == "credits")
                {
                    Credits();
                }
                else
                {
                    Terminal.WriteLine("type start to begin");
                }

                break;

            case States.intro:

                if (input == "steal a car")
                {
                    Take1();
                }
                else if (input == "hide")
                {
                    hideend();
                }
                else if (input == "run")
                {
                    run();
                }
                break;
            case States.take1:
                if (input == "laferrari")
                {
                    deathcar();
                }

                else if (input == "old lady")
                {
                    carlife();
                }
                break;
            case States.take2:
                if (input == "airport")
                {
                    airport();
                }
                else if (input == "ship yard")
                {
                    shipyard();
                }
                break;
            case States.airport:
                if (input == "steal a plane")
                {
                    stealplane();
                }
                else if (input == "buy a ticket")
                {
                    buyticket();
                }
                else if (input == "shipyard")
                {
                    shipyard();
                }
                break;
            case States.plane:
                if (input == "drive through")
                {
                    drivethrough();
                }
                else if (input == "climb")
                {
                    climb();
                }
                break;
            case States.shipyard:
                if (input == "search")
                {
                    search();
                }
                else if (input == "steal a boat")
                {
                    stealboat();
                }
                break;
            case States.kidnapped:
                if (input == "escape")
                {
                    escape();
                }
                else if (input == "talk")
                {
                    talk();
                }
                break;
            case States.stealboat:
                if (input == "")
                {
                    kidnapped();
                }
                else
                {
                    kidnapped();
                }
                
                break;
            case States.hallway:
                if (input == "left")
                {
                    left();
                }
                else if (input =="right")
                {
                    right();
                }
                break;
            case States.fault:
                if (input == "explosive")
                {
                    boom();
                }
                else if (input == "gun and armor")
                {
                    gun();
                }
                break;
        }
    }
    //dit is het verhaal van de game
    void Credits()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("koos van losenoord");
    }

    void ShowMainMenu()
    {
        Terminal.WriteLine("");
        Terminal.WriteLine("the adventure of the devil's");
        Terminal.WriteLine("");
        Terminal.WriteLine("it was a dark night the ");
        Terminal.WriteLine("darkest of them all");
        Terminal.WriteLine("");
        Terminal.WriteLine("and the devil's was on the run");
        Terminal.WriteLine("from the china");
        Terminal.WriteLine("");
    }

    void Showmainmenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("the adventure of the devil's");
        Terminal.WriteLine("");
        Terminal.WriteLine("it was a dark night the ");
        Terminal.WriteLine("darkest of them all");
        Terminal.WriteLine("    ");
        Terminal.WriteLine("and the devil's was on the run");
        Terminal.WriteLine("from the china");
        Terminal.WriteLine("");
        currentState = States.start;
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("it around 2 am and you are in amsterdam");
        Terminal.WriteLine("in the center and it full of people");
        Terminal.WriteLine("running from chinees special agents");
        Terminal.WriteLine("they are about 5 meters behind you");
        Terminal.WriteLine("you have three option's");
        Terminal.WriteLine("you can run hide or steal a car");
        Terminal.WriteLine("");
        Terminal.WriteLine("> hide");
        Terminal.WriteLine("> run");
        Terminal.WriteLine("> steal a car");
        currentState = States.intro;
    }

    void Take1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you seen 2 cars one with a old lady");
        Terminal.WriteLine("and the car is all ready running");
        Terminal.WriteLine("or a laferrari next to her");
        Terminal.WriteLine("");
        Terminal.WriteLine("> laferrari");
        Terminal.WriteLine("> old lady");
        currentState = States.take1;
    }

    void deathcar()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("the car is locked and you get caught");
        Terminal.WriteLine("by the Chinese");
        Terminal.WriteLine("you get killed by the Chinese");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("type gameover");
        currentState = States.gameover;
    }

    void carlife()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you drive to the highway");
        Terminal.WriteLine("with a car you stole from grandma");
        Terminal.WriteLine("you have 2 options ");
        Terminal.WriteLine("drive to the airport or");
        Terminal.WriteLine("to the ship yard");
        Terminal.WriteLine("");
        Terminal.WriteLine("> ship yard");
        Terminal.WriteLine("> airport");
        currentState = States.take2;
    }

    void hideend()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you tried to hide but there were");
        Terminal.WriteLine("no good hiding place's in the area");
        Terminal.WriteLine("so you get caught and murdered by the");
        Terminal.WriteLine("Chinese");
        currentState = States.gameover;
    }
    void airport()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you arrive at the airport");
        Terminal.WriteLine("you have 2 options steal a plane");
        Terminal.WriteLine("or buy a ticket with your credit card");
        Terminal.WriteLine("but run de risk of the chinese knowing");
        Terminal.WriteLine("where you are");
        Terminal.WriteLine("");
        Terminal.WriteLine("> steal a plane");
        Terminal.WriteLine("> buy a ticket");
        currentState = States.airport;
    }

    void stealplane()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you try go to the lading strip");
        Terminal.WriteLine("but there is a fence between you");
        Terminal.WriteLine("and the plane");
        Terminal.WriteLine("you can drive through the fence");
        Terminal.WriteLine("or climb over it"); 
        Terminal.WriteLine("");
        Terminal.WriteLine("climb");
        Terminal.WriteLine("drive through");
        currentState = States.plane;

    }

    void drivethrough()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you drive to a small plane");
        Terminal.WriteLine("you start the plane and try to");
        Terminal.WriteLine("fly it but you crash in to the airport");
        Terminal.WriteLine("with not only killing your self");
        Terminal.WriteLine("but also killing 50 other people");
        currentState = States.gameover;
    }

    void climb()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you try to clim the fence but it's");
        Terminal.WriteLine("electric fence and you get killed by it");
        currentState = States.gameover;
    }

    void buyticket()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you buy a ticket but the chinese");
        Terminal.WriteLine("find your location kill you");
        currentState = States.gameover;
    }

    void run()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you keep running but e after a while");
        Terminal.WriteLine("they catch up with you and kill you");
        currentState = States.gameover;
    }

    void shipyard()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you arrived at the ship yard");
        Terminal.WriteLine("you have 2 options");
        Terminal.WriteLine("you can search for a man willing to take");
        Terminal.WriteLine("you to america to your home");
        Terminal.WriteLine("or you can steal a boat");
        Terminal.WriteLine("");
        Terminal.WriteLine("> steal a boat");
        Terminal.WriteLine("> search");
        currentState = States.shipyard;
    }

    void search()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you find a old sailer willing to take");
        Terminal.WriteLine("you for a small fee");
        Terminal.WriteLine("you pay the man and you go home");
        Terminal.WriteLine("apologies to china and they accept it");
        Terminal.WriteLine("and you live a long and happy live");
        Terminal.WriteLine("the end");
    }

    void stealboat()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you try to steal a boat");
        Terminal.WriteLine("but you steal the wrong boat");
        Terminal.WriteLine("it a boat from the port mafia");
        Terminal.WriteLine("and you get kidnapped");
        currentState = States.stealboat;
    }

    void kidnapped()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you are in a torture chamber");
        Terminal.WriteLine("and your kidnapper are ");
        Terminal.WriteLine("interrogating you");
        Terminal.WriteLine("you can try to talk you way out of it");
        Terminal.WriteLine("or try to escape when they leave");
        Terminal.WriteLine("your cell");
        Terminal.WriteLine("");
        Terminal.WriteLine("> escape");
        Terminal.WriteLine("> talk");
        currentState = States.kidnapped;
    }
    
    void escape()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you escape your cell when they leave");
        Terminal.WriteLine("and you come to a spliting");
        Terminal.WriteLine("in the hallway");
        Terminal.WriteLine("you can go right or left");
        Terminal.WriteLine("");
        Terminal.WriteLine("> right");
        Terminal.WriteLine("> left");
        currentState = States.hallway; 
    }

    void talk()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you try to talk to them but when you talk");
        Terminal.WriteLine("they hit you and you die 5 hour later because");
        Terminal.WriteLine("of your wounds");
        currentState = States.gameover;
    }

    void left()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you come across some mafia members");
        Terminal.WriteLine("and they kill you");
        currentState = States.gameover;
    }

    void right()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk about 10 meters");
        Terminal.WriteLine("and find a door leading to the weapons fault");
        Terminal.WriteLine("you have 2 options");
        Terminal.WriteLine("you can grab some explosives");
        Terminal.WriteLine("or you can grab some body armor");
        Terminal.WriteLine("and a assault");
        Terminal.WriteLine("");
        Terminal.WriteLine("> explosive");
        Terminal.WriteLine("> gun and armor");
        currentState = States.fault;
    }

    void boom()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you try to grab the explosion but");
        Terminal.WriteLine("you accidentally activate it and die");
        currentState = States.gameover;
    }

    void gun()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you grab the gear and walk out of");
        Terminal.WriteLine("the door");
        Terminal.WriteLine("about 10 second later you get killed");
        Terminal.WriteLine("in a gun fight");
        currentState = States.gameover;
    }
}
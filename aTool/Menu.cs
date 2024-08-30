using Kino.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine;
using CarX;
using UnityEngine.UIElements;

namespace aTool
{
    [KinoPlugin("aTool", "1.0", "Hoplan")]
    public class Menu : BaseMod
    {

        //---------------------------------------------------------------------

        private bool showMenu = false;
        private Rect menuRect;

        private Rigidbody CarBody;
        private Car Car;

        private bool test = false;
        private string textfield = "text ici";
        private float slider1 = 0f;


        //---------------------------------------------------------------------
        public void Start()
        {


        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F5))
            {
                showMenu = !showMenu;
            }


        }

        void FixedUpdate()
        { 


        }

        void OnGUI()
        {
            if (showMenu)
            {
                menuRect = GUI.Window(0, menuRect, MainMenu, "Menu");
            }



        }

        void MainMenu(int windowID)
        {
            GUILayout.BeginVertical();
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            GUILayout.Label("text", GUI.skin.box);
            GUILayout.Button("boutton");
            test = GUILayout.Toggle(test, "toggle");
            textfield = GUILayout.TextField(textfield);
            slider1 = GUILayout.HorizontalSlider(slider1, 1f, 1000f);

            // exemple boutton 
            if (GUILayout.Button("Envoyer un message dans la console"))
            {
                Debug.Log("Test console boutton");
            }
        }


        private void OnEnable()
        {


        }

        private void OnDisable()
        {


        }

        private void FindCarBody()
        {
            Car = UnityEngine.Object.FindFirstObjectByType<Car>();
            if (Car != null)
            {
                CarBody = Car.GetComponent<Rigidbody>();
            }
        }
    }
}
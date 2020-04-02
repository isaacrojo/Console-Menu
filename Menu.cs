using System;
using System.Collections.Generic;

namespace console_menu
{
    class Menu
    {
        /*

        ¡Bienvenido a la nevería!

        1) Tipo de cono    DONE
        2) Sabor de nieve        DONE   
        3) Sencillo o doble
        4) Con o sin chocolate
        5) Toppings

        6) Pagar

        9) Salir

        Selecciona una opción:
        > 1
        [enter]

        */

        private const int MAIN_MENU_EXIT_OPTION = 9;
        private const int GO_BACK_OPTION = 9;

        List<int> mainMenuOptions = new List<int>(new int[] {1, 2, 3, 4, 5, 6, 9});
        List<int> selectConeOptions = new List<int>(new int[] {1, 2, 9});

        private string tipoCono = "Regular";
        private string sabor = "Cafe";
        private string tamaño = "Sencillo";
        private string nuez = "con nuez";


        



        private void DisplayWelcomeMessage() {
            System.Console.WriteLine("¡Bienvenido a la nevería!");
            System.Console.WriteLine();
        }

        private void DisplayMainMenuOptions() {
            System.Console.WriteLine("1) Tipo de cono");
            System.Console.WriteLine("2) Sabor de nieve");
            System.Console.WriteLine("3) Sencillo o doble");
            System.Console.WriteLine("4) Con o sin nuez");
            //System.Console.WriteLine("5) Toppings");
            System.Console.WriteLine();
            System.Console.WriteLine("6) Pagar");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }

        private void DisplayByeMessage() {
            System.Console.WriteLine("¡Gracias por su preferencia! ¡Hasta luego!");
        }

        private int RequestOption(List<int> validOptions) {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            //Mientras no haya una respuesta válida...
            while(!isUserInputValid) {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                } catch (System.Exception) {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

        /*
        Selecciona un tipo de cono

        1) Regular
        2) Waffle

        9) Volver

        Selecciona una opción:
        > 1
        [enter]

        */

        private void DisplaySelectConeMessage() {
            System.Console.WriteLine("Selecciona un tipo de cono");
            System.Console.WriteLine();
        }

        private void DisplaySelectConeOptions() {
            System.Console.WriteLine("1) Regular");
            System.Console.WriteLine("2) Waffle");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Volver");
        }

        private void SelectConeType() {
            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION) {
                DisplaySelectConeMessage();
                DisplaySelectConeOptions();
                System.Console.WriteLine($"Tipo de Cono seleccionado: {tipoCono}");

                selectedOption = RequestOption(selectConeOptions);

                switch (selectedOption)
                {
                    case 1: //Regular
                        tipoCono = "Regular";
                        break;
                    case 2: //Waffle
                        tipoCono = "Waffle";
                        break;
                } //el break se sale de este switch
            }
        }

        //vamo a pedir sabor de nieve
        private void DisplaySelectFlavorMessage() {
            System.Console.WriteLine("Selecciona un sabor de nieve");
            System.Console.WriteLine();
        }
        private void DisplaySelectFlavorOptions() {
            System.Console.WriteLine("1) Oreo");
            System.Console.WriteLine("2) Cafe");
            System.Console.WriteLine("3) Vainilla");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Volver");
        }
        private void SelectFlavorType() {
            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION) {
                DisplaySelectFlavorMessage();
                DisplaySelectFlavorOptions();
                System.Console.WriteLine($"Sabor seleccionado: {sabor}");

                selectedOption = RequestOption(selectConeOptions);

                switch (selectedOption)
                {
                    case 1: //oreo
                        sabor = "Oreo";
                        break;
                    case 2: //cafe
                        sabor = "Cafe";
                        break;
                    case 3: //Vainilla
                        sabor = "Vainilla";
                        break;    
                } //el break se sale de este switch
            }
        }

        //vamo a pedirle tamaño de helao
        private void DisplaySelectSizeMessage() {
            System.Console.WriteLine("Selecciona un tamaño de cono");
            System.Console.WriteLine();
        }
        private void DisplaySelectSizeOptions() {
            System.Console.WriteLine("1) Sencillo");
            System.Console.WriteLine("2) Doble");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Volver");
        }
        private void SelectSize() {
            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION) {
                DisplaySelectSizeMessage();
                DisplaySelectSizeOptions();
                System.Console.WriteLine($"Tamaño seleccionado: {tamaño}");

                selectedOption = RequestOption(selectConeOptions);

                switch (selectedOption)
                {
                    case 1: //Sencillo
                        tamaño = "Sencillo";
                        break;
                    case 2: //Doble
                        tamaño = "Doble";
                        break;
                } //el break se sale de este switch
            }
        }

        //vamo a ver si quiere nuez o no en su delicioso ice cream
        private void DisplayNuezMessage() {
            System.Console.WriteLine("Quieres ponerle nuez a tu helado?");
            System.Console.WriteLine();
        }
        private void DisplayNuezOptions() {
            System.Console.WriteLine("1) Si, con nuez");
            System.Console.WriteLine("2) No, sin nuez");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Volver");
        }
        private void SelectNuez() {
            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION) {
                DisplayNuezMessage();
                DisplayNuezOptions();
                System.Console.WriteLine($"Entonces te lo ponemos {nuez}");

                selectedOption = RequestOption(selectConeOptions);

                switch (selectedOption)
                {
                    case 1:
                        nuez = "Si, con nuez";
                        break;
                    case 2: 
                        nuez = "Si, con nuez";
                        break;
                } //el break se sale de este switch
            }
        }



        private void Pay() {
            //\n es salto de línea
            System.Console.WriteLine("Tu pedido es el siguiente:\n");
            System.Console.WriteLine($"tipoCono => {tipoCono}");

            System.Console.WriteLine("\n!Gracias por tu compra!");
        }

        public void Display() {
            int selectedOption = 0;

            DisplayWelcomeMessage();

            while (selectedOption != MAIN_MENU_EXIT_OPTION) {
                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);

                switch (selectedOption)
                {
                    case 1: //Tipo de cono
                        SelectConeType();
                        break;
                    case 2: //sabor
                        SelectFlavorType();
                        break;  
                    case 3: //tamaño
                        SelectSize();
                        break; 
                    case 4: //con nuez o no
                        SelectNuez();
                        break;            
                    case 6: //Pagar
                        Pay();
                        selectedOption = MAIN_MENU_EXIT_OPTION;
                        break;
                    // default:
                }
            }

            DisplayByeMessage();

        }
       
    }
}

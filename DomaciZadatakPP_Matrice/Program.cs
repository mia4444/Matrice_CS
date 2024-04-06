using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciZadatakPP_Matrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Pre matrica ću probati da rešim sama prva tri zadatka iz jednodimenzionalnih nizova

            /*Zadatak 1
                Napraviti konzolnu aplikaciju koja omogućava ispis elemenata niza unazad.
                Inicijalizovati proizvoljan jednodimenzionalni niz u kodu.
             */

            int[] mojNiz ={1,2,3,4,5}; //znaci nije korisnik unosio, nego ja proizvoljno
            int[] reversed = new int[mojNiz.Length];//novi reversed niz preuzima vrednost koja mu je dodeljena, tj duzinu inicijalnog niza
            //int index;
            //iste su duzine oba niza, samo će indexi držati drugačije vrednosti 
            for (int index = 0; index < mojNiz.Length; index++)
            {
                reversed[mojNiz.Length - index - 1] = mojNiz[index];
            }//ne zaboravi da zatvoriš

                //Ispis obrnutog niza

                for (int index = 0; index < mojNiz.Length; index++)
                {

                    Console.Write(reversed[index] + " "); //biće write, jer želimo da nam se ispiše u istom redu
                    
                }
                Console.ReadKey();//da je bio u liniji 35, jednu po jednu liniju bi ispisivao, ovako ih ispisuje u jednom redu sa razmakom i sve odmah


            /*Zadatak 2
             Napraviti konzolnu aplikaciju koja ispituje da li je veći treći ili
             četvrti element niza.
             */

            Console.WriteLine("Unesite vrednosti Vašeg niza: ");
            int[] myArray = new int[6]; //definisem duzinu mog niza, ako je duzina 6, onda je najveci index 5, jer krecem od nule, vrednosti samog niza ne moraju biti pravilno rastuce/opadajuce
            for (int index = 0; index < myArray.Length; index++)
            {
                myArray[index] = int.Parse(Console.ReadLine()); //zato što korisnik unosi sam u konzolu, tip podatka je string po defaultu, te ga moramo pretvoriti u tip koji niz može da "drži", a to je int u ovom slučaju, read line će samo pretvoriti pojedinačnu unetu vrednost pročitati i pretvoriti 

            }

            //Vreme je da "pročitamo" one elemente koje zadatak traži da poredimo
            //Indexi: 0, 1, 2, 3, 4, 5

            Console.WriteLine("Treći element niza je:" + myArray[2]);
            Console.WriteLine("Četvrti element niza je:" + myArray[3]);

            //Sada ih samo jednostavno poredim

            if (myArray[3] > myArray[2])
            {
                Console.WriteLine("Veći element je " + myArray[3]);

            }
                else if (myArray[3] < myArray[2]) {
                   Console.WriteLine("Element {0} je veci od elementa {1}", myArray[2], myArray[3]);
                }
                    else
                    {
                         Console.WriteLine("Elementi niza su jednakih vrednosti");
                    }

            Console.ReadLine();

            /*
             Isprobati 3 varijante
            Varijanta A: indeks 2 je 3, indeks 3 je 4
            Varijanta B: indeks 2 je 4, indeks 3 je 3
            Varijanta C: indeks 2 je 4, indeks 3 je 4
             */


            /*Zadatak 3
                Napraviti konzolnu aplikaciju koja svaki elemenat postojećeg niza množi sa 5 (svaki zaseban element puta 5).
                ► Ispisati na konzoli vrednosti elemenata izmenjenog niza.
                ► Kreirati niz od 20 celih brojeva.
             */

            int[] noviNiz = new int[20] {2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36,38,40};
            //idemo klasicnu for petlju za nizove
            for (int index = 0; index < noviNiz.Length; index++)
            {
                noviNiz[index] = noviNiz[index] * 5;
                Console.WriteLine(noviNiz[index]);
            }
            Console.ReadKey();


            //Multidimenzionalni nizovi-matrice

            /*Zadatak 4
                Napraviti konzolnu aplikaciju koja omogućava korisniku unos broja
                redova i kolona matrice, zatim unos vrednosti u matricu i njen ispis na
                konzoli kao na slici.
                */
            Console.WriteLine("Unesi broj redova:");
            int red = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi broj kolona:");
            int kolona=int.Parse(Console.ReadLine());
            
            int[,] matrica = new int[red,kolona];

            for (red = 0; red < matrica.GetLength(0); red++)
            {
                for (kolona = 0; kolona < matrica.GetLength(1); kolona++)//jer citamo prvo sve iz tog reda, tj nulti red je konstantno, a duzina reda je granica
                {
                    Console.Write("matrica[{0},{1}]=", red, kolona);//mora write samo da bi bilo u obliku matrice!!!
                    matrica[red, kolona] = int.Parse(Console.ReadLine());
                }
            }

            for (red = 0; red < matrica.GetLength(0); red++)
            {
                    for (kolona = 0; kolona < matrica.GetLength(1); kolona++)
                    {
                        Console.Write(" " + matrica[red, kolona]);//mora write samo da bi bilo u obliku matrice!!!
                        
                }
            Console.WriteLine();
            }

            Console.ReadKey();


            /*Zadatak 5
             ► Napraviti konzolnu aplikaciju koja ispisuje elemente trodimenzionalnog niza:
                int[, ,] threeDimensional = new int[2,3,4];
             ► Elemente u niz unosi korisnik sa komandne linije.*/

            int[,,] threeDimensional = new int[2, 3, 4]; //[x,y,z]

            //Imamo isto FOR petlje, samo što su sad 3, za svaku "dimenziju" niza, idemo unazad: z, y, x

            //Konvertujem konzolni ispis iz string u int
            Console.WriteLine("Unesite elemente trodimenzionalnog niza:");
            for(int z = 0; z < threeDimensional.GetLength(2); z++)
            {
                for (int y = 0; y < threeDimensional.GetLength(1); y++)
                {
                    for (int x = 0; x < threeDimensional.GetLength(0); x++)
                    {
                        threeDimensional[x, y, z] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            //Ispisujem niz, tj unete vrednosti
            Console.WriteLine("Trodimenzionalni niz:");
            for (int z = 0; z < threeDimensional.GetLength(2); z++)
            {
                for (int y = 0; y < threeDimensional.GetLength(1); y++)
                {
                    for (int x = 0; x < threeDimensional.GetLength(0); x++)
                    {
                        Console.Write(threeDimensional[x, y, z]);
                    }Console.WriteLine();
               
            }Console.WriteLine();
        }Console.ReadKey();




            /*POKUŠAJ: Zadatak 6-sama dodala (Link: https://www.youtube.com/watch?v=Gk-HyiDxkBY&ab_channel=Codewrinkles)
             Računanje sume svih elemenata u matrici, ali tako da korisnik sam unese vrednosti
            */
            /*
            int rows, cols; //suma ce morati biti integer isto

            //sum = 0; NE


            //Konvertovanje ispisa na konzoli koji je string u int
            Console.WriteLine("Unesite red:");
            rows= int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite kolonu:");
            cols = int.Parse(Console.ReadLine());

            int[,] myMatrix = new int[rows, cols];

            for (rows = 0; rows < myMatrix.GetLength(0); rows++)
            {
                for (cols = 0; cols < myMatrix.GetLength(1); cols++)
                {
                    Console.Write("myMatrix[{0},{1}]=", rows, cols);//mora write samo da bi bilo u obliku matrice!!!
                    myMatrix[rows, cols] = int.Parse(Console.ReadLine());
                }

            }

            //Display ili ispis matrice
            for (rows = 0; rows < myMatrix.GetLength(0); rows++)
                {
                    for (cols = 0; cols < myMatrix.GetLength(1); cols++)
                    {
                    Console.Write(" " + myMatrix[rows, cols]);
                }

            Console.WriteLine();
        }

        Console.ReadKey();

            //Prva 2 dela koda su suštinski ista kao 4.zadatak

            //Sada je vreme da postavimo osnove sume redova i kolona
            int[] rowSum = new int[rows];
            int[] colSum = new int[cols];

            //Suma redova
            for (rows = 0; rows < myMatrix.GetLength(0); rows++)
            { 
                rowSum[rows] = 0;//postavljam brojac na nulu, jer je to neutralan broj za sabiranje

                for (cols = 0; cols < myMatrix.GetLength(1); cols++)
                {
                    Console.Write(myMatrix[rows, cols]+" ");
                    rowSum[rows] += myMatrix[rows,cols];
                }
                Console.WriteLine(" " + rowSum[rows]);
            }


            //Suma kolona
            for (rows = 0; rows < myMatrix.GetLength(0); rows++)
            {
                colSum[cols] = 0;//postavljam brojac na nulu, jer je to neutralan broj za sabiranje

                for (cols= 0; cols < myMatrix.GetLength(1); cols++)
                {
                    colSum[cols] += myMatrix[rows, cols];
                }
            }

            Console.Write("The sum of row and column of the matrix :\n");
            for (rows = 0; rows < myMatrix.GetLength(0); rows++)
            {
                for (cols = 0; cols < myMatrix.GetLength(1); cols++)
                {
                    Console.Write(" " + myMatrix[rows, cols]); // Display the matrix elements
                }
                Console.Write(" " + rowSum[rows]); // Display sum of each row
                Console.Write("\n");
            }

            // Display sum of each column separately
            for (cols = 0; cols < myMatrix.GetLength(1); cols++)
            {
                Console.Write(" "+colSum[cols]);
            }
            Console.Write("\n\n");

          Console.WriteLine();

            */



            //REŠENJE SA INTERNETA: https://www.w3resource.com/csharp-exercises/array/csharp-array-exercise-25.php


            int i, j, n; // Declare variables for iteration and matrix size
                    int[,] arr1 = new int[10, 10]; // Declare a 2D array to store the matrix
                    int[] rsum = new int[10]; // Declare an array to store the sum of rows
                    int[] csum = new int[10]; // Declare an array to store the sum of columns

                    Console.Write("\n\nFind sum of row and column of a Matrix:\n");
                    Console.Write("-------------------------------------------\n");

                    Console.Write("Input the size of the square matrix : ");
                    n = Convert.ToInt32(Console.ReadLine()); // Input the size of the square matrix

                    Console.Write("Input elements in the matrix :\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("element - [{0}],[{1}] : ", i, j);
                            arr1[i, j] = Convert.ToInt32(Console.ReadLine()); // Input matrix elements
                        }
                    }

                    Console.Write("The matrix is :\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0}  ", arr1[i, j]); // Display the matrix
                        }
                        Console.Write("\n");
                    }

                    //Calculate sum of rows 
                    for (i = 0; i < n; i++)
                    {
                        rsum[i] = 0; // Initialize sum for each row to zero
                        for (j = 0; j < n; j++)
                        {
                            rsum[i] += arr1[i, j]; // Calculate sum of each row
                        }
                    }

                    // Calculate sum of columns 
                    for (i = 0; i < n; i++)
                    {
                        csum[i] = 0; // Initialize sum for each column to zero
                        for (j = 0; j < n; j++)
                        {
                            csum[i] += arr1[j, i]; // Calculate sum of each column
                        }
                    }

                    Console.Write("The sum of row and column of the matrix :\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0}    ", arr1[i, j]); // Display the matrix elements
                        }
                        Console.Write("{0}    ", rsum[i]); // Display sum of each row
                        Console.Write("\n");
                    }

                    // Display sum of each column separately
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("{0}   ", csum[j]);
                    }
                    Console.Write("\n\n");

                    

                }
    }

}
    
        


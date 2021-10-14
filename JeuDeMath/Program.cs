using System;

namespace JeuDeMath
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choisir le mode de jeu");
            Console.WriteLine("");
            Console.WriteLine("Cliquer sur 1 pour le jeux du plus grand (Niveau plus simple)");
            Console.WriteLine("Cliquer sur 2 pour le jeux des Addition (Niveau moyen)");
            Console.WriteLine("Cliquer sur 3 pour le jeux des moyennes (Niveau Hardcore)");
            int choixDuJeu = Convert.ToInt32(Console.ReadLine());


            if(choixDuJeu == 1)
            {
                ModePlusGrand();
            }
            if (choixDuJeu == 2)
            {
                ModeAddition();
            }
            else if (choixDuJeu == 3)
            {
                ModeMoyenne();
            }
        }
        static void ModeAddition()
        {
            Console.Clear();
            Console.WriteLine("                                                           BIENVENU   ");
            Console.WriteLine("                                                             DANS     ");
            Console.WriteLine("                                                           LE JEUX       ");
            Console.WriteLine("                                                          D'ADDITION ");
            Console.WriteLine("    ");
            Console.WriteLine("                                        Cliquer sur n'importe qu'elle touche pour continuer ");
            Console.ReadLine();
            Console.Clear();


            //Faire un tableau de 3 
            decimal[] tableau = new decimal[3];
            //Choisir 3 chiffres en random 
            Random r = new Random();
            //remplir le tableau avec les 3 chiffres 
            for (int i = 0; i < tableau.Length; i++)
            {

                tableau[i] = r.Next(0, 100);

            }
            //Afficher le tableau
            Console.WriteLine("Quel est le résultat de l'addition de ces 3 nombres ?");
            AfficheLeTableau(tableau);
            Console.WriteLine(" ");

            //Additionner les 3 chiffres ensemble 
            decimal resultatAddition = tableau[0] + tableau[1] + tableau[2];

            //Demander à l'utilisateur le résulat de l'addition 


            int resultatUtilisateur = Convert.ToInt32(Console.ReadLine());

            if (resultatAddition == resultatUtilisateur)
            {
                Console.Clear();
                Console.WriteLine("T'es un monstre!!!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Va falloir bosser les maths");
            }

        }

        static void ModeMoyenne()
        {
            decimal[] tableau = new decimal[3];
            Console.Clear();
            Console.WriteLine("                                                           BIENVENU   ");
            Console.WriteLine("                                                             DANS     ");
            Console.WriteLine("                                                           LE JEUX       ");
            Console.WriteLine("                                                        DES MOYENNES ");
            Console.WriteLine("    ");
            Console.WriteLine("                                        Cliquer sur n'importe qu'elle touche pour continuer ");
            Console.ReadLine();
            Console.Clear();

            Random r = new Random();
            //remplir le tableau avec les 3 chiffres 
            for (int i = 0; i < tableau.Length; i++)
            {

                tableau[i] = r.Next(0, 100);

            }

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Quel est la moyenne du tableau suivant  ? (Il n'y a que 2 chiffres max après la virgule)");
            Console.WriteLine("");
            AfficheLeTableau(tableau);

            decimal moyenneMachine = (tableau[0] + tableau[1] + tableau[2]) / 3;
            //Demander à l'utilisateur la moyenne 
            decimal moyenneUtilisateur = Convert.ToDecimal(Console.ReadLine());

            //Valeur arondie 
            decimal moyenneMachineArondie = Math.Round(moyenneMachine, 2);
            decimal moyenneUtilisateurArondie = Math.Round(moyenneUtilisateur, 2);

            Console.WriteLine("");

            if (moyenneMachineArondie == moyenneUtilisateurArondie)
            {
                Console.WriteLine("T'es super chaud !");
            }
            else
            {
                Console.WriteLine("la prochaine fois peut être :(");
            }
            
            

            

        }
        static void ModePlusGrand()
        {

            Console.Clear();
            Console.WriteLine("                                                           BIENVENU   ");
            Console.WriteLine("                                                             DANS     ");
            Console.WriteLine("                                                           LE JEUX       ");
            Console.WriteLine("                                                        DU PLUS GRAND ");
            Console.WriteLine("    ");
            Console.WriteLine("                                        Cliquer sur n'importe qu'elle touche pour continuer ");
            Console.ReadLine();
            Console.Clear();
            decimal[] tableau = new decimal[3];

            Random r = new Random();

            //remplr le tableau de random entre 1 et 100
            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = r.Next(0, 100);
            }
            Console.WriteLine("");

            Console.WriteLine("Quel est le chiffre le plus grand dans ce tableau: ");
            Console.WriteLine(" ");
            AfficheLeTableau(tableau);

            decimal chiffreLePlusGrandMachine = 0;
            var onTrouveLeChiffre = true;

            for (int i = 0; i < tableau.Length -1 ; i++)
            {
                onTrouveLeChiffre = false;
                if(tableau[i] > tableau[i + 1])
                {
                    onTrouveLeChiffre = true;
                    chiffreLePlusGrandMachine = tableau[i];
                }
                if ( onTrouveLeChiffre == false)
                {
                    chiffreLePlusGrandMachine = tableau[2];
                }
                
            }

            decimal chiffreLePlusGrandUtilisateur = Convert.ToDecimal(Console.ReadLine());

            if(chiffreLePlusGrandMachine == chiffreLePlusGrandUtilisateur)
            {
                Console.WriteLine("Bien vu mon gars ! ");
            }
            else
            {
                Console.WriteLine("Aie toi t'es vraiment mauvais ");
            }




        }
        static void AfficheLeTableau(decimal[] tableau)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.Write(tableau[i] + " | ");
            }
        }
        

    }
}

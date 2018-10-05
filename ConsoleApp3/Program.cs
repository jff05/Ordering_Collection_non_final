using System;
using System.Collections.Generic;

namespace JFF_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création de ma liste de Candidatures

            List<Candidature> maLst = new List<Candidature>();

            Candidature cdt = new Candidature("Amine", 64);
            maLst.Add(cdt);

            cdt = new Candidature("Richard", 654);
            maLst.Add(cdt);

            cdt = new Candidature("Mathieu", 999);
            maLst.Add(cdt);

            cdt = new Candidature("Jean-Luc", 782);
            maLst.Add(cdt);

            cdt = new Candidature("William", 1000);
            maLst.Add(cdt);

            cdt = new Candidature("Richard", 782);
            maLst.Add(cdt);

            cdt = new Candidature("Nicolas", 782);
            maLst.Add(cdt);

            cdt = new Candidature("Mohamed", 654);
            maLst.Add(cdt);


            
            // Affichage de ma list initiale

            string txt = String.Empty;

            txt += "Avant le tri : \nParticipant\tScore \n";

            foreach (Candidature c in maLst)
            {
                txt += c.ToString() + "\n";
            }


            // Triage de ma liste

            // Utilisation d'une méthode non maîtrisée 
            //
            //malst.Sort();



            // Triage incrémental
            bool enOrdre;
            List<Candidature> listTemp = new List<Candidature>();
            Candidature tempCdt = new Candidature("test", 0);
            listTemp.Add(tempCdt);

            // Triage par score descendant
            do
            {
                enOrdre = true;
                
                for (int i = 0 ; i < maLst.Count - 1 ; i++)
                {

                    if (maLst[i].Score < maLst[i+1].Score)
                    {
                       

                        // Inversion des candidatures sur la base du Score non Strictement Inférieur
                        listTemp[0] = maLst[i];
                        maLst[i] = maLst[i + 1];
                        maLst[i + 1] = listTemp[0];
                        enOrdre = false;
                    }
                }

            }while (!enOrdre);

            //// Triage par ordre alphabétique du participant 
            //do
            //{
            //    enOrdre = true;

            //    for (int i = 0; i < maLst.Count - 1; i++)
            //    {

            //        if (maLst[i].Score < maLst[i + 1].Score)
            //        {
            //            List<Candidature> listTemp = new List<Candidature>();
            //            Candidature tempCdt = new Candidature("test", 0);
            //            listTemp.Add(tempCdt);

            //            // Inversion des candidatures sur la base du Score non Strictement Inférieur
            //            listTemp[0] = maLst[i];
            //            maLst[i] = maLst[i + 1];
            //            maLst[i + 1] = listTemp[0];
            //            enOrdre = false;
            //        }
            //    }

            //} while (!enOrdre);


            // Affichage de ma liste après triage

            txt += "\nAprès un tri avec Sort : \nParticipant\t\tScore \n";
        
            foreach (Candidature c in maLst)
            {
                txt += c.ToString() + "\n";
            }

            Console.WriteLine(txt);
        }
    }
}

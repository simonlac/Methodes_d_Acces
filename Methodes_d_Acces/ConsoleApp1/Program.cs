using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        // Définir les attributs publics. 
        public string nom;
        public string prenom;
        // Définir l'attribut privé age.
        int age;
        // Définir la propriété Age.
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        // Définir les méthodes d'accès
        public int GetAge ()
        {
            return age;
        }
        
        public void SetAge(int value)
        {
            age = value;
        }
        // Définir le constructeur de la classe Person.
        public Person()
        {
            Console.WriteLine("Un objet Person vient d'être créé.");
        }

        // Surcharger le constructeur.
        public Person(string p_nom, string p_prenom)
        {
            this.nom = p_nom;
            this.prenom = p_prenom;

            Console.WriteLine
              ("Un objet Person se nommant " + this.nom + " "+ this.prenom 
              + " vient d'être créé. ");
        }
        // Définir le destructeur de la classe Person.
        ~Person()
        { 
            Console.WriteLine("Un objet Person est détruit");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Instancier des objets. 
            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person("Hasna", "Hocini");
            // Modifier les valeurs des attributs publics de l'objet p1.
            p1.nom = "Béland";
            p1.prenom = "Sandrine";
            // Accéder l'attribut privé age de l'objet p1 à travers l'accès
            // à la propriété publique Age. 
            p1.Age = 20;
            // Modifier l'attribut privé age
            // par l'entremise de la méthode d'accès SetAge.
            p1.SetAge(25);
            // Obtenir la valeur de l'atribut privé age
            // par l'entremise de la méthode d'accès GetAge. 
            Console.WriteLine(p1.GetAge());
            // Appeler les destructeurs des objets créés.
            Console.ReadLine();
        }
    }
}

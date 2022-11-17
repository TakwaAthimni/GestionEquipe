// See https://aka.ms/new-console-template for more information
using Eq.ApplicationCore.Domain;
using Infrastruct;

Console.WriteLine("Hello, World!");
GEContext ctx = new GEContext();
//Membre m = new Membre {identifiant = 1, Datenaissance = new DateTime(1965, 01, 01), nom = "abidi", prenom = "wael" };
//ctx.Membres.Add(m);
//Console.WriteLine("insertion avec success");
//Persistance
//ctx.SaveChanges();
//Affichage 
foreach (Membre f in ctx.Membres)
    Console.WriteLine("identifiant: " + f.identifiant + "nom  " + f.nom + f.identifiant + "prenom  " + f.prenom);

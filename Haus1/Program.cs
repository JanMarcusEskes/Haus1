using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haus1
{
  class Program
  {
    static void Main(string[] args)
    {
      //a,b,c = Grundstück       d,e = Haus
      double a, b, c, d, e;
      string eingabe;

      //Eingabe der Werte
      Console.WriteLine("Bitte geben Sie ALLE Werte in Metern (m) ein!");
      Console.WriteLine("Bitte geben Sie Seite a ein");
      if (Double.TryParse(eingabe = Console.ReadLine(), out a) == true) a = double.Parse(eingabe);
      else { Console.WriteLine("Es wurde keine gültige Zahl eingegeben"); Console.ReadLine(); return; }
      Console.WriteLine("Bitte geben Sie Seite b ein");
      if (Double.TryParse(eingabe = Console.ReadLine(), out b) == true) b = double.Parse(eingabe);
      else { Console.WriteLine("Es wurde keine gültige Zahl eingegeben"); Console.ReadLine(); return; }
      Console.WriteLine("Bitte geben Sie Seite c ein");
      if (Double.TryParse(eingabe = Console.ReadLine(), out c) == true) c = double.Parse(eingabe);
      else { Console.WriteLine("Es wurde keine gültige Zahl eingegeben"); Console.ReadLine(); return; };
      Console.WriteLine("Bitte geben Sie Seite d ein");
      if (Double.TryParse(eingabe = Console.ReadLine(), out d) == true) d = double.Parse(eingabe);
      else { Console.WriteLine("Es wurde keine gültige Zahl eingegeben"); Console.ReadLine(); return; }
      Console.WriteLine("Bitte geben Sie Seite e ein");
      if (Double.TryParse(eingabe = Console.ReadLine(), out e) == true) e = double.Parse(eingabe);
      else { Console.WriteLine("Es wurde keine gültige Zahl eingegeben"); Console.ReadLine(); return; }

      //Errechnen von f
      double f = Math.Sqrt((c - a) * (c - a) + b * b);

      //Errechnen der Hausfläche
      double hausfläche = e * d;

      //Errechnen der Rasenfläche
      double rasen = (a * b) + ((c - a) * b * 0.5) - hausfläche;

      //Errechnen des Zauns
      double zaun = a + c + f;

      //Prüfen ob 3m bestimmung eingehalten wurde
      if (b < e + 6) { Console.WriteLine("Sie halten die 3m Abstand zum Nachbargrundstück nicht ein!"); Console.WriteLine("Ihr Projekt ist damit nicht zulässig!"); Console.ReadLine(); return; }
      if (a < d + 6) { Console.WriteLine("Sie halten die 3m Abstand zum Nachbargrundstück nicht ein!"); Console.WriteLine("Ihr Projekt ist damit nicht zulässig!"); Console.ReadLine(); return; }

      //Ausgabe
      Console.Clear();
      Console.WriteLine("Die Ergebnisse sind:");
      Console.WriteLine("");
      Console.WriteLine("Die Rasenfläche beträgt : " + rasen + " m²");
      Console.WriteLine("Die Zaunlänge beträgt   : " + zaun + " m");
      Console.ReadLine();
      return;
    }
  }
}

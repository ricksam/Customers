using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysZoo
{
  public class AnimalDay
  {
    string[] animals = new string[]{
      "Ariranha",
      "Alce",
      "Anta",
      "Águia",
      "Albatroz",
      "Arara",
      "Avestruz",
      "Baleia",
      "Baleia Orca",
      "Baleia Azul",
      "Beija-Flor",
      "Búfalo",
      "Bicho-Preguiça",
      "Bem-Te-Vi",
      "Coelho",
      "Cobra",
      "Camaleão",
      "Cão",
      "Cachorro",
      "Cadela",
      "Chimpanzé",
      "Crocodilo",
      "Coala",
      "Caranguejo",
      "Camelo",
      "Cavalo",
      "Cisne",
      "Chacal",
      "Cárgado",
      "Castor",
      "Dromedário",
      "Dourado (peixe)",
      "Dragão de Comodo",
      "Ema",
      "Emu",
      "Elefante",
      "Elefoa",
      "Esquilo",
      "Foca",
      "Gavião",
      "Gaivota",
      "Gambá",
      "Galinha",
      "Galo",
      "Golfinho",
      "Gato",
      "Garoupa",
      "Hipopótamo",
      "Hiena",
      "Hamster",
      "Iguana",
      "Jabuti",
      "Jacaré",
      "Jaguatirica",
      "Jaburu",
      "Lontra",
      "Lhama",
      "Lula",
      "Lobo",
      "Leopardo",
      "Lebre",
      "Leão",
      "Lambari",
      "Lagarto",
      "Lagartixa",
      "Macaco",
      "Marreco",
      "Morsa",
      "Mico",
      "Namorado (peixe)",
      "Naja (cobra)",
      "Ovelha",
      "Ostra",
      "Onça",
      "Orangotango",
      "Ornitorrinco",
      "Pato",
      "Periquito",
      "Peixe",
      "Pombo",
      "Porco",
      "Panda",
      "Polvo",
      "Papagaio",
      "Pavão",
      "Quero-Quero",
      "Rato",
      "Ratazana",
      "Raposa",
      "Rinoceronte",
      "Rã",
      "Sapo",
      "Sapa",
      "Suricato",
      "Salmão",
      "Sardinha",
      "Tatu",
      "Tamanduá",
      "Tigre",
      "Touro",
      "Tico-Tico",
      "Urso",
      "Urubu",
      "Uirapuru",
      "Veado",
      "Vaca",
      "Zebra"};

    public string getAnimal()
    {
      return getAnimal(DateTime.Now.Day, DateTime.Now.Month, Convert.ToInt32(DateTime.Now.Year.ToString("0000").Substring(2, 2)));
    }

    public string getAnimal(int day, int month, int year)
    {
      /*int max = 31 + 12 + 99;
      int num = day + month + year;
      int tot = animals.Length;

      int idx = (tot * num / max) - 1;

      if (idx < 0 || idx > tot)
      {
        return animals[0];
      }
      else
      {
        return animals[idx];
      }*/
      int tot = day * month * year;
      int idx = Convert.ToInt32(tot.ToString("0000").Substring(2, 2));
      return animals[idx];
    }
  }
}
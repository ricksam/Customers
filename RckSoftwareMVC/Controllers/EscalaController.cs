using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
    public class EscalaController : Controller
    {
        //
        // GET: /Escala/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Irmas(List<string> Nomes)
        {
            if (Nomes == null)
            {
                Nomes = new List<string>();
                if (Session["Irmas"] != null)
                {
                    Nomes = ((List<string>)Session["Irmas"]);
                }
                else
                {
                    /*Nomes.Add("Ana");
                    Nomes.Add("Beatriz");
                    Nomes.Add("Carla");
                    Nomes.Add("Debora");
                    Nomes.Add("Eliane");
                    Nomes.Add("Fabiana");
                    Nomes.Add("Gabriela");
                    Nomes.Add("Heloisa");
                    Nomes.Add("Ines");
                    Nomes.Add("Jaqueline");
                    Nomes.Add("Keila");
                    Nomes.Add("Laura");
                    Nomes.Add("Maria");
                    Nomes.Add("Neuza");
                    Nomes.Add("Olivia");
                    Nomes.Add("Patrícia");
                    Nomes.Add("Quitéria");
                    Nomes.Add("Raquel");
                    Nomes.Add("Sabrina");
                    Nomes.Add("Tatiane");
                    Nomes.Add("Úrsula");
                    Nomes.Add("Vânia");
                    Nomes.Add("Yasmin");
                    Nomes.Add("Xerazard");
                    Nomes.Add("Wilma");
                    Nomes.Add("Zileide");*/
                }
            }

            Session["Irmas"] = Nomes;

            return View("Irmas", Nomes);
        }

        public ActionResult RemoveIrma(string id, List<string> Nomes)
        {
            for (int i = 0; i < Nomes.Count; i++)
            {
                if (Nomes[i] == id)
                {
                    Nomes.RemoveAt(i);
                    i--;
                }
            }

            return View("Irmas", Nomes);
        }

        [HttpPost]
        public ActionResult Gerar(ModelEscala model)
        {
            Session["Irmas"] = model.Nomes;
            Session["DataDe"] = model.DataDe;
            Session["DataAte"] = model.DataAte;
            Session["PermiteDuas"] = model.PermiteDuas;
            Session["DiaSequencial"] = model.DiaSequencial;
            Session["dom"] = model.dom;
            Session["seg"] = model.seg;
            Session["ter"] = model.ter;
            Session["qua"] = model.qua;
            Session["qui"] = model.qui;
            Session["sex"] = model.sex;
            Session["sab"] = model.sab;

            for (int i = 0; i < model.Nomes.Count; i++)
            {
                if (string.IsNullOrEmpty(model.Nomes[i]))
                {
                    model.Nomes.RemoveAt(i);
                    i--;
                }
            }

            // Gera lista datas
            Escala escala = new Escala();
            DateTime dtRef = model.DataDe;
            while (dtRef <= model.DataAte)
            {
                if (model.ListDayOfWeek().Contains(dtRef.DayOfWeek))
                {
                    escala.AddDay(new DiaEscala() { Data = dtRef });
                }
                dtRef = dtRef.AddDays(1);
            }

            // Gera lista/conjunto das irmas com par e a individual ( calcula o total necessario )
            List<Conjunto> conjuntoPar = new List<Conjunto>();
            List<Conjunto> conjuntoMeioPar = new List<Conjunto>();
            List<Conjunto> conjuntoImpar = new List<Conjunto>();
            List<Conjunto> conjuntoMeioImpar = new List<Conjunto>();

            if (model.PermiteDuas && (model.Nomes.Count - 1) > model.ListDayOfWeek().Count * 2)
            {
                for (int i = 0; i < model.Nomes.Count / 2; i++)
                {
                    conjuntoPar.Add(new Conjunto() { MeiaHora = model.Nomes[i * 2], Culto = model.Nomes[i * 2 + 1] });
                }

                // se é impar
                if (model.Nomes.Count % 2 == 1)
                {
                    string NomeImpar = model.Nomes[model.Nomes.Count - 1];
                    List<string> NomesParReverse = new List<string>();
                    NomesParReverse.AddRange(model.Nomes);
                    NomesParReverse.RemoveAt(model.Nomes.Count - 1);
                    NomesParReverse.Reverse();

                    foreach (var item in NomesParReverse)
                    {
                        conjuntoImpar.Add(new Conjunto() { MeiaHora = NomeImpar, Culto = item });
                    }
                }
            }
            else
            {
                for (int i = 0; i < model.Nomes.Count; i++)
                {
                    conjuntoPar.Add(new Conjunto() { MeiaHora = model.Nomes[i], Culto = model.Nomes[i] });
                }
            }

            // Adiciona o grupo por dia da semana (se mes inicial é junho então começa pelo conjunto impar)
            int idxPar = 0;
            int idxImpar = 0;
            //string FirstName = "";
            if (model.DataDe.Month >= 6)
            {
                idxPar = conjuntoPar.Count;
            }

            escala.dayOfWeeks = model.ListDayOfWeek();


            if (model.DiaSequencial)
            {
                IOrderedEnumerable<DateTime> query = escala.ListaDatas().OrderBy(o => o.Date);

                query.ToList().ForEach(dia =>
                {
                    if (idxPar >= conjuntoPar.Count && conjuntoImpar.Count != 0)
                    {
                        escala.AddConjunto(dia, conjuntoImpar[idxImpar]);

                        idxImpar++;
                        if (idxImpar >= conjuntoImpar.Count)
                        {
                            idxImpar = 0;
                        }
                        idxPar = 0;
                    }
                    else {
                        if (idxPar >= conjuntoPar.Count)
                        {
                            idxPar = 0;
                        }

                        escala.AddConjunto(dia, conjuntoPar[idxPar]);
                        idxPar++;
                    }

                    /*if (idxPar >= conjuntoPar.Count && conjuntoImpar.Count != 0)
                    {
                        if (escala.Tentativas != 0)
                        {
                            escala.AddConjunto(dia, conjuntoMeioImpar[idxImpar]);
                        }
                        else
                        {
                            escala.AddConjunto(dia, conjuntoImpar[idxImpar]);
                        }

                        idxImpar++;
                        if (idxImpar >= conjuntoImpar.Count)
                        {
                            idxImpar = 0;
                        }
                        idxPar = 0;

                    }
                    else
                    {
                        if (idxPar >= conjuntoPar.Count)
                        {
                            idxPar = 0;
                        }

                        if (escala.Tentativas != 0)
                        {
                            escala.AddConjunto(dia, conjuntoMeioPar[idxPar]);
                        }
                        else
                        {
                            escala.AddConjunto(dia, conjuntoPar[idxPar]);
                        }

                        idxPar++;
                    }*/

                    
                });
            }
            else
            {
                
                escala.Tentativas = 0;
                int positionPar = 0;
                int positionImpar = 0;
                Random random = new Random();

                do
                {
                    if (escala.Tentativas > 200)
                    {
                        break;
                    }

                    //bool odesc = false;

                    foreach (var item in model.ListDayOfWeek())
                    {
                        if (escala.Tentativas > 0)
                        {
                            System.Threading.Thread.Sleep(4);
                            positionPar = random.Next(0, conjuntoPar.Count - 1);
                            if (conjuntoImpar.Count != 0)
                            {
                                positionImpar = random.Next(0, conjuntoImpar.Count - 1);
                            }

                            conjuntoMeioPar.Clear();
                            for (int i = positionPar; i < conjuntoPar.Count; i++)
                            {
                                conjuntoMeioPar.Add(conjuntoPar[i]);
                            }
                            for (int i = 0; i < positionPar; i++)
                            {
                                conjuntoMeioPar.Add(conjuntoPar[i]);
                            }

                            conjuntoMeioImpar.Clear();
                            for (int i = positionImpar; i < conjuntoImpar.Count; i++)
                            {
                                conjuntoMeioImpar.Add(conjuntoImpar[i]);
                            }
                            for (int i = 0; i < positionImpar; i++)
                            {
                                conjuntoMeioImpar.Add(conjuntoImpar[i]);
                            }
                        }

                        IOrderedEnumerable<DateTime> query = escala.ListaDatas().Where(q => q.DayOfWeek == item).OrderBy(o => o.Date);

                        //odesc = !odesc;

                        query.ToList().ForEach(dia =>
                        {
                            if (idxPar >= conjuntoPar.Count && conjuntoImpar.Count != 0)
                            {
                                if (escala.Tentativas != 0)
                                {
                                    escala.AddConjunto(dia, conjuntoMeioImpar[idxImpar]);
                                }
                                else
                                {
                                    escala.AddConjunto(dia, conjuntoImpar[idxImpar]);
                                }

                                idxImpar++;
                                if (idxImpar >= conjuntoImpar.Count)
                                {
                                    idxImpar = 0;
                                }
                                idxPar = 0;

                            }
                            else
                            {
                                if (idxPar >= conjuntoPar.Count)
                                {
                                    idxPar = 0;
                                }

                                if (escala.Tentativas != 0)
                                {
                                    escala.AddConjunto(dia, conjuntoMeioPar[idxPar]);
                                }
                                else
                                {
                                    escala.AddConjunto(dia, conjuntoPar[idxPar]);
                                }

                                idxPar++;
                            }
                        });
                    }

                    escala.Tentativas++;

                } while (escala.DatasProximas(conjuntoPar.Count, escala.Tentativas));

                // Ordena por os conjuntos por datas invertendo as posições pares
                foreach (var itemPar in conjuntoPar)
                {
                    int idx = 0;
                    escala.ListaEscala().Where(q => q.Conjunto.MeiaHora == itemPar.MeiaHora).ToList().ForEach(f =>
                    {
                        if (idx % 2 == 1)
                        {
                            escala.Inverter(f.Data);
                        }
                        idx++;
                    });
                }

                foreach (var itemImpar in conjuntoImpar)
                {
                    int idx = 0;
                    escala.ListaEscala().Where(q => q.Conjunto.MeiaHora == itemImpar.MeiaHora).ToList().ForEach(f =>
                    {
                        if (idx % 2 == 1)
                        {
                            escala.Inverter(f.Data);
                        }
                        idx++;
                    });
                    break;
                }
            }


            return View("Escala", escala);
        }

        public ActionResult Mes(Escala escala, int Mes)
        {
            EscalaMes escalaMes = new EscalaMes();

            escalaMes.DayOfWeeks = escala.dayOfWeeks;
            escalaMes.DiasEscala = escala.ListaEscala().Where(q => q.Data.Month == Mes).ToList();

            escalaMes.NomeMes = escalaMes.DiasEscala.FirstOrDefault().Data.ToString("MMMM");

            foreach (var item in escalaMes.DayOfWeeks)
            {
                if (item != escalaMes.DiasEscala.FirstOrDefault().Data.DayOfWeek)
                {
                    escalaMes.OffSet++;
                }
                else
                {
                    break;
                }
            }

            return View("Mes", escalaMes);
        }
    }

    public class ModelEscala
    {
        public List<string> Nomes { get; set; }
        public DateTime DataDe { get; set; }
        public DateTime DataAte { get; set; }
        public bool PermiteDuas { get; set; }
        public bool DiaSequencial { get; set; }
        public bool dom { get; set; }
        public bool seg { get; set; }
        public bool ter { get; set; }
        public bool qua { get; set; }
        public bool qui { get; set; }
        public bool sex { get; set; }
        public bool sab { get; set; }
        public List<DayOfWeek> ListDayOfWeek()
        {
            List<DayOfWeek> list = new List<DayOfWeek>();
            if (dom)
            {
                list.Add(DayOfWeek.Sunday);
            }

            if (seg)
            {
                list.Add(DayOfWeek.Monday);
            }

            if (ter)
            {
                list.Add(DayOfWeek.Tuesday);
            }

            if (qua)
            {
                list.Add(DayOfWeek.Wednesday);
            }

            if (qui)
            {
                list.Add(DayOfWeek.Thursday);
            }

            if (sex)
            {
                list.Add(DayOfWeek.Friday);
            }

            if (sab)
            {
                list.Add(DayOfWeek.Saturday);
            }

            return list;
        }
    }

    public class EscalaMes
    {
        public string NomeMes = "";
        public int OffSet = 0;
        public List<DayOfWeek> DayOfWeeks = new List<DayOfWeek>();
        public List<DiaEscala> DiasEscala = new List<DiaEscala>();
    }

    public class Escala
    {
        public int Tentativas = 0;
        public List<DayOfWeek> dayOfWeeks = new List<DayOfWeek>();
        List<DiaEscala> diasEscala = new List<DiaEscala>();
        public void AddDay(DiaEscala dia)
        {
            diasEscala.Add(dia);
        }

        public void AddConjunto(DateTime Dia, Conjunto conjunto)
        {
            foreach (var item in diasEscala)
            {
                if (item.Data == Dia)
                {
                    item.Conjunto = new Conjunto()
                    {
                        Culto = conjunto.Culto,
                        MeiaHora = conjunto.MeiaHora
                    };
                    break;
                }
            }
        }

        public void Inverter(DateTime Dia)
        {
            foreach (var item in diasEscala)
            {
                if (item.Data == Dia)
                {
                    item.Conjunto.Inverter();
                    break;
                }
            }
        }

        public List<DateTime> ListaDatas()
        {
            return diasEscala.Select(s => s.Data).ToList();
        }

        public List<DiaEscala> ListaEscala()
        {
            return diasEscala;
        }

        public bool DatasProximas(int qtde, int tentativa)
        {
            bool Result = false;
            DateTime dtRef = DateTime.MinValue;
            string lastNome = "";

            string log = "";

            qtde = qtde - 1;
            if (tentativa < 100)
            {
                if (qtde > 7)
                {
                    qtde = 7;
                }
            }
            else if (tentativa < 150)
            {
                if (qtde > 3)
                {
                    qtde = 3;
                }
            }
            else if (tentativa < 180)
            {
                if (qtde > 2)
                {
                    qtde = 2;
                }
            }
            else
            {
                qtde = 1;
            }

            var listaPronta = diasEscala.OrderBy(o => o.Conjunto.MeiaHora).ThenBy(o => o.Data).ToList();
            listaPronta.ForEach(f =>
                {
                    if (lastNome != f.Conjunto.MeiaHora)
                    {
                        dtRef = DateTime.MinValue;
                    }
                    lastNome = f.Conjunto.MeiaHora;
                    double totalDays = Math.Abs(f.Data.Subtract(dtRef).TotalDays);
                    Result |= ((int)totalDays < qtde);
                    dtRef = f.Data;
                    log += f + " " + Result + "\r\n";
                });


            /*foreach (var item in listaPronta)
            {
                log += item+"\r\n";
            }*/

            return Result;
        }
    }

    public class DiaEscala
    {
        public DateTime Data { get; set; }
        public Conjunto Conjunto { get; set; }
        public override string ToString()
        {
            return string.Format("{0}: {1} - {2}", Data.ToString(), Conjunto.MeiaHora, Conjunto.Culto);
        }
    }

    public class Conjunto
    {
        public string MeiaHora { get; set; }
        public string Culto { get; set; }
        public void Inverter()
        {
            string s = this.MeiaHora;
            this.MeiaHora = this.Culto;
            this.Culto = s;
        }
    }
}

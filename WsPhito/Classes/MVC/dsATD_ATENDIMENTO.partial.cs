using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace WsPhito
{
  partial class dsATD_ATENDIMENTO
  {
    public string Lastsearch { get; set; }

    #region public ATD_ATENDIMENTO[] Search(string s)
    public ATD_ATENDIMENTO[] Search(string s)
    {
      int nr_res = 5;

      if (s == Lastsearch)
      { nr_res = 100; }
      else
      { Lastsearch = s; }

      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add("%" + s + "%");
      return GetList(
          @"
            SELECT * FROM ATD_ATENDIMENTO 
            WHERE 
              ATD_ABERTURA LIKE {0}
              OR ATD_LOJA LIKE {0}
              OR ATD_ASSUNTO LIKE {0}
              OR ATD_GUICHE LIKE {0}
              OR ATD_SENHA LIKE {0}
              OR ATD_PREFERENCIAL LIKE {0}
              OR ATD_INICIO LIKE {0}
              OR ATD_FIM LIKE {0}
              OR ATD_CONCLUIDO LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public override LockedField[] GetLockedFields(ATD_ATENDIMENTO Tab)
    public override LockedField[] GetLockedFields(ATD_ATENDIMENTO Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();
            
      if (string.IsNullOrEmpty(Tab.ATD_LOJA))
      { LockedFields.Add(new LockedField("ATD_LOJA", " - Informe o campo ATD_LOJA")); }

      if (string.IsNullOrEmpty(Tab.ATD_ASSUNTO))
      { LockedFields.Add(new LockedField("ATD_ASSUNTO", " - Informe o campo ATD_ASSUNTO")); }
      
      return LockedFields.ToArray();
    }
    #endregion

    #region public Assunto[] GetListAssunto(string loja)
    public Assunto[] GetListAssunto(string loja) 
    {
      string sql = string.Format(
              @"SELECT ATD_ASSUNTO, COUNT(ATD_CODIGO) AS QTDE
                FROM ATD_ATENDIMENTO
                WHERE ATD_LOJA = {0} AND ATD_FIM IS NULL AND ATD_INICIO IS NULL 
                GROUP BY ATD_ASSUNTO", cnn.dbu.Quoted(loja));

      lib.Database.Drivers.DataSource ds = new lib.Database.Drivers.DataSource(cnn.GetDataTable(sql));

      ds.First();

      List<Assunto> list = new List<Assunto>();
      while (!ds.Eof())
      {
        Assunto a = new Assunto();
        a.Descricao = ds.GetField("ATD_ASSUNTO").ToString(); ;
        a.Qtde = ds.GetField("QTDE").ToInt();
        list.Add(a);
        ds.Next();
      }

      return list.ToArray();
    }
    #endregion

    #region public Tempo GetTempoEspera()
    public Tempo GetTempoEspera() 
    {
      string sql =
        @"
          SELECT 
            AVG(DATEPART(HOUR,ATD_INICIO - ATD_ABERTURA)) AS TOTAL_HORAS,
            AVG(DATEPART(MINUTE,ATD_INICIO - ATD_ABERTURA)) AS TOTAL_MINUTOS
          FROM ATD_ATENDIMENTO
          WHERE 
            ATD_INICIO IS NOT NULL AND 
            CAST(ATD_ABERTURA AS DATE) = CAST(GETDATE() AS DATE)";

      lib.Database.Drivers.DataSource ds = new lib.Database.Drivers.DataSource(this.cnn.GetDataTable(sql));
      if (ds.Count != 0) 
      {
        Tempo t = new Tempo();
        t.TotalHoras = ds.GetField("TOTAL_HORAS").ToInt();
        t.TotalMinutos = ds.GetField("TOTAL_MINUTOS").ToInt();
        return t;
      }

      return new Tempo();
    }
    #endregion

    #region public ATD_ATENDIMENTO GetNext(string loja, string assunto)
    public ATD_ATENDIMENTO GetNext(string loja, string assunto) 
    {
      cnn.QueryParam.Add(loja);
      cnn.QueryParam.Add(assunto);

      return Get(@"SELECT *
                FROM ATD_ATENDIMENTO
                WHERE ATD_LOJA = {0} AND ATD_ASSUNTO = {1} AND ATD_FIM IS NULL AND ATD_INICIO IS NULL
                ORDER BY ATD_PREFERENCIAL DESC, ATD_CODIGO");
    }
    #endregion

    #region public ATD_ATENDIMENTO[] GetListNext(string loja)
    public ATD_ATENDIMENTO[] GetListIniciados(string loja) 
    {
      cnn.QueryParam.Add(loja);
      return GetList(
        @"  SELECT * FROM ATD_ATENDIMENTO 
            WHERE ATD_LOJA = {0} AND ATD_INICIO IS NOT NULL 
            ORDER BY ATD_INICIO DESC", 100);
    }
    #endregion

    #region public ATD_ATENDIMENTO[] GetListNext(string loja)
    public ATD_ATENDIMENTO[] GetListRejeitados(string loja)
    {
      cnn.QueryParam.Add(loja);
      cnn.QueryParam.Add(DateTime.Now.ToString("dd/MM/yyyy"));
      return GetList(
        @"  SET DATEFORMAT DMY
            SELECT * FROM ATD_ATENDIMENTO 
            WHERE ATD_LOJA = {0} AND ATD_FIM IS NOT NULL AND ATD_CONCLUIDO = 0 AND CAST(ATD_ABERTURA AS DATE) = {1}
            ORDER BY ATD_FIM", 100);
    }
    #endregion
  }
}


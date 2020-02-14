using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public delegate void StatusSZO_Event(string msg);

namespace SysZoo
{
  public class DadosSZO
  {
    public DadosSZO(string Versao) 
    {
      this.Versao = Versao;
      db = Utilities.GetDatabase();
      SZO_CFG_CONFIG Config = (new dsSZO_CFG_CONFIG(db)).Get();
      Identificacao = Config.CFG_IDENTIFICACAO;
      
      AtualizaCadastros();
      
      Processo = new System.Threading.Thread(new System.Threading.ThreadStart(ProcessaRegistros));
      Processo.Start();
    }

    lib.Entity.SQLite db = null;
    string Identificacao = "";
    string Versao = "";
    public bool PararProcesso = false;
    public bool PausarProcesso = false;
    //public bool SincronizaCadastros = false;
    System.Threading.Thread Processo = null;
    public StatusSZO_Event StatusSZO { get; set; }

    private void OnStatusSZO(string msg) 
    {
      if (StatusSZO != null)
      { StatusSZO(msg); }
    }

    private void EnviaFormas() 
    {
      if (PararProcesso || PausarProcesso)
      { return; }

      dsSZO_FPG_FORMA_PAGAMENTO ds = new dsSZO_FPG_FORMA_PAGAMENTO(db);
      SZO_FPG_FORMA_PAGAMENTO[] list = ds.List_NaoSincronizado();
      
      OnStatusSZO(string.Format("Enviando Formas:{0}", list.Length));
      for (int i = 0; i < list.Length; i++)
      {
        OnStatusSZO(string.Format("Enviando Formas:{0} de {1}", i + 1, list.Length));
        if (PararProcesso || PausarProcesso)
        { break; }
        if (ServerSZO.EnviaFormaPagamento(Identificacao, list[i]))
        { ds.MarcaSincronizado(list[i].FPG_CODIGO); }
      }
    }

    private void EnviaIngressos()
    {
      if (PararProcesso || PausarProcesso)
      { return; }

      dsSZO_CTK_CADASTRO_TICKETS ds = new dsSZO_CTK_CADASTRO_TICKETS(db);
      SZO_CTK_CADASTRO_TICKETS[] list = ds.List_NaoSincronizado();

      OnStatusSZO(string.Format("Enviando Ingressos:{0}", list.Length));
      for (int i = 0; i < list.Length; i++)
      {
        OnStatusSZO(string.Format("Enviando Ingressos:{0} de {1}", i + 1, list.Length));
        if (PararProcesso || PausarProcesso)
        { break; }
        if (ServerSZO.EnviaIngresso(Identificacao, list[i]))
        { ds.MarcaSincronizado(list[i].CTK_CODIGO); }
      }
    }

    private void EnviaOperadores()
    {
      if (PararProcesso || PausarProcesso)
      { return; }

      dsSZO_OPR_OPERADORES ds = new dsSZO_OPR_OPERADORES(db);
      SZO_OPR_OPERADORES[] list = ds.List_NaoSincronizado();

      OnStatusSZO(string.Format("Enviando Operadores:{0}", list.Length));
      for (int i = 0; i < list.Length; i++)
      {
        OnStatusSZO(string.Format("Enviando Operadores:{0} de {1}", i + 1, list.Length));
        if (PararProcesso || PausarProcesso)
        { break; }
        if (ServerSZO.EnviaOperador(Identificacao, list[i]))
        { ds.MarcaSincronizado(list[i].OPR_CODIGO); }
      }
    }

    private void EnviaVendas()
    {
      if (PararProcesso || PausarProcesso)
      { return; }

      dsSZO_VDA_VENDA ds = new dsSZO_VDA_VENDA(db);
      SZO_VDA_VENDA[] list = ds.List_NaoSincronizado();

      OnStatusSZO(string.Format("Enviando Vendas:{0}", list.Length));
      for (int i = 0; i < list.Length; i++)
      {
        OnStatusSZO(string.Format("Enviando Vendas:{0} de {1}", i + 1, list.Length));
        if (PararProcesso || PausarProcesso)
        { break; }
        if (ServerSZO.EnviaVenda(Identificacao, list[i]))
        { ds.MarcaSincronizado(list[i].VDA_CODIGO); }
      }
    }

    private void EnviaItens()
    {
      if (PararProcesso || PausarProcesso)
      { return; }

      dsSZO_VTK_VENDA_TICKETS ds = new dsSZO_VTK_VENDA_TICKETS(db);
      SZO_VTK_VENDA_TICKETS[] list = ds.List_NaoSincronizado();

      OnStatusSZO(string.Format("Enviando Itens:{0}", list.Length));
      for (int i = 0; i < list.Length; i++)
      {
        OnStatusSZO(string.Format("Enviando Itens:{0} de {1}", i + 1, list.Length));
        if (PararProcesso || PausarProcesso)
        { break; }
        if (ServerSZO.EnviaItem(Identificacao, list[i]))
        { ds.MarcaSincronizado(list[i].VTK_CODIGO); }
      }
    }

    private void EnviaPagamentos()
    {
      if (PararProcesso || PausarProcesso)
      { return; }

      dsSZO_PGT_PAGAMENTO ds = new dsSZO_PGT_PAGAMENTO(db);
      SZO_PGT_PAGAMENTO[] list = ds.List_NaoSincronizado();

      OnStatusSZO(string.Format("Enviando Pagamentos:{0}", list.Length));
      for (int i = 0; i < list.Length; i++)
      {
        OnStatusSZO(string.Format("Enviando Pagamentos:{0} de {1}", i + 1, list.Length));
        if (PararProcesso || PausarProcesso)
        { break; }
        if (ServerSZO.EnviaPagamento(Identificacao, list[i]))
        { ds.MarcaSincronizado(list[i].PGT_CODIGO); }
      }
    }

    private void EnviaMovimentoCaixa()
    {
      if (PararProcesso || PausarProcesso)
      { return; }

      dsSZO_MCX_MOVIMENTO_CAIXA ds = new dsSZO_MCX_MOVIMENTO_CAIXA(db);
      SZO_MCX_MOVIMENTO_CAIXA[] list = ds.List_NaoSincronizado();

      OnStatusSZO(string.Format("Enviando Movimentos de Caixa:{0}", list.Length));
      for (int i = 0; i < list.Length; i++)
      {
        OnStatusSZO(string.Format("Enviando Movimentos de Caixa:{0} de {1}", i + 1, list.Length));
        if (PararProcesso || PausarProcesso)
        { break; }
        if (ServerSZO.EnviaMovimentoCaixa(Identificacao, list[i]))
        { ds.MarcaSincronizado(list[i].MCX_CODIGO); }
      }
    }

    private void RecebeFormas() 
    {
      //if (PararProcesso || PausarProcesso)
      //{ return; }

      dsSZO_FPG_FORMA_PAGAMENTO ds = new dsSZO_FPG_FORMA_PAGAMENTO(db);
      SZO_FPG_FORMA_PAGAMENTO[] list = ServerSZO.RetornaFormasPagamento(Identificacao, ds.LastTimeStamp().ToString("yyyy-MM-dd HH:mm:ss"));

      OnStatusSZO(string.Format("Recebendo Formas de Pagamentos:{0}", list.Length));

      if (list.Length != 0)
      {
          System.Data.Common.DbTransaction transaction = db.BeginTransaction();
          try
          {
              ds.InativaFormas(transaction);

              for (int i = 0; i < list.Length; i++)
              {
                  //if (PararProcesso || PausarProcesso)
                  //{ break; }

                  OnStatusSZO(string.Format("Recebendo Formas de Pagamentos:{0} de {1}", i + 1, list.Length));
                  list[i].FPG_CODIGO = ds.Get_FromMD5(list[i].FPG_MD5, transaction).FPG_CODIGO;
                  ds.Save(list[i], transaction);
              }

              transaction.Commit();
          }
          catch 
          {
              transaction.Rollback();
          }
          finally { db.Close(); }
      }
    }

    private void RecebeOperadores()
    {
        //if (PararProcesso || PausarProcesso)
        //{ return; }

        dsSZO_OPR_OPERADORES ds = new dsSZO_OPR_OPERADORES(db);
        SZO_OPR_OPERADORES[] list = ServerSZO.RetornaOperadores(Identificacao, ds.LastTimeStamp().ToString("yyyy-MM-dd HH:mm:ss"));

        OnStatusSZO(string.Format("Recebendo Operadores:{0}", list.Length));

        if (list.Length != 0)
        {
            System.Data.Common.DbTransaction transaction = db.BeginTransaction();
            try
            {
                ds.InativaOperadores(transaction);
                for (int i = 0; i < list.Length; i++)
                {
                    //if (PararProcesso || PausarProcesso)
                    //{ break; }
                    OnStatusSZO(string.Format("Recebendo Operadores:{0} de {1}", i + 1, list.Length));
                    list[i].OPR_CODIGO = ds.Get_FromMD5(list[i].OPR_MD5, transaction).OPR_CODIGO;
                    ds.Save(list[i], transaction);
                }
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
            finally { db.Close(); }
        }
    }

    private void RecebeIngressos() 
    {
      //if (PararProcesso || PausarProcesso)
      //{ return; }

      dsSZO_CTK_CADASTRO_TICKETS ds = new dsSZO_CTK_CADASTRO_TICKETS(db);
      SZO_CTK_CADASTRO_TICKETS[] list = ServerSZO.RetornaIngressos(Identificacao, ds.LastTimeStamp().ToString("yyyy-MM-dd HH:mm:ss"));

      OnStatusSZO(string.Format("Recebendo Ingressos:{0}", list.Length));

      if (list.Length != 0)
      {
          System.Data.Common.DbTransaction transaction = db.BeginTransaction();
          try
          {
              ds.InativaIngressos(transaction);
              for (int i = 0; i < list.Length; i++)
              {
                  //if (PararProcesso || PausarProcesso)
                  //{ break; }

                  OnStatusSZO(string.Format("Recebendo Ingressos:{0} de {1}", i + 1, list.Length));
                  list[i].CTK_CODIGO = ds.Get_FromMD5(list[i].CTK_MD5, transaction).CTK_CODIGO;
                  ds.Save(list[i], transaction);
              }
              transaction.Commit();
          }
          catch {
              transaction.Rollback();
          }
          finally 
          { db.Close(); }
      }

      
    }

    public void AtualizaCadastros() 
    {
      try
      {
          RecebeFormas();
          RecebeIngressos();
          RecebeOperadores();
      }
      catch
      {
        // GravaLog
        OnStatusSZO("Sem Internet");
      }
    }

    public void RemoveSincronizados() 
    {
      if (PararProcesso || PausarProcesso)
      { return; }

      (new dsSZO_VDA_VENDA(db)).RemoveSincronizados();
      (new dsSZO_VTK_VENDA_TICKETS(db)).RemoveSincronizados();
      (new dsSZO_PGT_PAGAMENTO(db)).RemoveSincronizados();
      (new dsSZO_MCX_MOVIMENTO_CAIXA(db)).RemoveSincronizados(); 
    }

    private void ProcessaRegistros()
    {
      try
      {
        RemoveSincronizados();
        ServerSZO.EnviaKeepAlive(Identificacao, Versao);
      }
      catch
      {
        // GravaLog
        OnStatusSZO("Sem Internet");
      }

      string uData = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

      while (true)
      {
        string log = "";
        if (PararProcesso)
        {
          return;
        }

        if (PausarProcesso)
        {
          OnStatusSZO("Em Venda");
          System.Threading.Thread.Sleep(5000);
          continue;
        }

        try
        {
          bool KeepAliveEnviado = true;

          if (DateTime.Now.Subtract(Convert.ToDateTime(uData)).TotalMinutes > 15)
          { KeepAliveEnviado = ServerSZO.EnviaKeepAlive(Identificacao, Versao); }

          if (KeepAliveEnviado)
          {
            EnviaFormas();
            EnviaIngressos();
            EnviaOperadores();
            EnviaVendas();
            EnviaItens();
            EnviaPagamentos();
            EnviaMovimentoCaixa();
          }
        }
        catch (Exception ex)
        {
          // GravaLOG
          log = ex.Message;
          OnStatusSZO("Sem Internet");
        }

        for (int i = 0; i < 15; i++)
        {
          if (PararProcesso)
          {
            return;
          }

          OnStatusSZO(string.Format("Pausa:{0} de {1} {2}", i + 1, 15, log));
          System.Threading.Thread.Sleep(1000);
        }
      }
    }
  }
}

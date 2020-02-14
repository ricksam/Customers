using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lib.Entity;

namespace RckDatabase
{
    public class SIS_VER_VERSAO : DefaultEntity
    {
        public SIS_VER_VERSAO() 
        {
            VER_DATA = DateTime.Now;
        }

        [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
        public int VER_CODIGO { get; set; }
        public string VER_SISTEMA { get; set; }
        public string VER_SOLICITANTE { get; set; }
        public DateTime VER_DATA { get; set; }
        public string VER_DESCRICAO { get; set; }
        public string VER_URL { get; set; }
        public string VER_TESTE { get; set; }
        [CustomAttributeField(KeyTypeAttribute.QueryField)]
        public string[] Sistemas { get; set; }
        [CustomAttributeField(KeyTypeAttribute.QueryField)]
        public string[] URLs { get; set; }
    }

    public class dsSIS_VER_VERSAO : DefaultDataSource<SIS_VER_VERSAO>
    {
        public dsSIS_VER_VERSAO(DbBase DbBase)
            : base(DbBase)
        { }

        public SIS_VER_VERSAO Get(int VER_CODIGO)
        {
            return Get(string.Format("SELECT * FROM SIS_VER_VERSAO WHERE VER_CODIGO = {0}" , VER_CODIGO));
        }

        public SIS_VER_VERSAO[] List_Range(int MIN_VER_CODIGO, int MAX_VER_CODIGO)
        {
            return List(string.Format("SELECT * FROM SIS_VER_VERSAO WHERE VER_CODIGO >= {0} AND VER_CODIGO <= {1}", MIN_VER_CODIGO, MAX_VER_CODIGO));
        }

        public SIS_VER_VERSAO[] Search(string s) 
        {
            return List(string.Format("SELECT * FROM SIS_VER_VERSAO WHERE VER_DESCRICAO LIKE {0} ORDER BY VER_CODIGO DESC", DbQuoted("%" + s + "%")));
        }

        public string[] ListSistema() {
            System.Data.DataTable dt = DbBase.DbGetDataTable("SELECT DISTINCT VER_SISTEMA FROM SIS_VER_VERSAO ORDER BY VER_SISTEMA");
            string[] arr = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                arr[i] = dt.Rows[i]["VER_SISTEMA"].ToString();
            }

            return arr;
        }

        public string[] ListURL() {
            System.Data.DataTable dt = DbBase.DbGetDataTable("SELECT DISTINCT VER_URL FROM SIS_VER_VERSAO ORDER BY VER_URL");
            string[] arr = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                arr[i] = dt.Rows[i]["VER_URL"].ToString();
            }

            return arr;
        }

        public void Save(SIS_VER_VERSAO tab, System.Data.Common.DbTransaction transaction = null)
        {
            tab.VER_SISTEMA = base.SetMaxLength(tab.VER_SISTEMA, 60);
            tab.VER_SOLICITANTE = base.SetMaxLength(tab.VER_SOLICITANTE, 60);

            tab.VER_DESCRICAO = base.SetMaxLength(tab.VER_DESCRICAO, 400);
            tab.VER_URL = base.SetMaxLength(tab.VER_URL, 200);
            tab.VER_TESTE = base.SetMaxLength(tab.VER_TESTE, 65535);

            if (tab.VER_CODIGO == 0)
            {
                Insert(tab, transaction);
                if (transaction != null)
                {
                    tab.VER_CODIGO = this.ReturnLastID(transaction).ToInt();
                }
            }
            else
            { Update(tab, new SIS_VER_VERSAO() { VER_CODIGO = tab.VER_CODIGO }, transaction); }
        }

        public void Remove(int VER_CODIGO)
        {
            DbBase.DbExecute(string.Format("DELETE FROM SIS_VER_VERSAO WHERE VER_CODIGO = {0}", VER_CODIGO));
        }
    }
}

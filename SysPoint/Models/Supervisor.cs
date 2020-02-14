using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace SysPoint.Models
{
    public class Supervisor : BaseEntity<Supervisor> 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        
        public static Supervisor Find(int Id, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Supervisor>(
                    @"select 
                        Id
                       ,Nome
                       ,Email
                       ,Senha
                    from Supervisor where Id = @Id", new { Id = Id }).FirstOrDefault();
        }
        
        public static List<Supervisor> List(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Supervisor>(
                    @"select
                        Id
                       ,Nome 
                       ,Email 
                       ,Senha 
                    from Supervisor").ToList();
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Supervisor (
                        Nome,
                        Email,
                        Senha
                    ) {0} values (
                        @Nome,
                        @Email,
                        @Senha
                    ) {1}", "Id"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Supervisor set 
                        Nome=@Nome, 
                        Email=@Email, 
                        Senha=@Senha 
                    where Id = @Id", this);
        }
        
        public void Save(Context cx = null)
        {
            if(this.Id == 0)
                this.Id = Insert(cx);
            else
                Update(cx);        
        }
        
        public static void Delete(int Id, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Supervisor where Id = @Id", new { Id = Id });
        }        
    }
}

using System;
using System.Collections.Generic;

namespace arv_sak
{
    class Program
    {
        static void Main(string[] args)
        {
            Databas db = new Databas();
          Sak sak1=new DVD("how to make Kebab","Kebabman");
          db.Add(sak1);
          Sak sak2=new DVD("how to make Pizza","Pizzaman");
          db.Add(sak2);
          Sak sak3=new DVD("how to make Cookies","Cookieman");
          db.Add(sak3);
          Sak sak4=new CD("Cookie song","Cookieman");
          db.Add(sak4);

          db.Print();
        }
               
    }
    class DVD:Sak
    {
        public DVD(string n, string r):base(n, r)
        {

        }
        public override void Act()
      {
          Console.WriteLine("DVD, Namn:"+namn+ "\n regissör:"+regissör+"");
      }
    }
    class CD:Sak
    {
        
        public CD(string n, string r):base(n, r)
        {

        }
        public override void Act()
      {
          Console.WriteLine("CD, Namn:"+namn+ "\n Artist:"+regissör+"");
      }
    }
    abstract class Sak 
    {
        protected string namn;
        protected string regissör;
        public Sak(string n, string r)
        {
            namn = n;
            regissör = r;
        }
        public abstract void Act();
    }
    class Databas
    {
        private List<Sak> lista = new List<Sak>();
        public void Add(Sak Listadd)
        {
            lista.Add(Listadd);
        }
        public void Print()
      {
          foreach(Sak sak in lista)
          {
              sak.Act();
          }
      }
    }
}

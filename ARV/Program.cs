using System;
using System.Collections.Generic;

namespace ARV
{
    
    public class Zoo
  {
      private List<Animal> lista;

      public Zoo()
      {
          lista = new List<Animal>();
          Animal djur1=new Cat("n",1);
          lista.Add(djur1);
          Animal djur2=new Cat("walla",5);
          lista.Add(djur2);
          Animal djur3= new Cat("kebab",9);
          lista.Add(djur3);
          Animal djur4=new Dog("n",1);
          lista.Add(djur4);
          Animal djur5=new Dog("walla",5);
          lista.Add(djur5);
          Animal djur6= new Snake("kebab",9);
          lista.Add(djur6);
      }

      public void Print()
      {
          foreach(Animal djur in lista)
          {
              djur.Act();
          }
      }       
  }

  public class Mainy
  {
      public static void Main()
      {
          Zoo minLista = new Zoo();
          minLista.Print();
      }
  }
  public class Animal
  {
      protected string namn;
      protected int ålder;
      public Animal(string n, int å)
      {
          namn= n;
          ålder= å;
      }
      public virtual void Act()
      {
          Console.WriteLine("hej,hej");
      }
  }
  public class Cat:Animal
  {
      public Cat(string n, int å):base(n,å)
      {}
      public override void Act()
      {
          Console.WriteLine("mjau,mjau");
      }
  }
  public class Snake:Animal
  {
      public Snake(string n, int å):base(n,å)
      {}
      public override void Act()
      {
          Console.WriteLine("Hissssssssssssssssssssssssssssssssssssssssssssssss");
      }
  }
  public class Dog:Animal
  {
      public Dog(string n, int å):base(n,å)
      {}
      public override void Act()
      {
          Console.WriteLine("woffle,woffle");
      }
  }
}

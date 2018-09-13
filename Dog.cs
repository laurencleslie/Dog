using System;
 public string name, owner;
 public int age;

 enum gender
 {
     male,
     female
 }

namespace Dogument
{
   class Dog
   {
        public Dog(string name, string owner, int age, gender);
        {
            this.name=name;
            this.owner=owner;
            this.age=age;
            this.gender.male=gender.male;
            this.gender.female=gender.female;

        }
         public static void Main()
         { 

           //create constructor
           int count;
           Dog puppy=new Dog("Orion", "Shawn", 1, gender.male);
           puppy.bark(3);
           Console.WriteLine(puppy.getTag());

           Dog myDog= new Dog("Lileu", "Dale", 4, gender.female);
           myDog.bark(1);
           Console.WriteLine(myDog.getTag());
          
          

         }
         public void bark(count)
         {
           for(int i=0; i<count; i++)
           {
               Console.WriteLine("Woof!");
           }

        }
        public void getTag()
        {
            if(gender.male=true)
            Console.WriteLine("If Lost, call ", owner, "his name is ", name, "and he is " age "years old");
            else
            {
                Console.WriteLine("If Lost, call ", owner, "her name is ", name, "and she is " age "years old");
            }
        }
        
   }


}
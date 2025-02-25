using EF_Project.Contexts;
using EF_Project.Entities;

namespace EF_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using MyAppDbContext Context = new MyAppDbContext();

            Student std = new Student() {
                FName = "maro",
                LName = "adel",
                Age = 21,
                Adress = "Cairo",
                
            };


            var res = Context.Students.FirstOrDefault(S => S.Id == 1);

           

            Console.WriteLine(Context.Entry(res).State);


            Context.Students.Remove(res);



            Console.WriteLine(Context.Entry(res).State);

            Context.SaveChanges();

            Console.WriteLine(Context.Entry(res).State);





        }
    }
}

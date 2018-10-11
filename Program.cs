using System;
using System.Collections.Generic;
using System.Linq;
using LINQTut;

namespace Buffteks3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {

                    //no matter what, delete and then create
                    //db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.students.Any())
                    {
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                FirstName = "Laith",
                                LastName = "Alfaloujeh",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Mekkala",
                                LastName = "Bourapa",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Charles",
                                LastName = "Coufal",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "John",
                                LastName = "Cunningham",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "Michael",
                                LastName = "Hayes",
                                Role = "Sophmore"
                            },     
                            new Student()
                            {
                                FirstName = "Aaron",
                                LastName = "Heber",
                                Role = "Senior"
                            },        
                            new Student()
                            {
                                FirstName = "Yi Fu",
                                LastName = "Ji",
                                Role = "Junior"
                            },     
                            new Student()
                            {
                                FirstName = "Todd",
                                LastName = "Kile",
                                Role = "Freshman"
                            },           
                            new Student()
                            {
                                FirstName = "Mara",
                                LastName = "Kinoff",
                                Role = "Senior"
                            },   
                            new Student()
                            {
                                FirstName = "Cesareo",
                                LastName = "Lona",
                                Role = "Freshman"
                            },    
                            new Student()
                            {
                                FirstName = "Michael",
                                LastName = "Matthews",
                                Role = "Sophmore"
                            },    
                            new Student()
                            {
                                FirstName = "Mason",
                                LastName = "McCollum",
                                Role = "Junior"
                            },    
                            new Student()
                            {
                                FirstName = "Alexander",
                                LastName = "McDonald",
                                Role = "Senior"
                            },        
                            new Student()
                            {
                                FirstName = "Phelps",
                                LastName = "Merrell",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Quan",
                                LastName = "Nguyen",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Alexander",
                                LastName = "Roder",
                                Role = "Sophmore"
                            },
                            new Student()
                            {
                                FirstName = "Amy",
                                LastName = "Saysouriyosack",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "Claudia",
                                LastName = "Silva",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "Gabriela",
                                LastName = "Valenzuela",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Kayla",
                                LastName = "Washington",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "Matthew",
                                LastName = "Webb",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Cory",
                                LastName = "Williams",
                                Role = "Sophmore"
                            },
                                               
                        };

                        db.students.AddRange(students);  

                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var students = db.students.ToList();
                        var studentsFiltered = students.Where(s => s.Role != "Senior");
                        //var studentsFiltered = students.Where(s => s.FirstName.StartsWith("M"));
                        //var studentsFiltered = students.Where(s => s.Role == "Senior" && s.Role == "Juniors");
                        
                        foreach( var s in studentsFiltered){
                            Console.WriteLine($"{s}");
                        }
                        
                    }


                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}

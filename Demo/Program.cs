using Demo.Enums;
using Demo.UserDefinedDataTypes;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA a=new ClassA();
            a.setx(1);
            a.i = 2;

            #region Enum => Enumeration
            //readability
            //maintanance
            ////for  collection of constant values
            //strongly typed ____ type safety
            //can't exceed its range

            //enum: byte from 0 to 255
            // usually we don't declare enum with data type

            #endregion

            #region Part04 EXAMPLE 01 Enum
            //Person person=new Person();
            //person.Id = 1;
            //person.Name = "Ali";
            //person.Gender = Gender.male;

            //Console.WriteLine(person.Gender);
            //Grades grade = Grades.B;
            //if (grade == Grades.B)
            //{
            //    Console.WriteLine("Excellent");
            //}
            ////Console.WriteLine(per);
            //else
            //{
            //    Console.WriteLine("Good LUck next time");

            //}
            //grade = (Grades)5;//Explicit casting
            //Grades grade2=new Grades();
            //Console.WriteLine(grade2); // first value  A
            #endregion


            #region Example 02 Enum
            //bool isParsed;
            //Student student = new Student();
            //Console.WriteLine("Please Enter student data:");
            //Console.WriteLine("Id=> ");
            //int id;
            //do
            //{
            //    isParsed=int.TryParse(Console.ReadLine(), out id);
            //    if(!isParsed)

            //        Console.WriteLine("Invalid Input");

            //}while (!isParsed);
            //student.Id=id;  
            //Console.WriteLine("Name =>");
            //student.Name=Console.ReadLine();
            //Console.WriteLine("Gender =>");
            //object gender;
            //do
            //{
            //    isParsed = Enum.TryParse(typeof(Gender),Console.ReadLine(),true, out gender);
            //    if(!isParsed)
            //        Console.WriteLine("Invalid Input");


            //} while (!isParsed);
            //student.Gender =(Gender) gender;

            //Console.WriteLine("Grades =>");
            //object grade;
            //do
            //{
            //    isParsed = Enum.TryParse(typeof(Grades), Console.ReadLine(), true, out grade);
            //    if(!isParsed)

            //        Console.WriteLine("Invalid Input");


            //} while (!isParsed);
            //student.Grade = (Grades)grade;

            //Console.WriteLine("Branch =>");
            //object branch;
            //do
            //{
            //    isParsed = Enum.TryParse(typeof(Branch), Console.ReadLine(), true, out branch);
            //    if(!isParsed)
            //    Console.WriteLine("Invalid Input");

            //} while (!isParsed);
            //student.Branch = (Branch)branch;


            //Console.WriteLine($"Student Id {student.Id}");
            //Console.WriteLine($"Student Name {student.Name}");
            //Console.WriteLine($"Student gender {student.Gender}");
            //Console.WriteLine($"Student grade {student.Grade}");
            //Console.WriteLine($"Student branch {student.Branch}");
            #endregion



            #region Example 03 Enum
            //User user01=new User(); 
            //user01.Id = 1;
            ////user01.Permissions[0]=true;//write

            //user01.Permission = (Permissions)4;
            //Console.WriteLine(user01.Permission);

            //user01.Permission = (Permissions)8;
            //Console.WriteLine(user01.Permission);

            //user01.Permission = (Permissions)11;
            //Console.WriteLine(user01.Permission);

            //user01.Permission=user01.Permission ^ /*XOR*/ Permissions.Read; 
            //        //^ XOR if it exist =>remove || if not exist=> will be added
            //        //1^0=>1  //1^1=>0, 0^0=>0
            //Console.WriteLine(user01.Permission);
            //user01.Permission = user01.Permission & /*and*/ Permissions.Read;

            //Console.WriteLine(user01.Permission);

            //user01.Permission = user01.Permission | /*OR*/ Permissions.Delete;
            ////in case it's not exist or exist add it
            //Console.WriteLine(user01.Permission);

            #endregion



            #region Enum Methods
            //casting
            string branch = "Alex";
            Branch branch01=(Branch)Enum.Parse(typeof(Branch), branch); //not safe

            //collect enums in array of string
            string[]branchNames=Enum.GetNames(typeof(Branch));

            foreach(string branchName in branchNames)
            {
                Console.WriteLine(branchName);
            }
            Array branchValues = Enum.GetValues(typeof(Branch));

            foreach (var branchValue in branchValues)
            {
                Console.WriteLine((int)branchValue);
            }

            /////
            ///
            bool isExist = Enum.IsDefined(typeof(Branch), 50);
            Console.WriteLine("ISEXIST ? "+isExist);
            #endregion
        }
    }
}

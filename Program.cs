using Microsoft.VisualBasic;

namespace ValueAndReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Type
            //Tipe data yang menyimpan value dari variable di memorinya sendiri, sehingga ketika ada function yang dipanggil dan merubah value dari variable, tidak akan mengubah value variable di function yang lain
            //karena sistem akan membuat copian dari variable tersebut
            int number = 100;
            ChangeValueType(number);
            Console.WriteLine(number);

            //Reference Type
            //tipe data akan berisi pointer yang menunjuk ke alamat suatu lokasi memory. Contoh tipe data reference adalah Class
            //Disini dapat dilihat student.Name di declare dengan value Fifi.. Namun setelah method Change ReferenceType dipanggil.
            //student.name berubah value nya menjadi Rubi karena alamat pointer student.name telah menyimpan value yang berbeda.
            //value student1.name juga menjadi Rubi karena menunjuk pada alamat yang sama;
            Student student = new Student();
            Student student1 = new Student();
            student.Name = "Fifi";
            student1 = student;
            ChangeReferenceType(student);
            Console.WriteLine(student1.Name);
        }
        static void ChangeValueType(int x)
        {
            x = 200;
        }

        static void ChangeReferenceType(Student student)
        {
            student.Name = "Rubi";
        }

        public class Student
        {
            public string Name;
        }
       
    }
}
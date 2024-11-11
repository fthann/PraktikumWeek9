using System;

namespace MyApp
{
    internal class Program
    {
            // Method static
            static void methodStatic() {
                Console.WriteLine("Saya adalah method static");
            }

            // Method non-static
            void nonStaticMethod() {
                Console.WriteLine("Saya adalah method NON - static");
            }

            

            // Method entry point (Method Main)
            static void Main(string[] args) {
                // pemanggil method static
                methodStatic();

                // pemanggil method non staticx
                Program program = new Program();
                program.nonStaticMethod();
            } 



            // Method dengan return
            static string fullName(string namaSaya) {
                return namaSaya;
            }

            // Method tanpa return
            static void nimName(string namaSaya) {
                Console.WriteLine(nimName);
            }

            // Method entry point (Method Main)
            static void main(string[] args) {
                fullName("pabaji");
                Console.WriteLine(fullName("fortinaiti"));
                nimName("babyo");
            }
    }
}
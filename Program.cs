using System;

namespace MyApp
{
    internal class Program
    {
            // // Method static
            // static void methodStatic() {
            //     Console.WriteLine("Saya adalah method static");
            // }

            // // Method non-static
            // void nonStaticMethod() {
            //     Console.WriteLine("Saya adalah method NON - static");
            // }

            
            // Method Return
            static string tulisNama(string namaSaya) {
                return namaSaya;
            }

            // Method no Return
            static void tulisNim(string nimSaya) {
                Console.WriteLine(nimSaya);
            }

            static void Main(string[] args) {
                tulisNama("icikiwir");
                Console.WriteLine(tulisNama("junaidi"));
                tulisNim("pabaji");
            }
    }
}
using System;
using System.IO;
public class Program
{
            async static Task<string[]> read(string filename)
            {
                var data = await File.ReadAllLinesAsync(filename);
                return data;
            }
            static async Task write(string[] data,string filename)
            {
                await File.WriteAllLinesAsync(filename,data);
                System.Console.WriteLine("Done");
                Console.WriteLine(data);
            }
            static public async Task perform()
            {
                var data = read("A.txt");
                await write(data.Result,"B.txt");
            }
            public static void Main(string[] args)
            {
                perform();
            }
}
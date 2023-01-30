namespace TratamentoDatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                //DateTime.Now.ToString("d") + "\n\n" +      // Pega só a data ex. 26/01/2023
                //DateTime.Now.ToString("D") + "\n\n"      // Pega a data completa

                DateTime.Now.ToString("d") + "\n" +
                DateTime.Now.ToString("D") + "\n" +
                DateTime.Now.ToString("t") + "\n" +
                DateTime.Now.ToString("T") + "\n" +
                DateTime.Now.ToString("f") + "\n" +
                DateTime.Now.ToString("F") + "\n" +
                DateTime.Now.ToString("g") + "\n" +
                DateTime.Now.ToString("G") + "\n" +
                DateTime.Now.ToString("M") + "\n" +
                DateTime.Now.ToString("r") + "\n" +
                DateTime.Now.ToString("s") + "\n" +
                DateTime.Now.ToString("u") + "\n" +
                DateTime.Now.ToString("Y") + "\n" +
                DateTime.Now.ToString("dd") + "\n" +
                DateTime.Now.ToString("ddd") + "\n" +
                DateTime.Now.ToString("dddd") + "\n" +
                DateTime.Now.ToString("MM") + "\n" +
                DateTime.Now.ToString("MMM") + "\n" +
                DateTime.Now.ToString("MMMM") + "\n" +
                DateTime.Now.ToString("yy") + "\n" +
                DateTime.Now.ToString("yyyy") + "\n" +
                DateTime.Now.ToString("dd / MM / yyyy hh: mm") + "\n" +
                DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss.fff") + "\n"
         //DateTime.Now.ToString("São Paulo, " + "dddd dd" + "de" + "MMMM" + "de" + "yyyy")
                );






        }
    }
}
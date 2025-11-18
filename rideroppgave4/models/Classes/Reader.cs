namespace rideroppgave4.models.Classes;

public class Reader
{
    private StreamReader newReader;

    /*public Reader(string path)
    {
        
        try
        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (newReader = new (path))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = newReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
        
        
    }*/

    public void ReadAgain(string path)
    {
        try
        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (newReader = new (path))
            {
                string line;
                int linecount = 0;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = newReader.ReadLine()) != null)
                {
                    /*List<string> splits = new();
                    splits.Add(line.Split(","));*/
                    string[] splits = line.Split(",");
                    if (linecount > 0)
                    {
                        int kol = 4;
                        Console.WriteLine(splits[kol]);
                        /*if (splits[kol] == null)
                        {
                            
                        }
                        else
                        {
                            Console.WriteLine(splits[kol]); 
                        }*/
                        
                    }
                    //Console.WriteLine(linecount);
                    linecount++;
                }
            }
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
    
    public void ReadAndMake(string path,Action<string[]> function)
    {
        try
        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (newReader = new (path))
            {
                string line;
                int linecount = 0;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = newReader.ReadLine()) != null)
                {
                    /*List<string> splits = new();
                    splits.Add(line.Split(","));*/
                    string[] splits = line.Split(",");
                    if (linecount > 0)
                    {
                        int kol = 0;
                        Console.WriteLine(splits[kol]);
                        function(splits);
                        /*if (splits[kol] == null)
                        {

                        }
                        else
                        {
                            Console.WriteLine(splits[kol]);
                        }*/

                    }
                    //Console.WriteLine(linecount);
                    linecount++;
                }
            }
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }

    public void MakeList(string path,Action<string[]> function)
    {
        try
        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (newReader = new (path))
            {
                string line;
                int linecount = 0;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = newReader.ReadLine()) != null)
                {
                    /*List<string> splits = new();
                    splits.Add(line.Split(","));*/
                    string[] splits = line.Split(",");
                    if (linecount > 0)
                    {
                        int kol = 0;
                        //Console.WriteLine(splits[kol]);
                        function(splits);

                    }
                    //Console.WriteLine(linecount);
                    linecount++;
                }
            }
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
    
    
}
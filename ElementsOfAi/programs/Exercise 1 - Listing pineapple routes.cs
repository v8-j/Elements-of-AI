class Listing_pineapple_routes
{
    private static string[] portnames = ["PAN", "AMS", "CAS", "NYC", "HEL"];


    private static void permutations(List<int> route, List<int> ports)
    {
        for(int i = 0; i < ports.Count; ++i)
        {
            List<int> tmp = ports.ToList();
            List<int> rte = route.ToList();
            rte.Add(tmp.Pop(i));
            permutations(rte, tmp);
            
            if (rte.Count == 5)
            {
                string s = "";
                foreach (int j in route)
                {
                    s += portnames[j] + " ";
                }                
                Console.WriteLine(s);
            }
        }
    }

    public static void Run()
    {
        permutations([0], [1,2,3,4]);
    }
}
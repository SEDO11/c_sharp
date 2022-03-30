using System;
using System.Collections.Generic;

namespace list_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> items = new List<string>();
            items.Add("홍길동");
            items.Add("일지매");
            items.Add("강동원");
            
            for(int i=0; i<items.Count; i++)
            {
                Console.WriteLine(items[i]);
            }
        
            
        }

    }
}

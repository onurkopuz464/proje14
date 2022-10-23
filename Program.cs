using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        function instance= new function();
        
        
        //Console.WriteLine(instance.functionOne(4,5));
        int[] array = {1,2,3};
        array.arraychange();
        array.arraywrite();
    


    }
    class function 
    {
        public int functionOne()
        {
            return 0;
        }

    


    }
 
        
}
   public static class Extension
    {
        public static int[] arraychange(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void arraywrite(this int[] param)
        {
            foreach(var item in param)
            {
                Console.WriteLine(item);
            }
        }




    }

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ProperrtyWithGetterOnly
{
    class Demo
    {
        public string PropertWithGetterOK01
        {
            get
            {
                return "";
            }
        }

        public string PropertWithGetterOK02
        {
            get;
            private set;
        }

        public string PropertWithGetterNotOK01
        {
            /*
                Visual Studio 2013:
                'Demo.ProperrtyWithGetterOnly.Demo.PropertWithGetterOK01.get' 
                must declare a body because it is not marked abstract or extern. 
                Automatically implemented properties must define both get and set accessors.
             
                Visual Studio 2015:     OK
              
                Xamarin.Studio:         OK
             
            */
            get;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

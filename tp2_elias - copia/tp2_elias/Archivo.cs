﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace tp2_elias
{
    class Archivo
    {
        static private string Rutadelarchivo;
        StreamReader archivoR = new StreamReader(Rutadelarchivo);
        StreamWriter archivoW = new StreamWriter(Rutadelarchivo);
        public Archivo(string ruta) 
        {
            Rutadelarchivo = ruta;
        }
        private string[] info() 
        {
            string[] aux = File.ReadAllLines(Rutadelarchivo);
            return aux;
        }
        public string Buscadorid(string id) 
        {
            int i=0;
          string[] aux = info();
          do{
                string [] partes = aux[i].Split(';');
                if(partes[0]==id)
                {
                    return aux[i];
                }
            
            }while(i<=aux.Length);

          return "-1";
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_sep
{
    internal class Contacto
    {
        String nombreCompleto;
        String telefono;
        String correo;
        String genero;
        String cumple;
        int edad; 
        
        public Contacto(String pNombreCompleto, String pTelefono, String pCorreo, String pGenero, String pCumple, int pEdad)
        {       
            nombreCompleto = pNombreCompleto;
            telefono = pTelefono;
            correo = pCorreo;
            genero = pGenero;
            cumple = pCumple;
            edad = pEdad;   
        }
        public String mostrarDatos() 
        {
            String texto = "\nNombre completo:  " + nombreCompleto + "\nTelefono: " + telefono + "\nCorreo: " + correo + "\nGenero: " + genero +
                "\nCumple: " + cumple +"\nEdad: " + edad;
            return texto;
        }
    
    }
}

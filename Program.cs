using System;
using System.Security.AccessControl;
using Microsoft.Win32.SafeHandles;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public abstract class Persona
    {
        protected string Nombre;

        public Persona(string Nombre){
            this.Nombre = Nombre;
        }
    }
    public class Estudiante : Persona
    {
        protected int ID;

        public Estudiante(int ID,string Nombre) : base(Nombre){
            this.ID = ID;
        }
    }
    public class Profesor : Persona{
        protected string[] aulas =[];

        Profesor(string[]aulas,string Nombre) : base(Nombre){
            this.aulas = aulas;
        }

        public void ImpartiendoClases(){

        }

    }
    public class Curso{
        protected string Nombre;
        protected int RecuentoClases;
        protected int RecuentoEjercicios;

        public Curso(string Nombre){
            this.Nombre = Nombre;
        }
        public void DefinirClase(){

        }
        public void AgregarEjercicio(){

        }
    }
    public class ClasesAula{
        protected string identificador;
        protected List<Estudiante> estudiantes;
        protected List<Profesor> profesores;

        public ClasesAula(string identificador){
            this.identificador = identificador;
            this.profesores = new List<Profesor>();
            this.estudiantes = new List<Estudiante>();
        }

        public void AgregarEstudiante(Estudiante estudiante){
            
        }
        public void AgregarProfesor(Profesor profesor){

        }
 
    }
    
}
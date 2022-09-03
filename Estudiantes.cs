using System;

namespace parcia
{
    internal class Estudiantes
    {
        private int id;
        private string codigo;
        private string nombre;
        private int edad;
        private int nota1;
        private int nota2;
        private int notaFinal;

        public Estudiantes(int id, string codigo, string nombre, int edad, int nota1, int nota2, int notaFinal)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.edad = edad;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.notaFinal = notaFinal;
        }

        public int NotaFinal { get; internal set; }

        internal bool mostrar()
        {
            throw new NotImplementedException();
        }
    }
}
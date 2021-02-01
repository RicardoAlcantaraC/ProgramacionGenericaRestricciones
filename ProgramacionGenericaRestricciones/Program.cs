using System;

namespace ProgramacionGenericaRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {
            AlamacenEmpleados<Director> empladoDirector = new AlamacenEmpleados<Director>(3);
            empladoDirector.agregar(new Director(4500));
            empladoDirector.agregar(new Director(1400));
            empladoDirector.agregar(new Director(3400));

            Director miDirector = empladoDirector.getEmpleado(0);
            Console.WriteLine(miDirector.getSalario());

        }
    }

    //La restriccion se encuentra en el momento de implementar clases que manejen 
    //la interfaz IParaEmpleados la cual considera una persona como empleado si
    //tiene un salario
    class AlamacenEmpleados<T> where T:IParaEmpleados
    {
        public AlamacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }

        public void agregar(T obj)
        {
            datosEmpleado[i] = obj;
            i++;
        }

        public T getEmpleado(int i)
        {
            return datosEmpleado[i];
        }

        private int i = 0;
        private T[] datosEmpleado;
    }

    class Director:IParaEmpleados
    {
        public Director(double salario)
        {
            this.salario = salario;
        }
          

        public double getSalario()
        {
            return salario;
        }

        private double salario;
    }

    class Secretaria:IParaEmpleados
    {
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }

        private double salario;

    }

    class Electricista:IParaEmpleados
    {
        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }

        private double salario;

    }

    //La clase estudiante no hereda la interfaz para empleados, por lo cual
    //no se considera un empleado y no podemos almacenar objetos de tipo
    //estudiante en nuestra clase generica
    class Estudiante
    {
        public Estudiante(int edad)
        {
            this.edad = edad;
        }

        public double getEdad()
        {
            return edad;
        }
        private double edad;
    }

    interface IParaEmpleados
    {
        double getSalario();
    }
}

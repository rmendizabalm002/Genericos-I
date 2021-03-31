using System;

namespace Genericos_I
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjeto<Empleado> archivos = new AlmacenObjeto<Empleado>(4);
           
            archivos.agregar(new Empleado(1500));
            archivos.agregar(new Empleado(1200));
            archivos.agregar(new Empleado(1100));
            archivos.agregar(new Empleado(1800));

            Empleado salarioEmp = archivos.getElemento(0);

            Console.WriteLine(salarioEmp.getSalario());



        }
    }

    class AlmacenObjeto<T>
    {
        
        public AlmacenObjeto(int z)
        {
            datosElemento = new T[z];


        }

        public void agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public T  getElemento(int i)
        {
            
            
            return datosElemento[i];
        }

        private T[] datosElemento;

        private int i = 0;


    }

    class Empleado
    {
        
        public Empleado(double salario)
        {
            this.salario = salario;
        }
        
        public double getSalario()
        {
            return salario;
        }

        private double salario;


    }
}

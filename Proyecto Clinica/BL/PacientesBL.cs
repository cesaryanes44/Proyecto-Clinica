using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PacientesBL
    {
        public BindingList<Paciente> ListaPaciente { get; set; }

        public PacientesBL()
        {
            ListaPaciente = new BindingList<Paciente>();

            var paciente1 = new Paciente();
            var paciente2 = new Paciente();
            var paciente3 = new Paciente();

            paciente1.Id = 1;
            paciente1.Nombre = "Axel Josue Pineda Rivera";
            paciente1.Edad = 22;
            paciente1.Telefono = 87762354;
            paciente1.Direccion = "Villanueva, Cortes";
            paciente1.NoIdentidad = "0505199733098";

            paciente2.Id = 2;
            paciente2.Nombre = "Alejandra Rosario Paredes Coello";
            paciente2.Edad = 20;
            paciente2.Telefono = 32459867;
            paciente2.Direccion = "San Pedro Sula, Cortes";
            paciente2.NoIdentidad = "05101999956234";

            paciente3.Id = 3;
            paciente3.Nombre = "Miguel Angel Pavon Rodriguez";
            paciente3.Edad = 32;
            paciente3.Telefono = 96765487;
            paciente3.Direccion = "Potrerillos, Cortes";
            paciente3.NoIdentidad = "0505199456723";

            ListaPaciente.Add(paciente1);
            ListaPaciente.Add(paciente2);
            ListaPaciente.Add(paciente3);
        }

        public BindingList<Paciente> ObtenerPaciente()
        {
            return ListaPaciente;
        }

        public Resultado GuardarPaciente(Paciente paciente)
        {
            var resultado = Validar(paciente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            if(paciente.Id == 0)
            {
                paciente.Id = ListaPaciente.Max(item =>item.Id) + 1;
            }

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarPaciente()
        {
            var nuevoPaciente = new Paciente();
            ListaPaciente.Add(nuevoPaciente);
        }
        public bool EliminarPaciente(int id)
        {
            foreach (var paciente in ListaPaciente)
            {
                if(paciente.Id == id)
                {
                    ListaPaciente.Remove(paciente);
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Paciente paciente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if(string.IsNullOrEmpty(paciente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }

            if (paciente.Edad < 0)
            {
                resultado.Mensaje = "La edad debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (paciente.Direccion == "")
            {
                resultado.Mensaje = "Ingrese una Direccion";
                resultado.Exitoso = false;
            }


            return resultado;
        }
    }

    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string NoIdentidad { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}

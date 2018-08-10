using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caldeira
{
    public class Caldeira
    {
        private static Caldeira caldeira = null;
        public bool Estavel { get; set; }
        public float Temperatura { get; set; }
        public float NivelAgua { get; set; }
        public float TemperaturaFogo { get; set; }
        public float TemperaturaMaxima { get; }
        public float TemperaturaMinima { get; }
        public float NivelAguaMaximo { get; }
        public float NivelAguaMinimo { get; }
       
        private Caldeira(float temperaturaInicial, float nivelAguaInicial)
        {
            Temperatura = temperaturaInicial;
            NivelAgua = nivelAguaInicial;
            TemperaturaMaxima = 200f;//°C
            TemperaturaMinima = 20f;//°C
            NivelAguaMaximo = 100f;//litros
            NivelAguaMinimo = 20f;//litros
            Estavel = true;
        }

        public static Caldeira getInstance()
        {
            if (caldeira == null)
            {
                caldeira = new Caldeira(50, 30);
            }
            return caldeira;
        }

        private void atualizaAmbiente()
        {
            atualizaTemperaturaCaldeira();
            atualizaNivelAgua();
            verificaEstabilidadeCaldeira();
        }

        private void atualizaNivelAgua()
        {
            if(this.Temperatura > 100)
            {
                this.NivelAgua -= (this.Temperatura / 100);
            }
        }

        private void atualizaTemperaturaCaldeira()
        {
            if(TemperaturaFogo > this.Temperatura)
            {
                this.Temperatura += (TemperaturaFogo / this.Temperatura);
            }
            else if (TemperaturaFogo < this.Temperatura)
            {
                this.Temperatura -= (this.Temperatura / TemperaturaFogo);
            }
        }

        private void verificaEstabilidadeCaldeira()
        {
            if (this.Temperatura > this.TemperaturaMaxima ||
               this.NivelAgua > this.NivelAguaMaximo ||
               this.Temperatura < this.TemperaturaMinima ||
               this.NivelAgua < this.NivelAguaMinimo)
            {
                this.Estavel = false;
            }
        }

        public void alterarTemperaturaFogo(float novaTemperatura)
        {
            getInstance().TemperaturaFogo = novaTemperatura;
            atualizaAmbiente();
        }

        public void alterarNivelAgua(float novoNivelAgua)
        {
            if(getInstance().NivelAgua < novoNivelAgua)
            {
                this.Temperatura -= (novoNivelAgua / getInstance().NivelAgua);
            }
            else if (getInstance().NivelAgua > novoNivelAgua)
            {
                this.Temperatura -= (getInstance().NivelAgua / novoNivelAgua);
            }
            getInstance().NivelAgua = novoNivelAgua;
            atualizaAmbiente();
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartaBaraja
{
    public enum Palos
    {
        DIAMANTES = '♦',
        PICAS = '♠',
        TREBOLES = '♣',
        CORAZONES = '♥'
    }
    public enum Valores
    {
        AS = 1,
        DOS,
        TRES,
        CUATRO,
        CINCO,
        SEIS,
        SIETE,
        OCHO,
        NUEVE,
        DIEZ,
        JOTA,
        REINA,
        REY
    }

    public class Card
    {
        private Palos palo;
        private Valores valor;

        public Card(Palos palo, Valores valor)
        {
            this.palo = palo;
            this.valor = valor;
        }

        public Palos getPalo()
        {
            return palo;
        }
        public Valores getValor()
        {
            return valor;
        }

        public String showCard()
        {
            String mostrar_valor = "";
            switch (this.valor)
            {
                case Valores.AS:
                    mostrar_valor = " A";
                    break;
                case Valores.JOTA:
                    mostrar_valor = " J";
                    break;
                case Valores.REINA:
                    mostrar_valor = " Q";
                    break;
                case Valores.REY:
                    mostrar_valor = " K";
                    break;
                case Valores.DIEZ:
                    mostrar_valor = "10";
                    break;
                default:
                    mostrar_valor = " " + ((int)this.valor).ToString();
                    break;
            }
            String result = "┌───────┐\n|       |\n|       |\n|  " + (char) this.palo + mostrar_valor + "  |\n|       |\n|       |\n└───────┘";
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
	class Simulador
	{
		private static Random rand;
		Queue<Proceso> fila;
		private int procesosAtendidos, ciclosVacios, restantes, sumaRestantes;

		public Simulador()
		{
			rand = new Random();
			fila = new Queue<Proceso>();
		}

		public String simular()
		{
			procesosAtendidos = 0;
			ciclosVacios = 0;
			sumaRestantes = 0;
			for (int i = 0; i < 200; i++)
			{
				if (rand.Next(1,5)==3)
				{
					Proceso p = new Proceso(rand.Next(4,14));
					fila.Enqueue(p);
				}
				if (fila.Count!=0)
				{
					fila.Peek().ciclos--;
					if (fila.Peek().ciclos==0)
					{
						fila.Dequeue();
						procesosAtendidos++;
					}
				}
				else
				{
					ciclosVacios++;
				}
			}
			restantes = fila.Count;
			while (fila.Count!=0)
			{
				sumaRestantes+= fila.Dequeue().ciclos;
			}

			return "Procesos atendidos: " + procesosAtendidos + Environment.NewLine + "Ciclos vacios: " + ciclosVacios + Environment.NewLine + "Procesos faltantes: " + restantes + Environment.NewLine + "Suma restantes: " + sumaRestantes;
		}
	}
}

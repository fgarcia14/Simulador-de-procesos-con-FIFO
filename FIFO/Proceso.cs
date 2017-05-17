using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
	class Proceso
	{
		private int _ciclos;

		public int ciclos { get { return _ciclos; } set { _ciclos = value; } }

		public Proceso(int ciclos)
		{
			_ciclos = ciclos;
		}
	}
}

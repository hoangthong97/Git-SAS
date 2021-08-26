using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class Tag
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public void ShowTag()
		{
			Console.WriteLine("Show");
		}
	}
}

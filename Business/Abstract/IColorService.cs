using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;

namespace Business.Abstract
{
	interface IColorService
	{
		List<Color> GetAll();
		Color GetById(int id);
		void Add(Color color);
		void Update(Color color);
		void Delete(Color color);
	}
}

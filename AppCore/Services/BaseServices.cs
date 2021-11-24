using AppCore.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
	public abstract class BaseServices<T> : IServices<T>
	{
		private IModel<T> model;
		protected BaseServices(IModel<T> model)
		{
			this.model = model;
		}
		public void Create(T t)
		{
			model.Create(t);
		}

		public int GetLastId()
		{
			return model.GetLastId();
		}
	}
}

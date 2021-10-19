
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	
	public class DepartmentFacade : BaseFacade
	{
		protected static DepartmentFacade instance = new DepartmentFacade(new DepartmentModel());
		protected DepartmentFacade(DepartmentModel model) : base(model)
		{
		}
		public static DepartmentFacade Instance
		{
			get { return instance; }
		}
		protected DepartmentFacade():base() 
		{ 
		} 
	
	}
}
	
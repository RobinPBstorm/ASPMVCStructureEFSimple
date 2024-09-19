using Azure.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureEFSimple.BLL.Models.Exceptions
{
	public class PersonneNotFoundException: Exception
	{
		public PersonneNotFoundException(): base( "Aucune personne n'a été trouvé") { }

		public PersonneNotFoundException(string message) :base (message) { }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleEventRostering.Models
{
	public class EventModel
	{
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public IDictionary<UserModel.Role, int> RolesNeeded { get; set; }

	}
}

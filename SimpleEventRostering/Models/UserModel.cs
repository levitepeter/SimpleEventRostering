using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleEventRostering.Models
{
	public class UserModel
	{
		public string Name { get; set; }
		public string Mobile { get; set; }
		public string Email { get; set; }
		public IList<ApcCentre> CentresAvailableAt { get; set; }
		public IList<Role> RolesKnown { get; set; }

		public enum ApcCentre
		{
			BangaloreCentre,
			BangaloreNorth,
			BangaloreEast,
			BangaloreWest,
			BangaloreSouth,
		}

		public enum Role
		{
			SetupHead,
			SoundHead,
			WeightLifter,
			Instrument
		}
	}
}

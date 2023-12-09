using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Final_Project
{
	public class Session
	{
		public int SessionID { get; }
		public int ID { get; }
		public DateTime AliveTime { get; }
		public int CurrentUserPrivilege { get; }

		public Session(int sessionId, int id, DateTime aliveTime, int currentUserPrivilege)
		{
			SessionID = sessionId;
			ID = id;
			AliveTime = aliveTime;
			CurrentUserPrivilege = currentUserPrivilege;
		}

		public void AddSchedule(int currentUserPrivilege, int ID)
		{
			Console.WriteLine($"Added schedule with ID {ID}");
		}
	}
}

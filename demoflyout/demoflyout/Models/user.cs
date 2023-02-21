using System;
using SQLite;

namespace demoflyout.Models
{
	public class user
	{
		[PrimaryKey,AutoIncrement]
		public int Id { get; set; }
		public string username { get; set; }
		public string avatar { get; set; }
	}
}


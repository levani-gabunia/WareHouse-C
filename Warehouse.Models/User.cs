﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
	public class User
	{
		public int ID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string UserGroup { get; set; }
	}
}

using System;
using System.Collections.Generic;

namespace RentalOffer.Core {
	
	public class Solution
	{
		public string Name;
		public string Value;
	}
	
	public class Member
	{
		public string Id;
		public string Type;
		public string Name;
	}

    public class NeedPacket
    {
	public string Id;
	public string Need;
        public List<Solution> Solutions = new List<Solution>();
	public DateTime Time = DateTime.Now;
	public Member Member;
    }
}

using System;
using System.Collections.Generic;

namespace GenericCollectionTut {
	class Program {
		static void Main(string[] args) {

			var ints = new List<int>();
			ints.Add(7);
			ints.Add(10);
			ints.Add(3);
			ints.Add(6);
			ints.Add(96);
			ints.Add(22);

			foreach (var item in ints) {
				Console.WriteLine($"Favorite number is {item}.");
			}

			var strs = new List<string> {
				"orange",
				"blue",
				"gray",
				"red",
				"black",
				"green"
			};
			Console.WriteLine($"\nFavorite color count is {strs.Count}.\n");
			strs.Sort();
			foreach (var item in strs) {
				Console.WriteLine($"Favorite color is {item}.");
			}


			var WxHist = new List<Weather>(4);
			var DtThr = new Weather {
				Time = new DateTime(2021, 2, 18),
				Temp = 19,
				Precipitation = 3
			};
			WxHist.Add(DtThr);

			var DtWed = new Weather {
				Time = new DateTime(2021,2,17),
				Temp = 15,
				Precipitation = 0
			};
			WxHist.Add(DtWed);

			var DtTue = new Weather {
				Time = new DateTime(2021,2,16),
				Temp = 16,
				Precipitation = 4
			};
			WxHist.Add(DtTue);

			var DtMon = new Weather {
				Time = new DateTime(2021,2,15),
				Temp = 17,
				Precipitation = 8
			};
			WxHist.Add(DtMon);

			foreach(var day in WxHist) {
				var msg = $"Weather for {day.Time.ToString("MM, ddd, yyyy")}" + 
					$"Precipitation was {day.Precipitation}" +
					$"With a high temp of {day.Temp}";
				Console.WriteLine(msg);
			}

			var myFriends = new List<Friend>(3);

			var friend1 = new Friend {
				name = "frind1",
				email = "friend1@email.com",
				BFF = true
			};
			myFriends.Add(friend1);
			var friend2 = new Friend {
				name = "frind2",
				email = "friend2@email.com",
				BFF = true
			};
			myFriends.Add(friend2);
			var friend3 = new Friend {
				name = "frind3",
				email = "friend3@email.com",
				BFF = false
			};
			myFriends.Add(friend3);

			foreach (var f in myFriends) {
				Console.WriteLine($"{f.name}");
			}

		}
	}
}

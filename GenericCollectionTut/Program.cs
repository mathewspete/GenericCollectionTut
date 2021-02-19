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


		}
	}
}

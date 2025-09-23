using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace OlderLib {
	internal class ImperativeCode {
		public List<Tour> GetActiveTours(List<Tour> tours) {
			var result = new List<Tour>();
			foreach (var tour in tours)
			{
				if (tour.IsActive && tour.StartDate > DateTime.Now)
				{
					result.Add(tour);
				} 
			}
			return result;
		}

		public List<string> GetShortBeginnerTourNames(List<Tour> tours) {
			var result = new List<string>();
			foreach (var tour in tours)
			{
				if (tour.Difficulty == DifficultyLevel.Beginner && tour.DurationDays < 7)
				{
					result.Add(tour.Name);
				}
			}
			return result;
		}
	}
}

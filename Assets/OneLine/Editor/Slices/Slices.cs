﻿using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace OneLine {
	internal class Slices : IEnumerable<Slice> {

		private List<Slice> slices = new List<Slice>();
		
		public IEnumerable<float> Weights {
			get {
				return slices.Select(x => x.Weight);
			}
		}

		public IEnumerable<float> Widthes {
			get {
				return slices.Select(x => x.Width);
			}
		}

		public void Add(Slice slice){
			slices.Add(slice);
		}

		public void Add(IEnumerable<Slice> slices){
			foreach (var slice in slices){
				Add(slice);
			}
		}

		public Slice this[int i] {
			get {return slices[i];}
		}

		public IEnumerator<Slice> GetEnumerator(){
			return slices.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator(){
			return GetEnumerator();
		}

	}
}
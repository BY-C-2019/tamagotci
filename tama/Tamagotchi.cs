using System;

namespace Tama {

	abstract class Tamagotchi {
		protected static int maxRestedLevel = 50;
		protected static int maxFeededLevel = 50;
		private int restedLevel;
		private int feedLevel;
		private Room room;

		private void SetUpTamagotchi(Room startingRoom) {
			this.restedLevel = Tamagotchi.maxRestedLevel;
			this.feedLevel = Tamagotchi.maxFeededLevel;
			this.room = startingRoom;
		}

		public Tamagotchi(Room startingRoom) : this() {
			SetUpTamagotchi(startingRoom);
		}

		public Tamagotchi() {
			Room startingRoom = new Bedroom();
			SetUpTamagotchi(startingRoom);
		}

		public virtual bool Rested {
			get {
				return (restedLevel > 10);
			}
		}
		public virtual bool Hungry {
			get {
				return (feedLevel < 10);
			}
		}

		public bool Dead {
			get {
				if (feedLevel <= 0) {
					return true;
				}
				return false;
			}
		}

		public abstract bool Happy {
			get;
		}

		public void Feed() {
			Console.WriteLine("Matning utförd.");
			feedLevel = Tamagotchi.maxFeededLevel;
		}

		public virtual void Play() {
			Console.WriteLine("Lek gjordes.");
		}

		public void Rest() {
			Console.WriteLine("Vila utförd.");
			restedLevel = Tamagotchi.maxRestedLevel;
		}

		public void MoveToRoom(Room newRoom) {
			this.room = newRoom;
		}

		public void Wait() {
			this.feedLevel--;
			this.restedLevel--;
		}
	}

	sealed class YellowGotchi : Tamagotchi {

		public YellowGotchi() : base() {
		}

		public YellowGotchi(Room room) : base(room) {
		}

		public override bool Happy {
			get {
				return true;
			}
		}
	}

	sealed class RedGotchi : Tamagotchi {
		private int playLevel;

		public override bool Happy {
			get {
				return (playLevel > 20);
			}
		}

		public override void Play() {
			base.Play();
			if (this.Hungry) {
				playLevel = 25;
			} else {
				playLevel = 50;
			}
		}
	}
}
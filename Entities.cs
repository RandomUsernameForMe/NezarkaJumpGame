using NezarkaBookstoreWeb;
using System;
using System.Drawing;

namespace JumpingPlatformGame {

	class Entity {
		public virtual Color Color => Color.Black;
		public WorldPoint Location;
		
		public virtual void Update(Time sec)
		{
			
		}
		
	}
	class MovableEntity : Entity {
		public Move Horizontal;
		public MovableEntity()
		{
			Horizontal = new Move();
		}
		public override void Update(Time sec)
		{
			Physics.Move(sec, Horizontal.Speed, Horizontal.LowerBound.Meters, Horizontal.UpperBound.Meters, Location.X,false);			
		}
	}

	class MovableJumpingEntity : MovableEntity {
		public Move Vertical;

		public MovableJumpingEntity()
		{
			Vertical = new Move();
		}
		public override void Update(Time sec)
		{			
			Physics.Move(sec, Horizontal.Speed, Horizontal.LowerBound.Meters, Horizontal.UpperBound.Meters, Location.X, false);
			Physics.Move(sec, Vertical.Speed, Vertical.LowerBound.Meters, Vertical.UpperBound.Meters, Location.Y, true);			
		}
	}

	class CustomerEntity : MovableEntity
	{
		Customer source;
		public override string ToString() => string.Format("{0} {1}",source.FirstName, source.LastName);
		public override Color Color => Color.Blue;
	}

}
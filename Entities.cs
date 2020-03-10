using NezarkaBookstoreWeb;
using System;
using System.Drawing;

namespace JumpingPlatformGame
{

    class Entity
    {
        public string name;
        public virtual Color Color => Color.Black;
        public WorldPoint Location;

        public virtual void Update(Time sec)
        {

        }

    }
    class MovableEntity : Entity
    {
        public Move Horizontal;
        public MovableEntity()
        {
            Horizontal = new Move();
        }
        public override void Update(Time sec)
        {
            Physics.Move(sec, Horizontal.Speed, Horizontal.LowerBound.Meters, Horizontal.UpperBound.Meters, Location.X, false);
        }
    }

    class MovableJumpingEntity : MovableEntity
    {
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
        int? years;
        public override Color Color
        {
            get
            {
                switch (years)
                {
                    case null:
                        return Color.Gold;
                    case 0:
                        return Color.Black;
                    case 1:
                        return Color.DarkRed;
                    case 2:
                        return Color.Red;
                    case 3:
                        return Color.IndianRed;
                    default:
                        return Color.OrangeRed;     

                }
            }
        }

        public CustomerEntity(Customer other)
        {
            name = other.ToString(); 
            
                if (other.DateJoined == null)
                {
                    years = null;
                    return;
                }
                TimeSpan? timespan = DateTime.Now - other.DateJoined;
                years = (int)(timespan.Value.TotalDays) / 365;
            
        }

    }
}
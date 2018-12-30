using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seeking_game
{
    class OutsideWithDoor : OutsideWithHidingPlace, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription)
            : base(name, hot)
        {
            this.DoorDescription = doorDescription;
        }

        public Location DoorLocation { get; set; }
        public string DoorDescription { get; private set; }

        public override string Description
        {
            get
            {
                return base.Description + " Now you can see " + DoorDescription + ".";
            }
        }
    }
}

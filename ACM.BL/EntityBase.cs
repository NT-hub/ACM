using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    //by adding abstract keyword ,this class only be
    //used as a base class.
   public abstract class EntityBase
   {
        public enum EntityStateOption
        {
            Active,
            Deleted
        }
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }

        // we want this property to call the Validate
        // method of the appropriate entity object
        // it can not call our derived class Validate method
        // but it can call a local Validate method.
        public bool IsValid
        {
            get { return Validate(); } 
        }
        // create local Validate function
        public bool Validate()
        {

        }
    }
}

using System.Data;
//Class Admin is het object van een gebruiker account die adminstrator is

namespace WPR
{
    public class Administrator : OurUser {
        public Administrator(){
            this.Role = "Administrator";
        }
    }

    
}

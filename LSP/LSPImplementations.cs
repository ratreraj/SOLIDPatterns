using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{


    public interface IMemberShip : ITraing
    {
        void add();
    }
    public class MemeberShip : IMemberShip
    {
        public virtual void add()
        {
            // DO 
        }

        public virtual int GetTraing()
        {
            return 2;
        }
    }
    public interface ITraing
    {
        int GetTraing();
    }

    public class PlusMembership : MemeberShip
    {
        public override void add()
        {
            throw new NotImplementedException();
        }

        public override int GetTraing()
        {
            return 10;
        }
    }
    public class ProMembership : MemeberShip
    {
        public override void add()
        {
            throw new NotImplementedException();
        }

        public override int GetTraing()
        {
            return 20;
        }
    }

    public class TrailMember : ITraing
    {

        public int GetTraing()
        {
            return 2;
        }
    }

    //public class TrailMember : MemeberShip
    //{
    //    public override void add()
    //    {
    //        throw new NotImplementedException("Do not want save the trail member in db because it is only enquiry for us");
    //    }

    //    public override int GetTraing()
    //    {
    //        return 2; 
    //    }
    //}


}

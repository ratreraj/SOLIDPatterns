using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{

    public interface ITraing
    {
        int GetTraing();
    }
    public interface IMemberShip : ITraing
    {
        void add();
    }

    public interface ILiveTraining : IMemberShip
    {

        int GetLiveTraing();

    }
    public class MemeberShip : IMemberShip, ILiveTraining
    {
        public virtual void add()
        {
            // DO 
        }

        public virtual int GetLiveTraing()
        {
            return 0;
        }

        public virtual int GetTraing()
        {
            return 2;
        }
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


    public class PremiumMemberShip : MemeberShip
    {
        public override void add()
        {
            throw new NotImplementedException();
        }

        public override int GetTraing()
        {
            return 20;
        }

        public override int GetLiveTraing()
        {
            return 10;
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

    class Program
    {
        static void Main(string[] args)
        {
            IMemberShip memberShip = new ProMembership();
            ILiveTraining memberShip1 = new PremiumMemberShip();
        }

    }
}

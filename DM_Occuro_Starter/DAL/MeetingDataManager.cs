using System.Threading.Tasks;
using DAL.Mongo;
using Model;

namespace DAL
{
    public class MeetingDataManager
    {
        protected readonly MongoDataContext<Meeting> DataContext = new MongoDataContext<Meeting>();

        public MeetingDataManager()
        {
            
        }
    }
}
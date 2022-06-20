using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class AppContext : IDB<App, string>
    {
        private Izpit3Context ctx;

        public AppContext()
        {
            ctx = new Izpit3Context();
        }
        public void Create(App item)
        {
            try
            {
                ctx.Apps.Add(item);
                ctx.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public App Read(string key)
        {
            try
            {
                 return ctx.Apps.Find(key);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public IEnumerable<App> ReadAll()
        {
            try
            {
                return ctx.Apps.ToList();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public void Update(App item)
        {
            try
            {
                App oldapp = Read(item.ID);
                ctx.Entry(oldapp).CurrentValues.SetValues(item);
                ctx.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public void Delete(string key)
        {
            try
            {
                App app = Read(key);
                ctx.Apps.Remove(app);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        
    }
}
